//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit.Framework;
//using Newtonsoft.Json;

//namespace TestDemo5
//{
//    [TestFixture]
//    public class APITest
//    {
//        string url = " https://reqres.in/api/users/2";
//        string html;
//        [Test]
//        public void getMethod()
//        {
//            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
//            request.Method = "GET";
//            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
//            Stream stream = response.GetResponseStream();
//            using (StreamReader reader = new StreamReader(stream))
//            {
//                html = reader.ReadToEnd();
//            }
//            //var apIResponse = JsonConvert.DeserializeObject<Rootobject>(html);
//            //Assert.IsTrue(response.StatusCode.Equals("OK"));
//            //Assert.IsTrue(apIResponse.data.id.Equals(2));
//        }
//    }
//}
