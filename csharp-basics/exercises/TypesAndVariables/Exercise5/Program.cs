using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classes = { 
                "English III | Ms. Lapan",
                "Precalculus | Mrs. Gideon", 
                "Music Theory | Mr. Davis", 
                "Biotechnology | Ms. Palmer", 
                "Principles of Technology I | Ms. Garcia ",
                "Latin II | Mrs. Barnett ",
                "AP US History | Ms. Johannessen",
                "Business Computer Infomation Systems | Mr. James"};
            
            for (int i = 0; i < classes.Length; i++)
            Console.WriteLine(classes[i]);
            Console.ReadKey();
    }
    }
}
