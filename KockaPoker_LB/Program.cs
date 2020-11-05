using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KockaPoker_LB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dobas d = new Dobas(5,5,5,3,5);
            StreamReader file = new StreamReader("kockapoker.txt");
            while (!file.EndOfStream)
            {
                string[] a = file.ReadLine().Split(',');
                List<int> sz = a.Select(x => int.Parse(x)).ToList();
                Dobas d = new Dobas(sz[0], sz[1], sz[2], sz[3], sz[4]);
                d.Kiiras();
            }
            file.Close();
            //d.EgyDobas();
            //d.Kiiras();
            Console.ReadLine();
        }
    }
}
