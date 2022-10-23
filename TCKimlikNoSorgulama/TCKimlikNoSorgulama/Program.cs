using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCKimlikNoSorgulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kimlik M1 = new Kimlik();

            M1.TCKimliknumarasi = "12245678901";

            string Tc = M1.TCKimliknumarasi;
        }
    }
}
