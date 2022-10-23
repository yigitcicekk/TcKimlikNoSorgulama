using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCKimlikNoSorgulama
{
    internal class Kimlik
    {
        private string _tckimliknumarasi;
        public string TCKimliknumarasi
        {
            get { return _tckimliknumarasi.Substring(0, 3); }
            set
            {
                if (value.Length == 11)
                {
                    bool bayrak = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);
                        if (karakterKontrol)
                        {
                            // sayısal değer demektir...
                        }
                        else
                        {
                            bayrak = true;
                            break;
                        }
                    }
                    if (bayrak)
                    {
                        Console.WriteLine("Tc Kimlik numarası içindeki değerler sayısal olmalıdır ");
                    }
                    else
                    {
                        this._tckimliknumarasi = value;
                    }
                }
                else
                {
                    Console.WriteLine("Tc Kimlik numarası 11 hane olmalıdır");
                }
            }
        }
    }
}
