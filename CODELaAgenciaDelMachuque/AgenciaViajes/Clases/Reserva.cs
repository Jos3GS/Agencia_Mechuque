using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Clases
{
    class Reserva
    {

        private Plan plan;
        private Cliente clienteR;
        private List<Cliente> viajeros = new List<Cliente>();
        private List<Asiento> silla = new List<Asiento>();
        private bool status;
        
        
        public Reserva(Plan plan, Cliente clienteR, List<Cliente> viajeros, List<Asiento> silla, bool status)
        {
            this.plan = plan;
            this.clienteR = clienteR;
            this.viajeros = viajeros;
            this.silla = silla;
            this.status = status;
        }

        public bool Status { get => status; }
        internal Plan Plan { get => plan;}
        internal Cliente ClienteR { get => clienteR;}
        internal List<Cliente> Viajeros { get => viajeros;}
        internal List<Asiento> Silla { get => silla;}

        

        public bool PagarReserva(string nroReserva, ulong valor)
        {
            try
            {
                if (status)
                {
                    if (Plan.NroConsecutivo == nroReserva && plan.Valor == valor)
                    {
                        status = true;
                        foreach (Asiento asiento in silla)
                        {
                            asiento.StatusR = true;
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw new Exception("Hubo un error Activando la Reserva");
            }
        }

        public ulong ConsultarMonto()
        {
            ulong monto=0;
            try
            {
               
                return monto;
            }
            catch (Exception)
            {
                throw new Exception("Error calculando monto");
            }

        }


    }
}
