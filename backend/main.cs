using System;
using Newtonsoft.Json.Linq;
using System.Collections;
using log4net.Config;
using helpers;

[assembly: XmlConfigurator(ConfigFile = "log4net.config")]
namespace backend;

public static class main
{
    /// <summary>
    /// Setting up the logger 
    /// </summary>
    public static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public static void Main()
    {
        logger.Info("Backend has started");
    }

    /// <summary>
    /// This method recieves the postcodes from the user, calls a function from helpers to check if they are valid postcodes using regex
    /// If they are valid, the method to talk to the API is called which returns an ArrayList
    /// The ArrayList is sent to the frontend to have its data displayed to the user
    /// </summary>
    public static ArrayList grabInfo(string pc1, string pc2)
    {
        ArrayList data = new ArrayList();
        Boolean pcAreValid = helpers.validation.validatePostcodes(pc1, pc2);
        if (pcAreValid)
        {
            logger.Info("Valid postcodes were provided from regex: " + pc1 + " " + pc2);
            data = method(pc1, pc2);
        }
        else
        {
            logger.Error("User didn't input valid postcodes - validated by regex: " + pc1 + " " + pc2);
        }
        return data;
    }

    /// <summary>
    /// This method retrives the data from the API using method grabData from helpers
    /// If status of data is ok it stores the data into variables to be added into an ArrayList mentioned above
    /// Otherwise it will let you know it is unable to send a response
    /// </summary>
    public static ArrayList method(String pc1, String pc2)
    {
        ArrayList jsonData = new ArrayList();
        JObject json = helpers.googleAPI.grabData(pc1, pc2);
        Boolean statusAPI = helpers.googleAPI.checkStatus(json);
        if (statusAPI)
        {
            logger.Info("Data has been grabbed from the API successfully");
            jsonData = helpers.googleAPI.parseData(json);
        }
        else
        {
            logger.Fatal("API request status not ok, postcodes are wrong or API is down");
        }
        return jsonData;
    }
}
