using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1.Factory
{
    public class PolarReader : IFactory
    {
        public override IEnumerable<PersonalData> ReadData()
        {
            var dataReturn = new List<PersonalData>();

            var component = Component.PolarReader.HandleRead.Process("CM-READ");
            var data = component.Split(new[] { '&' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            data.ForEach(c =>
            {
                dataReturn.Add(new PersonalData
                {
                    FirstName = c.Substring(0, 20).Split(',')[0],
                    LastName = c.Substring(0, 20).Split(',')[1].Trim(),
                    Country = c.Substring(20, 3),
                    Age = int.Parse(c.Substring(23, 3))
                });
            });

            return dataReturn;
        }
    }
}
