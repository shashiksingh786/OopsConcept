using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    /// <summary>
    /// Abstract class concept - use of abstract class and abstract method
    /// </summary>
    public abstract class AndriodBase
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public double DevelopmentCost { get; set; }
        public double CompanyCost { get; set; }

        
        /// <summary>
        /// use as abstract - if derived class to be forced to implement method of abstract class
        /// </summary>
        //public abstract void PriceBenchmark();

        /// <summary>
        /// use as virtual - if derived class is not forced to be implement method which is in abstract class
        /// </summary>
        public virtual void PriceBenchmark() { }
    }

    /// <summary>
    /// derived class - inherited the AndriodBase abstract class
    /// </summary>
    public class ChromeBook : AndriodBase
    {

    }

    /// <summary>
    /// derived class - inherited the AndriodBase abstract class
    /// </summary>
    public class GooglePixelMobile : AndriodBase
    {
        public bool LightWeight { get; set; }

        public override void PriceBenchmark()
        {
            Price = DevelopmentCost + CompanyCost;
            Console.WriteLine("Price  : " + Price + Environment.NewLine);
        }
    }

    /// <summary>
    /// derived class - inherited the AndriodBase abstract class
    /// </summary>
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
