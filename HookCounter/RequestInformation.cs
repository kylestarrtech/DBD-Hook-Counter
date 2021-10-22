using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookCounter
{
    public enum RequestType
    {
        hooks, kills
    }
    public class RequestInformation
    {
        public RequestType request;
        public string URL;

        public void SendPOSTRequest()
        {

        }

        public string ConvertToJSON()
        {
            string finalJSON =
                "{" +
                    "\"hooks\": [" +
                    "" +
                    "]" +
                "}";
            return "";
        }
    }
}
