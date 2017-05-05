using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceLibrary1.Factory;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service : IComponentManager
    {
        public IEnumerable<PersonalData> ReadData()
        {
            var component = Factory.Factory.Get(ConfigurationSettings.AppSettings["COMPONENT_TYPE"].ToString());

            if (component != null) return component.ReadData();
            else return null;
        }
    }
}
