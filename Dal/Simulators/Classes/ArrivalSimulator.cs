using Dal.Simulators.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Dal.Simulators.Classes
{
    public class ArrivalSimulator : IArrivalSimulator
    {
        private string _serverBaseUrl = "http://localhost:63341";

        public void EmitArrival()
        {
            GenerateRandomFlight();

        }

        private void GenerateRandomFlight()
        {
            SendFlight(new Flight { FlightNum = 1, Contry = "Finland", IsArrival = true, IsDeparture = false });
        }

        private void SendFlight(Flight flight)
        {
            var httpReq = (HttpWebRequest)WebRequest.Create($"{_serverBaseUrl}/airport");
            httpReq.ContentType = "application/json";
            httpReq.Method = "POST";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpReq.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(flight);
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }           
        }
    }
}
