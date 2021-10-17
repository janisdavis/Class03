using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        /**
           * Origination:
           * Audi -> Germany
           * BMW -> Germany
           * Honda -> Japan
           * Mercedes -> Germany
           * VolksWagen -> Germany
           * Tesla -> USA
           */

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            //todo - replace array with an List and print out the results

            ArrayList aList = new ArrayList();
            aList.AddRange(array);

            foreach(object o in aList)
            {
                Console.WriteLine(o);
            }

            //todo - replace array with a HashSet and print out the results
            var list = new HashSet<string> { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            Console.WriteLine(string.Join(",", list));

            //list.ForEach(Console.WriteLine);

            //todo - replace array with a Dictionary (use brand as key and origination as value) and print out the results
            Dictionary<string, string> carBrand = new Dictionary<string, string>();
            carBrand.Add("Audi", "Germany");
            carBrand.Add("BMW", "Germany");
            carBrand.Add("Honda", "Japan");
            carBrand.Add("Mercedes", "Germany");
            carBrand.Add("VolksWagen", "Germany");
            carBrand.Add("Tesla", "USA");
            
            foreach(object a in carBrand) 
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();

        }
    }
}
