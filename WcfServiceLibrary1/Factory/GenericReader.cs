using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1.Factory
{
    public class GenericReader : IFactory
    {
        public override IEnumerable<PersonalData> ReadData()
        {
            var dataReturn = new List<PersonalData>();

            var component = Component.GenericReader.HandleRead.Process("READDATA");
            var data = component.Substring(16).Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            data.ForEach(c =>
            {
                var strData = c.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                dataReturn.Add(new PersonalData
                {
                    FirstName = strData[0],
                    LastName = strData[1],
                    Country = strData[2],
                    Age = int.Parse(strData[3])
                });
            });

            return dataReturn;
        }
    }
}
