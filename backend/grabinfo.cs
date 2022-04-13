using System.Net;
using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;
using log4net.Config;

[assembly: XmlConfigurator(ConfigFile = "log4net.config")]
namespace backend;

public static class Program1
{
    /// <summary>
    /// Declaring all variables that can be used globally throughout the class as well as instantiating the logger
    /// </summary>
    private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    static double miles;
    static double km;
    static int meters;
    static string postcode1 = "";
    static string postcode2 = "";
    static string origin = "";
    static string dest = "";
    static string time = "";

    public static void Main(string[] args)
    {
        Console.WriteLine("Backend Running");
        logger.Info("Backend has been accessed");
    }

    /// <summary>
    /// This method recieves the postcodes from the user, checks if they are valid with some regex as well as returning the final values from the API through an ArrayList 
    /// The ArrayList is sent to the frontend to have its data displayed to the user
    /// </summary>
    public static ArrayList grabInfo(string pc1, string pc2)
    {
        Console.WriteLine(pc1);
        Console.WriteLine(pc2);
        postcode1 = pc1;
        postcode2 = pc2;
        var match1 = Regex.Match(pc1, @"^([A-Za-z][A-Ha-hJ-Yj-y]?[0-9][A-Za-z0-9]? ?[0-9][A-Za-z]{2}|[Gg][Ii][Rr] ?0[Aa]{2})$");
        var match2 = Regex.Match(pc2, @"^([A-Za-z][A-Ha-hJ-Yj-y]?[0-9][A-Za-z0-9]? ?[0-9][A-Za-z]{2}|[Gg][Ii][Rr] ?0[Aa]{2})$");
        if (!match1.Success || !match2.Success)
        {
            logger.Error("User didn't input valid postcodes - validated by regex");
            MessageBox.Show("Please make sure you have entered valid postcodes");
        }
        else
        {
            method();
        }
        var data = new ArrayList();
        data.Add(miles);
        data.Add(km);
        data.Add(origin);
        data.Add(dest);
        data.Add(time);
        Console.WriteLine(data.ToString());
        return data;
    }

    /// <summary>
    /// This method retrives the data from the API and stores the data into variables to be added into an ArrayList mentioned above
    /// Enter your Google Maps API key below....
    /// </summary>
    public static void method()
    {
        String apiKey = "ENTER API KEY HERE";
        String url = "https://maps.googleapis.com/maps/api/distancematrix/json?origins=" + postcode1 + "&destinations=" + postcode2 + "&mode=driving&language=en-EN&sensor=false&key=" + apiKey;
        var request = WebRequest.Create(url);
        request.Method = "GET";
        using var webResponse = request.GetResponse();
        using var webStream = webResponse.GetResponseStream();
        using var reader = new System.IO.StreamReader(webStream);
        var data = reader.ReadToEnd();
        var json = JObject.Parse(data);
        string status = (string)json["status"];
        if (status.Equals("OK"))
        {
            try
            {
                var jsonDist = json["rows"][0]["elements"][0]["distance"]["value"];
                var jsonOrigin = json["origin_addresses"][0];
                var jsonDest = json["destination_addresses"][0];
                var jsonTime = json["rows"][0]["elements"][0]["duration"]["text"];
                if ((int)jsonDist >= 0 != true)
                {
                    MessageBox.Show("Something went wrong grabbing the data....");
                    logger.Error("No data has been grabbed from the API");
                }
                meters = JsonConvert.DeserializeObject<int>((string)jsonDist);
                origin = (string)jsonOrigin;
                dest = (string)jsonDest;
                time = (string)jsonTime;
                km = meters / 1000;
                miles = meters * 0.000621;
                logger.Info("Data has been grabbed from the API successfully");
            }
            catch (Exception ex)
            {
                logger.Fatal(ex.Message);
                logger.Error("Likely due to incorrect/invalid postcode or API has stopped working");
                MessageBox.Show("Something has gone wrong with the API.... Check you have entered valid postcodes....." + ex.Message);
            }
        }
    }

}
