﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _28._4
{
    internal class prestito
    {
        public string  Numero { get; set; }
        public  DateTime Daqualegiorno { get; set; }
        public DateTime Aqualegiorno { get; set; }
        public documento Documento { get; set; }
        public utente utente { get; set; }
    }
}
