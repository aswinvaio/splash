using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Splash.Lib.DTO
{
    [DataContract]
    public class Message
    {
        [DataMember]
        public string Header { get; set; }
        [DataMember]
        public string Body { get; set; }
        [DataMember]
        public DateTime Time { get; set; }

        public Message(string header, DateTime time)
        {
            Header = header;
            Time = time;
        }
    }
}
