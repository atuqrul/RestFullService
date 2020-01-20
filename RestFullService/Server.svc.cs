using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RestFullService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Server" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Server.svc or Server.svc.cs at the Solution Explorer and start debugging.
    public class Server : IServer
    {
        public string Samp()
        {
            return "Hello World";
        }

        public void DoWork()
        {
        }
    }
}
