using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace RandomGenerator
{
    class Program
    {
        static void Main(string[] args)
        {


            var rand = new Random();
            int num = rand.Next(100000);
            List<int> String = new List<int>();
            // int[] String = new int[num];

            String.Add(num);

            while (String.Count <= 99999){

                num = rand.Next(10000000);
                var verif = true;
                for (int x = 0; x < String.Count; x++)
                {

                    var con= String.ElementAt(x);
                    if (num==con) { verif = false;}
                    
                    
                }
                
                if (verif == true) { String.Add(num); }
               
            }


            File.WriteAllLines("RandomResultado.txt", String.Select(x => x.ToString()));

           /* StreamWriter writer = new StreamWriter("RandomResultado.txt");
            writer.Write(String.ToString());
            writer.Close();*/
        }
    }
}
