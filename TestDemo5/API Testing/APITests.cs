using NUnit.Framework;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace TestDemo5
{
    [TestFixture]
    class APITests
    {
        private IConfiguration configuration1;
        string url = null;

        [SetUp]
        public void SetUp()
        {
            // Load configuration
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            configuration1 = builder.Build();
            url = configuration1["APIUrl"];
        }
      
       // string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
       

        [Test]
        public void APIAutomationGetMethod()
        {
            // Step 1: Send the GET request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        Console.WriteLine("GET request successful.");

                        // Step 2: Parse the JSON response
                        using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                        {
                            string responseBody = reader.ReadToEnd();
                            JObject jsonResponse = JObject.Parse(responseBody);

                            // Verify there are 3 BPIs (USD, GBP, EUR)
                            var bpi = jsonResponse["bpi"];
                            if (bpi == null)
                            {
                                Console.WriteLine("Test Failed: 'bpi' object not found in the response.");
                                return;
                            }

                            string[] expectedCurrencies = { "USD", "GBP", "EUR" };
                            foreach (var currency in expectedCurrencies)
                            {
                                if (bpi[currency] == null)
                                {
                                    Console.WriteLine($"Test Failed: '{currency}' BPI not found.");
                                    return;
                                }
                            }

                            Console.WriteLine("Test Passed: All expected BPIs (USD, GBP, EUR) are present.");

                            // Verify the GBP 'description' equals 'British Pound Sterling'
                            string gbpDescription = bpi["GBP"]?["description"]?.ToString();
                            if (gbpDescription == "British Pound Sterling")
                            {
                                Console.WriteLine("Test Passed: GBP description matches 'British Pound Sterling'.");
                            }
                            else
                            {
                                Console.WriteLine($"Test Failed: GBP description mismatch. Expected 'British Pound Sterling', but got '{gbpDescription}'.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Test Failed: GET request failed with status code {response.StatusCode}.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test Failed: {ex.Message}");
            }
        }
        }
}
