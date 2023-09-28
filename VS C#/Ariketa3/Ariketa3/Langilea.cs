﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa3
{
    internal class Langilea:Kontaktua
    {
        public float Soldata { get; set; }
        public string SegurtasunSoziala { get; set; }
        public override string Emaila
        {
            get => base.Emaila;
            set
            {
                if (value.Substring(value.Length - 14, 14) != "@iesunibhi.com")
                {
                    base.Emaila = value;
                }
                else
                {
                    Exception ex = new Exception("Emaila ez duzu ondo jarri");
                    throw ex;
                }
            }
        }

        public override string Gorde()
        {
            return "Langilea ondo gorde da";
        }
    }
}
