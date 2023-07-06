using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public abstract class AndriodBase
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public double DevelopmentCost { get; set; }
        public double CompanyCost { get; set; }

        public virtual void PriceBenchmark() { }
    }

    public class ChromeBook : AndriodBase
    {

    }
    public class GooglePixelMobile : AndriodBase
    {
        public bool LightWeight { get; set; }

        public override void PriceBenchmark()
        {
            Price = DevelopmentCost + CompanyCost;
            Console.WriteLine("Price  : " + Price + Environment.NewLine);
        }
    }

    public class GoogleBookTablet : AndriodBase
    {
        public double ResearchCost { get; set; }
        public override void PriceBenchmark()
        {
            Price = DevelopmentCost + CompanyCost + ResearchCost;
            Console.WriteLine("Price  : "+Price+Environment.NewLine);

        }
    }
}
