using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleA
{
    public class Car
    {
        public int doors = 0;
        public string brand = "unknow";
        public string model = "unknow";

        private decimal _cc = 0;

        public decimal CC {
            get {
                Console.WriteLine("Qualcuno sta leggendo la proprietà CC");
                return _cc;
            }
            set {
                Console.WriteLine("Qualcuno sta cercando di modificare la proprietà CC");
                Console.WriteLine("Il valore attuale di CC è " + _cc);

                _cc = value;

                Console.WriteLine("Il nuovo valore di CC è " + _cc);

            }

        }


        public void Start() {
            Console.WriteLine("Ho acceso il motore");
        }

        public void Stop()
        {
            Console.WriteLine("Ho spento il motore");
        }


        public void GetGas() {
            Console.WriteLine("Ho fatto Benzina");
        }

        public int CalcDayInsuranceToEnd()
        {
            return 20;
        }

    }
}
