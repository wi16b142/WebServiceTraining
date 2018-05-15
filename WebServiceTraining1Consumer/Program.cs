using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace WebServiceTraining1Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            WCFSR.Service1Client wcfClient = new WCFSR.Service1Client("TCP");
            //WebServiceReferenceTraining1.WebService1SoapClient client = new WebServiceReferenceTraining1.WebService1SoapClient();
            //Console.WriteLine(client.HelloWorld());
            Console.WriteLine(wcfClient.HelloWorld());


            /*
            MessageQueue myreceivequeue = new MessageQueue(@"FormatName:direct=os:.\private$\test1");
            myreceivequeue.Formatter = new XmlMessageFormatter(new Type[]{typeof(string)});
            Message myMessage = myreceivequeue.Receive();
            
            Console.WriteLine((string)myMessage.Body.ToString());
            */

            Console.ReadLine();
        }
    }
}
