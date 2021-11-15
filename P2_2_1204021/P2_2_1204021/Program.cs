using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204021
{
    public class Program
    {
        static void Main(string[] args)
        {
            citaCita citacita = new citaCita("mewarnai", "guru");

            Console.WriteLine("Nama {0} memiliki hobby {1} dan cita-citanya menjadi {2}", citacita.Nama, citacita.Hobby, citacita.Cita);
        }
    }
}
