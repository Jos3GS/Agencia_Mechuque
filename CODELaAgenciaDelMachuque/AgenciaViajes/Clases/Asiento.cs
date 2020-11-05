using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Clases
{
    class Asiento
    {

        private string nroSilla;
        private bool statusR;
       

        public Asiento(string nroSilla, bool statusR)
        {
            this.nroSilla = nroSilla;
            this.statusR = statusR;
        }

        public string NroSilla { get => nroSilla; }
        public bool StatusR { get => statusR; set => statusR = value; }

        
    }
}
