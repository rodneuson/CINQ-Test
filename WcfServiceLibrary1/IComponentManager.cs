using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    [ServiceContract]
    public interface IComponentManager
    {
        [OperationContract]
        IEnumerable<PersonalData> ReadData();
    }

    [DataContract]
    public class PersonalData
    {
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public int Age { get; set; }
    }
}
