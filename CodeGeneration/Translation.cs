using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
namespace CodeGeneration
{
    [DataContract]
    public class Translation
    {
        [DataMember]
        public string[] translation { get; set; }

        [DataMember]
        public Basic basic { get; set; }
        [DataMember]
        public string query { get; set; }

        [DataMember]
        public string errorCode { get; set; }

        [DataMember]
        public Web[] web { get; set; }

    }


    public class Basic
    {
        [DataMember]
        public string phonetic { get; set; }

        [DataMember]
        public string[] explains { get; set; }
    }

    public class Web
    {
        [DataMember]
        public string[] value { get; set; }

        [DataMember]
        public string key { get; set; }
    }
}
