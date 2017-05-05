using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1.Factory
{
    public abstract class IFactory
    {
        public abstract IEnumerable<PersonalData> ReadData();
    }

    public static class Factory
    {
        public static IFactory Get(string type)
        {
            switch (type.ToUpper())
            {
                case "GENERIC":
                    return new GenericReader();
                case "POLAR":
                    return new PolarReader();
                default:
                    return null;
            }
        }
    }
}
