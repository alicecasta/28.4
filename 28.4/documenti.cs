using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._4
{
    internal class documento
    { 
        public string Codice { get; set; }
        public string Titolo { get; set; }
        public int anno { get; set; }
        public string Settore { get; set; }
        public string StatoPrestito { get; set; } 
        public string Scaffale { get; set; }    
        public List<Persona>Autori { get; set; }
    }
}
