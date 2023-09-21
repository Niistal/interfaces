using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oinaarrizko_Kalkulagailua
{
    internal class kalkulagailua
    {
        //propidades
        public float Zenbaki1 {  get; set; }
        public float Zenbaki2 { get; set; }
        //Konstruktorea
        public kalkulagailua() {
            Zenbaki1 = 0;
            Zenbaki2 = 0;
        }
        public kalkulagailua(float zenbaki1,float zenbaki2) {
            this.Zenbaki1 = zenbaki1;
            this.Zenbaki2 = zenbaki2;
            
        }
        //metodoak
        public float Gehiketa()
        {
            return Zenbaki1 + Zenbaki2;
        }
        public float Kenketa()
        {
            return Zenbaki1 - Zenbaki2;
        }
        public float Biderketa()
        {
            return Zenbaki1 * Zenbaki2;
        }
        public float Zatiketa()
        {
            return Zenbaki1 / Zenbaki2;
        }
    }
}
