using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace helpers
{
    /// <summary>
    /// This is the googleAPI class where all methods related to the Google API are stored
    /// </summary>
    internal class googleAPI
    {
        /// <summary>
        /// This method grabData takes postcodes as parameters
        /// These postcodes are sent to the API
        /// This JSON response is then returneds
        /// </summary>
        public static JObject grabData(string pc1, string pc2)
        {
            String apiKey = "ENTER API KEY HERE";
            String url = "https://maps.googleapis.com/maps/api/distancematrix/json?origins=" + pc1 + "&destinations=" + pc2 + "&mode=driving&language=en-EN&sensor=false&key=" + apiKey;
            var request = WebRequest.Create(url);
            request.Method = "GET";
            using var webResponse = request.GetResponse();
            using var webStream = webResponse.GetResponseStream();
            using var reader = new System.IO.StreamReader(webStream);
            var data = reader.ReadToEnd();
            var json = JObject.Parse(data);
            return json;
        }

        /// <summary>
        /// This method checkStatus makes sure that the API is working
        /// If the status of the API is down then it'll return false and let the user know
        /// If the status of the API is ok then it'll return true
        /// </summary>
        public static Boolean checkStatus(JObject json)
        {
            String statusOfAPI = (string)json["status"];
            String statusOfRes = (string)json["rows"][0]["elements"][0]["status"];
            if (statusOfAPI.Equals("OK") && statusOfRes.Equals("OK"))
            {
                return true;
            }
            else if (statusOfRes.Equals("NOT_FOUND")){
                MessageBox.Show("Something has gone wrong with the API.... Check you have entered valid postcodes.....");
                return false;
            }
            else
            {
                MessageBox.Show("Something has gone wrong with the API.... Check you have entered valid postcodes.....");
                return false;
            }
        }

        /// <summary>
        /// This parseData function takes the JSON data as an input
        /// It then parses that data and stores the information we need into variables
        /// These variables are then added to an ArrayList which is then returned
        /// </summary>
        public static ArrayList parseData(JObject json)
        {
            var data = new ArrayList();
            try
            {
                var jsonDist = json["rows"][0]["elements"][0]["distance"]["value"];
                var jsonOrigin = json["origin_addresses"][0];
                var jsonDest = json["destination_addresses"][0];
                var jsonTime = json["rows"][0]["elements"][0]["duration"]["text"];
                if ((int)jsonDist >= 0 != true)
                {
                    MessageBox.Show("Something has gone wrong with the API.... Check you have entered valid postcodes.....");
                }
                double meters = JsonConvert.DeserializeObject<int>((string)jsonDist);
                String origin = (string)jsonOrigin;
                String dest = (string)jsonDest;
                String time = (string)jsonTime;
                double km = meters / 1000;
                double miles = meters * 0.000621;

                data.Add(miles);
                data.Add(km);
                data.Add(origin);
                data.Add(dest);
                data.Add(time);
                return data;
            } catch(Exception ex)
            {
                MessageBox.Show("Something has gone wrong with the API.... Check you have entered valid postcodes.....");
                return data;
            }
            
        }
    }

    /// <summary>
    /// This class contains all the methods related to validation of postcodes
    /// </summary>
    internal class validation
    {
        /// <summary>
        /// This method uses regex to check if the postcodes entered are valid postcodes based on the regex which is for UK format
        /// Some invalid postcodes can still fall through the cracks at this part due to looking like a postcode but isnt
        /// </summary>
        public static Boolean validatePostcodes(string pc1, string pc2)
        {
            var match1 = Regex.Match(pc1, @"^([A-Za-z][A-Ha-hJ-Yj-y]?[0-9][A-Za-z0-9]? ?[0-9][A-Za-z]{2}|[Gg][Ii][Rr] ?0[Aa]{2})$");
            var match2 = Regex.Match(pc2, @"^([A-Za-z][A-Ha-hJ-Yj-y]?[0-9][A-Za-z0-9]? ?[0-9][A-Za-z]{2}|[Gg][Ii][Rr] ?0[Aa]{2})$");
            if(!match1.Success || !match2.Success)
            {
                MessageBox.Show("Please make sure you have entered valid postcodes");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
