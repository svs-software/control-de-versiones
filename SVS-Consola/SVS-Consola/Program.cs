using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVS_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Practicante P1=new Practicante();
            P1.Id = "112435";
            P1.Nombre = "Alice";

            Practicante P2 = new Practicante();
            P2.Id = "112432";
            P2.Nombre = "Neli";

            Practicante P3 = new Practicante();
            P3.Id = "112125";
            P3.Nombre = "Elin";


            Console.WriteLine("P1");
            Console.WriteLine("ID: " + P1.Id);
            Console.WriteLine("NOmber: " + P1.Nombre);

            Console.WriteLine("P2");
            Console.WriteLine("ID: " + P2.Id);
            Console.WriteLine("NOmber: " + P2.Nombre);

            Console.WriteLine("P3");
            Console.WriteLine("ID: " + P3.Id);
            Console.WriteLine("NOmber: " + P3.Nombre);

            Console.ReadKey();

        }
    }
}
