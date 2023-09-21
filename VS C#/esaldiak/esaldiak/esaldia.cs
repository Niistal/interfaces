using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esaldiak
{
    internal class Esaldia
    {//propidades
        public string Testua { get; set; }
        public string Esaldialotuta {  get; set; }
        //Konstruktorea
        public Esaldia()
        {

        }
        //metodoak
       
        public void Esaldiabatu()

        {   
            
            Esaldialotuta = Esaldialotuta+Testua;
        }

        
    }
}
