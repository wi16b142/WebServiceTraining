using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace WebServiceTraining1Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            WCFServiceReference1.Service1Client wcfClient = new WCFServiceReference1.Service1Client();
            WebServiceReferenceTraining1.WebService1SoapClient client = new WebServiceReferenceTraining1.WebService1SoapClient();
            Console.WriteLine(client.HelloWorld());
            Console.WriteLine(wcfClient.HelloWorld());


            MessageQueue myreceivequeue = new MessageQueue(@"FormatName:direct=os:.\private$\test1");
            myreceivequeue.Formatter = new XmlMessageFormatter(new Type[]{typeof(string)});
            Message myMessage = myreceivequeue.Receive();
            
            Console.WriteLine((string)myMessage.Body.ToString());

            Console.ReadLine();
        }
    }
}
