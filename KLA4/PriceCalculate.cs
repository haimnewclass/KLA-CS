using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA4
{
    internal class PriceCalculate
    {
        public void Run()
        {
            int itemPrice;
            int areaCode;

            itemPrice = int.Parse(Console.ReadLine());
            areaCode = int.Parse(Console.ReadLine());

            ICalulateTax selectedCalc = null;

            if(areaCode== 1 ) { 
                selectedCalc = new EilatPrice();
            } else if (areaCode == 2)
            {
                selectedCalc = new PituachAreaPrice();
            }
            else 
            {
                selectedCalc = new OtherPrice();
            }

            PurchaseItem purchaseItem = new PurchaseItem(selectedCalc);
            purchaseItem.PrintPrice(itemPrice);

        }
    }

    public class PurchaseItem
    {
        ICalulateTax CalcTax;
        public PurchaseItem(ICalulateTax calc)
        {
            CalcTax = calc;
        }

        public void PrintPrice(int price)
        {
            Console.WriteLine(CalcTax.AddTax(price));
        }
    }





    public interface ICalulateTax
    {
        int AddTax(int itemPrice);
    }

    public class EilatPrice : ICalulateTax
    {
        public int AddTax(int itemPrice)
        {
            int total = itemPrice + 0;
            return total;
        }
    }

    public class PituachAreaPrice : ICalulateTax
    {
        public int AddTax(int itemPrice)
        {
            int total = itemPrice +  5*itemPrice/100;
            return total;
        }
    }

    public class OtherPrice : ICalulateTax
    {
        public int AddTax(int itemPrice)
        {
            int total = itemPrice + 17 * itemPrice / 100;
            return total;
        }
    }
}
