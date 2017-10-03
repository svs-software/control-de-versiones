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

        }
    }
}
