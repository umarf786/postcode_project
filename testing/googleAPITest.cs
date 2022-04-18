using Microsoft.VisualStudio.TestTools.UnitTesting;
using helpers;
using System;

namespace testing
{
    /// <summary>
    /// This test should pass if the API call is successful at recieving a response with valid postcodes
    /// The API status should returns "OK"
    /// </summary>
    [TestClass]
    public class checkAPIWithValidPostcodes
    {
        [TestMethod]
        public void checkAPI()
        {
            try
            {
                var res = helpers.googleAPI.grabData("DN157AY", "BD71DB");
                String statusOfAPI = (string)res["status"];
                String status = "OK";
                Assert.AreEqual(status, statusOfAPI);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Assert.Fail();
            }
        }
    }

    /// <summary>
    /// This test should pass if the API call is not successful at recieving a response with valid postcodes
    /// The API status should returns "NOT_FOUND"
    /// </summary>
    [TestClass]
    public class checkAPIWithInvalidPostcodes
    {
        [TestMethod]
        public void checkAPI()
        {
            try
            {
                var res = helpers.googleAPI.grabData("DN157MA", "BD71SL");
                String statusOfRes = (string)res["rows"][0]["elements"][0]["status"];
                Assert.AreEqual(statusOfRes, "NOT_FOUND");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Assert.Fail();
            }
        }
    }

    /// <summary>
    /// This test should pass if the postcodes are invalid and recieves a false boolean value from the helper function
    /// </summary>
    [TestClass]
    public class checkIfPostcodesAreInvalid
    {
        [TestMethod]
        public void checkVal()
        {
            try
            {
                Boolean res = helpers.validation.validatePostcodes("AADf", "adqa");
                Assert.AreEqual(res, false);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Assert.Fail();
            }
        }
    }

    /// <summary>
    /// This test should pass if the postcodes are valid and recieves a true boolean value from the helper function
    /// </summary>
    [TestClass]
    public class checkIfPostcodesAreValid
    {
        [TestMethod]
        public void checkVal()
        {
            try
            {
                Boolean res = helpers.validation.validatePostcodes("DN157AY", "BD71DB");
                Assert.AreEqual(res, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Assert.Fail();
            }
        }
    }

    /// <summary>
    /// This test should pass if the data is parsed correctly and the origin value contains the original origin postcode
    /// </summary>
    [TestClass]
    public class checkIfDataIsPArsed
    {
        [TestMethod]
        public void checkParse()
        {
            try
            {
                var json = helpers.googleAPI.grabData("BD71DB", "DN157AY");
                var res = helpers.googleAPI.parseData(json);
                String stringRes = (string)res[2];
                Boolean isTrue = false;
                if (stringRes.Contains("BD7 1DB"))
                {
                    isTrue= true;
                }
                Assert.AreEqual(isTrue, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Assert.Fail();
            }
        }
    }

}







