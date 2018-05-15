using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;
using System.Messaging;

namespace MSMQTraining1
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageQueue mymsmq = new MessageQueue(@"FormatName:direct=os:.\private$\test1");
            mymsmq.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
            mymsmq.Send(new Message("MSMQ test"));

        }
    }
}
