using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public abstract class Country
    {
        public abstract string GetName();
    }

    class Belarus : Country
    {
        private string Code = "+375";
        public override string GetName() => $"Belarus ({Code})";
    }

    class France : Country
    {
        private string Code = "+12";
        public override string GetName() => $"France ({Code})";
    }

    class Germany : Country
    {
        private string Code = "+35";
        public override string GetName() => $"Germany ({Code})";
    }

    abstract class CountryAbstractFactory
    {
        public abstract Country CreateCountry();
    }

    class BelarusBuilder : CountryAbstractFactory
    {
        public override Country CreateCountry()
        {
            return new Belarus();
        }
    }

    class FranceBuilder : CountryAbstractFactory
    {
        public override Country CreateCountry()
        {
            return new France();
        }
    }

    class GermanyBuilder : CountryAbstractFactory
    {
        public override Country CreateCountry()
        {
            return new Germany();
        }
    }
}
