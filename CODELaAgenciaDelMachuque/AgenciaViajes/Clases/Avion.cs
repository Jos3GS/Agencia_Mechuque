using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Clases
{
    class Avion
    {
        private ushort cantSillas;
        private List<Asiento> Sillas = new List<Asiento>();

        public Avion(ushort cantSillas, List<Asiento> sillas)
        {
            this.cantSillas = cantSillas;
            Sillas = sillas;
        }

        
        public ushort CantSillas { get => cantSillas;}
        internal List<Asiento> Sillas1 { get => Sillas;}

        

       

       
    }
}
