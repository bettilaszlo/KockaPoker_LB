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
        static void Ellenorzes()
        {
            StreamReader file = new StreamReader("kockapoker.txt");
            while (!file.EndOfStream)
            {
                string[] a = file.ReadLine().Split(',');
                List<int> sz = a.Select(x => int.Parse(x)).ToList();
                Dobas d = new Dobas(sz[0], sz[1], sz[2], sz[3], sz[4]);
                d.Kiiras();
            }
            file.Close();

        }
        static void Main(string[] args)
        {
            //Dobas d = new Dobas(6, 6, 6, 2, 2);
            //d.EgyDobas();
            //d.Kiiras();
            //Ellenorzes();

            Dobas gep = new Dobas();
            Dobas ember = new Dobas();

            Console.Write("Gép:");
            gep.EgyDobas();
            gep.Kiiras();

            Console.Write("\nEmber:");
            ember.EgyDobas();
            ember.Kiiras();

            if (gep.Pont > ember.Pont)
            {
                Console.WriteLine("Gép nyert :(");
            }
            else if (ember.Pont > gep.Pont)
            {
                Console.WriteLine("Ember nyert :)");
            }
            else
            {
                Console.WriteLine("Döntetlen");
            }
            Console.ReadLine();
        }
    }
}
