using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;



namespace ConsoleApp2
{
    class Program
    {
        public static object JsonConvert { get; private set; }

        static void Main(string[] args)
        {

            WebRequest request = WebRequest.Create(@"https://api.openweathermap.org/data/2.5/weather?q=tampere&units=metric&appid=ba13b5feb3f961ed23f5195a6decb4e5");
            WebResponse response = request.GetResponse();
           // Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                int indexOfTemp = responseFromServer.IndexOf("temp");
                string ans = responseFromServer.Substring(indexOfTemp, 10);
                string temp = ans.Substring(6,4);
               
                //string name = (string)o["temp"];
                Console.WriteLine($"Lämpötila Tampereella on {temp} astetta.");
            }

            // Close the response.
            response.Close();
            
        }
    }
}
