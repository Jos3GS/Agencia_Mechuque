using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenciaViajes.Clases;

namespace AgenciaViajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            PanelReserva.Visible = false;
            PanelReserva.Enabled = false;
            pnroReserva.Visible = false;
            pnroReserva.Enabled = false;

            labNroReserva.Text = "Ingrese Nro de Reserva";
            
            dtpFechaNacimiento.MaxDate = new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day);
            dtpFNacimientoV1.MaxDate = new DateTime(DateTime.Now.Year - 1, DateTime.Now.Month, DateTime.Now.Day);
            dtpFNacimientoV2.MaxDate = new DateTime(DateTime.Now.Year - 1, DateTime.Now.Month, DateTime.Now.Day);
            dtpFNacimientoV3.MaxDate = new DateTime(DateTime.Now.Year - 1, DateTime.Now.Month, DateTime.Now.Day);
            dtpFNacimientoV4.MaxDate = new DateTime(DateTime.Now.Year - 1, DateTime.Now.Month, DateTime.Now.Day);
            dtpFechaSalida.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dtpFechaRegreso.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }

        

        public static ushort cont=1;
        private static List<Cliente> client = new List<Cliente>();
        Cliente clienteR;
        internal static bool BOOL = false;
        Plane avion;
        

        internal static List<Reserva> ListaReserva = new List<Reserva>();

        private short OPOP = 0;
        private string nroRes = "";
        private ulong valueM = 0;

        private TimeSpan DifDays;
        private string NameR;
        private Cliente.tipoid TipoID;
        private string nroID;
       
        private string tipoPlan;
       
        private string ciudadDestino;
        private string NameVi1;
        private Cliente.tipoid TipoID1;
        private string nroID1;
        
        private string NameVi2;
        private Cliente.tipoid TipoID2;
        private string nroID2;
        
        private string NameVi3;
        private Cliente.tipoid TipoID3;
        private string nroID3;
        
        private string NameVi4;
        private Cliente.tipoid TipoID4;
        private string nroID4;

        private ulong value;
        

        internal static List<Cliente> Client { get => client;}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEstadoAvio_Click(object sender, EventArgs e)
        {
            try
            {
                if (!BOOL) avion = new Plane();
                avion.btnFReserva.Enabled = false;
                avion.btnFReserva.Visible = false;
                avion.AgregarNroRes();
                avion.ShowDialog();
                
            }
            catch (Exception)
            {

            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            try
            {
                PanelReserva.Visible = true;
                PanelReserva.Enabled = true;
            }
            catch (Exception)
            {

            }
            
        }

        private void btnFCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                PanelReserva.Visible = false;
                PanelReserva.Enabled = false;
                Limpiar();


            }
            catch (Exception)
            {

            }
            
        }

        private void btnFReserva_Click(object sender, EventArgs e)
        {
            


            try
            {
                if(!string.IsNullOrEmpty(tbNameR.Text) && !string.IsNullOrWhiteSpace(tbNameR.Text))
                {
                    if (tbNameR.TextLength >= 4 && tbNameR.TextLength <=30)
                    {
                        NameR = tbNameR.Text;
                    }
                    else
                    {
                        MessageBox.Show("El nombre muy Corto o Muy Largo");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese su nombre");
                    return;

                }

                if (cbTipoID.SelectedItem != null)
                {
                    if (cbTipoID.Text.Equals("CC")) TipoID = Cliente.tipoid.CC;
                    else if (cbTipoID.Text.Equals("CE")) TipoID = Cliente.tipoid.CE;
                    else if (cbTipoID.Text.Equals("PA")) TipoID = Cliente.tipoid.PA;
                }
                else
                {
                    MessageBox.Show("Seleccione un tipo de Identificación");
                    return;
                }

                if(!string.IsNullOrEmpty(tbNroID.Text) && !string.IsNullOrWhiteSpace(tbNroID.Text))
                {
                    if(tbNroID.TextLength >=7 && tbNroID.TextLength <= 15)
                    {
                        nroID = tbNroID.Text;
                    }
                    else
                    {
                        MessageBox.Show("Numero no cumple Formato, Debe contener entre 7 y 15 Caracteres");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese su numero de identificación");
                    return;
                }

                if(cbTipoPlan.SelectedItem != null)
                {
                    tipoPlan = cbTipoPlan.Text;
                }
                else
                {
                    MessageBox.Show("Seleccione un tipo de Plan");
                    return;
                }

                if(!string.IsNullOrWhiteSpace(tbCiudadDestino.Text) && !string.IsNullOrEmpty(tbCiudadDestino.Text))
                {
                    if(tbCiudadDestino.TextLength >=4 && tbCiudadDestino.TextLength <= 15)
                    {
                        ciudadDestino = tbCiudadDestino.Text;
                    }
                    else
                    {
                        MessageBox.Show("Nombre de ciudad muy corto, o largo");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una ciudad");
                    return;
                }
                if(dtpFechaSalida.Value != null && dtpFechaRegreso.Value != null)
                {
                  
                    DifDays = dtpFechaRegreso.Value.Date - dtpFechaSalida.Value.Date;
                    int DIFdays = DifDays.Days;
                    if(DIFdays<3)
                    {
                        MessageBox.Show("La diferencia de entre la fecha de salida, y la de regreso, debe ser mayor a 3 dias");
                        return;
                    }

                }

                clienteR = new Cliente(NameR, dtpFechaNacimiento.Value, TipoID, nroID);

                if ((!string.IsNullOrEmpty(tbNameV1.Text) && !string.IsNullOrWhiteSpace(tbNameV1.Text)) && (cbTipoIDV1.SelectedItem != null) &&
                    (!string.IsNullOrWhiteSpace(tbnroIDV1.Text) && !string.IsNullOrEmpty(tbnroIDV1.Text)))
                {
                    if (tbNameV1.TextLength >= 4 && tbNameV1.TextLength <= 30)
                    {
                        NameVi1 = tbNameV1.Text;

                    }
                    else
                    {
                        MessageBox.Show("Nombre muy corto o muy largo");
                        return;
                    }
                    if (cbTipoIDV1.SelectedItem != null)
                    {
                        if (cbTipoIDV1.Text.Equals("CC")) TipoID1 = Cliente.tipoid.CC;
                        else if (cbTipoIDV1.Text.Equals("CE")) TipoID1 = Cliente.tipoid.CE;
                        else if (cbTipoIDV1.Text.Equals("PA")) TipoID1 = Cliente.tipoid.PA;
                        else if (cbTipoIDV1.Text.Equals("TI")) TipoID1 = Cliente.tipoid.TI;
                    }
                    else
                    {
                        MessageBox.Show("Selecciones un tipo de ID");
                        return;
                    }

                    if (tbnroIDV1.TextLength >= 7 && tbnroIDV1.TextLength <= 15) nroID1 = tbnroIDV1.Text;
                    else
                    {
                        MessageBox.Show("Numero de Identificación, no cumple el formato");
                        return;
                    }


                    client.Add(new Cliente(NameVi1, dtpFNacimientoV1.Value, TipoID1, nroID1));
                    cont++;

                }
                else if ((string.IsNullOrEmpty(tbNameV1.Text) || string.IsNullOrWhiteSpace(tbNameV1.Text)) && (cbTipoIDV1.SelectedItem == null) &&
                    (string.IsNullOrWhiteSpace(tbnroIDV1.Text) || string.IsNullOrEmpty(tbnroIDV1.Text))) { }
                else
                {
                    MessageBox.Show("Te han faltado datos");
                    return;
                }
                if ((!string.IsNullOrEmpty(tbNameV2.Text) && !string.IsNullOrWhiteSpace(tbNameV2.Text)) && (cbTipoIDV2.SelectedItem != null) &&
                    (!string.IsNullOrWhiteSpace(tbnroIDV2.Text) && !string.IsNullOrEmpty(tbnroIDV2.Text)))
                {
                    if (tbNameV2.TextLength >= 4 && tbNameV2.TextLength <= 30)
                    {
                        NameVi2 = tbNameV2.Text;
                        
                    }
                    else
                    {
                        MessageBox.Show("Nombre muy corto o muy largo");
                        return;
                    }

                    if (cbTipoIDV2.SelectedItem != null)
                    {
                        if (cbTipoIDV2.Text.Equals("CC")) TipoID2 = Cliente.tipoid.CC;
                        else if (cbTipoIDV2.Text.Equals("CE")) TipoID2 = Cliente.tipoid.CE;
                        else if (cbTipoIDV2.Text.Equals("PA")) TipoID2 = Cliente.tipoid.PA;
                        else if (cbTipoIDV2.Text.Equals("TI")) TipoID2 = Cliente.tipoid.TI;
                    }
                    else
                    {
                        MessageBox.Show("Selecciones un tipo de ID");
                        return;
                    }

                    if (tbnroIDV2.TextLength >= 7 && tbnroIDV2.TextLength <= 15) nroID2 = tbnroIDV2.Text;
                    else
                    {
                        MessageBox.Show("Numero de Identificación, no cumple el formato");
                        return;
                    }

                    client.Add(new Cliente(NameVi2, dtpFNacimientoV2.Value, TipoID2, nroID2));
                    cont++;

                }
                else if ((string.IsNullOrEmpty(tbNameV2.Text) || string.IsNullOrWhiteSpace(tbNameV2.Text)) && (cbTipoIDV2.SelectedItem == null) &&
                    (string.IsNullOrWhiteSpace(tbnroIDV2.Text) || string.IsNullOrEmpty(tbnroIDV2.Text))) { }
                else
                {
                    MessageBox.Show("Te han faltado datos");
                    return;
                }
                if ((!string.IsNullOrEmpty(tbNameV3.Text) && !string.IsNullOrWhiteSpace(tbNameV3.Text)) && (cbTipoIDV3.SelectedItem != null) &&
                    (!string.IsNullOrWhiteSpace(tbnroIDV3.Text) && !string.IsNullOrEmpty(tbnroIDV3.Text)))
                {
                    if (tbNameV3.TextLength >= 4 && tbNameV3.TextLength <= 30)
                    {
                        NameVi3 = tbNameV3.Text;
                        
                    }
                    else
                    {
                        MessageBox.Show("Nombre muy corto o muy largo");
                        return;
                    }
                    if (cbTipoIDV3.SelectedItem != null)
                    {
                        if (cbTipoIDV3.Text.Equals("CC")) TipoID3 = Cliente.tipoid.CC;
                        else if (cbTipoIDV3.Text.Equals("CE")) TipoID3 = Cliente.tipoid.CE;
                        else if (cbTipoIDV3.Text.Equals("PA")) TipoID3 = Cliente.tipoid.PA;
                        else if (cbTipoIDV3.Text.Equals("TI")) TipoID3 = Cliente.tipoid.TI;
                    }
                    else
                    {
                        MessageBox.Show("Selecciones un tipo de ID");
                        return;
                    }

                    if (tbnroIDV3.TextLength >= 7 && tbnroIDV3.TextLength <= 15) nroID3 = tbnroIDV3.Text;
                    else
                    {
                        MessageBox.Show("Numero de Identificación, no cumple el formato");
                        return;
                    }

                    client.Add(new Cliente(NameVi3, dtpFNacimientoV3.Value, TipoID3, nroID3));
                    cont++;
                }
                else if ((string.IsNullOrEmpty(tbNameV3.Text) || string.IsNullOrWhiteSpace(tbNameV3.Text)) && (cbTipoIDV3.SelectedItem == null) &&
                    (string.IsNullOrWhiteSpace(tbnroIDV3.Text) || string.IsNullOrEmpty(tbnroIDV3.Text))) { }
                else
                {
                    MessageBox.Show("Te han faltado datos");
                    return;
                }

                if ((!string.IsNullOrEmpty(tbNameV4.Text) && !string.IsNullOrWhiteSpace(tbNameV4.Text)) && (cbTipoIDV4.SelectedItem != null) &&
                    (!string.IsNullOrWhiteSpace(tbnroIDV4.Text) && !string.IsNullOrEmpty(tbnroIDV4.Text)))
                {
                    if (tbNameV4.TextLength >= 4 && tbNameV4.TextLength <= 30)
                    {
                        NameVi4 = tbNameV4.Text;
                        
                    }
                    else
                    {
                        MessageBox.Show("Nombre muy corto o muy largo");
                        return;
                    }
                    if (cbTipoIDV4.SelectedItem != null)
                    {
                        if (cbTipoIDV4.Text.Equals("CC")) TipoID4 = Cliente.tipoid.CC;
                        else if (cbTipoIDV4.Text.Equals("CE")) TipoID4 = Cliente.tipoid.CE;
                        else if (cbTipoIDV4.Text.Equals("PA")) TipoID4 = Cliente.tipoid.PA;
                        else if (cbTipoIDV4.Text.Equals("TI")) TipoID4 = Cliente.tipoid.TI;
                    }
                    else
                    {
                        MessageBox.Show("Selecciones un tipo de ID");
                        return;
                    }

                    if (tbnroIDV4.TextLength >= 7 && tbnroIDV4.TextLength <= 15) nroID4 = tbnroIDV4.Text;
                    else
                    {
                        MessageBox.Show("Numero de Identificación, no cumple el formato");
                        return;
                    }

                    client.Add(new Cliente(NameVi4, dtpFNacimientoV4.Value, TipoID4, nroID4));
                    cont++;
                }
                else if ((string.IsNullOrEmpty(tbNameV4.Text) || string.IsNullOrWhiteSpace(tbNameV4.Text)) && (cbTipoIDV4.SelectedItem == null) &&
                    (string.IsNullOrWhiteSpace(tbnroIDV4.Text) || string.IsNullOrEmpty(tbnroIDV4.Text))) { }
                else
                {
                    MessageBox.Show("Te han faltado datos");
                    return;
                }


                if (!BOOL) avion = new Plane();
                avion.btnFReserva.Enabled = true;
                avion.btnFReserva.Visible = true;


                
                avion.ShowDialog();
                GenerarReserva();
                ImprimirReserva();
                avion.AgregarNroRes();
                Limpiar();

            }
            catch (Exception)
            {

            }
        }

        
        private void Limpiar()
        {
            tbNameR.Clear();
            tbNameV1.Clear();
            tbNameV2.Clear();
            tbNameV3.Clear();
            tbNameV4.Clear();
            tbNroID.Clear();
            dtpFechaNacimiento.Value = dtpFechaNacimiento.MaxDate;
            dtpFechaRegreso.Value = DateTime.Now;
            dtpFechaSalida.Value = DateTime.Now;
            dtpFNacimientoV1.Value = dtpFNacimientoV1.MaxDate;
            dtpFNacimientoV2.Value = dtpFNacimientoV2.MaxDate;
            dtpFNacimientoV3.Value = dtpFNacimientoV3.MaxDate;
            dtpFNacimientoV4.Value = dtpFNacimientoV4.MaxDate;
            cbTipoID.SelectedItem = null;
            cbTipoIDV1.SelectedItem = null;
            cbTipoIDV2.SelectedItem = null;
            cbTipoIDV3.SelectedItem = null;
            cbTipoIDV4.SelectedItem = null;
            cbTipoPlan.SelectedItem = null;
            tbCiudadDestino.Clear();
            tbnroIDV1.Clear();
            tbnroIDV2.Clear();
            tbnroIDV3.Clear();
            tbnroIDV4.Clear();
            PanelReserva.Visible = false;
        }
        internal  void GenerarReserva()
        {
            
            try
            {
               
                if(tipoPlan.Equals("Todo Incluido"))
                {
                    value = 0;
                    try
                    {
                        foreach (Asiento c in avion.puestos)
                        {
                            value += 500000;
                        }

                        TodoIncluido ti = new TodoIncluido(Plan.lista_Actividades.Terrestres, tbCiudadDestino.Text, dtpFechaSalida.Value, dtpFechaRegreso.Value, true, true, true, true, value);
                        ListaReserva.Add(new Reserva(ti, clienteR, client, avion.puestos, false));
                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hubo un error");
                        return;
                    }
                }else if(tipoPlan.Equals("Medio Incluido"))
                {
                    value = 0;
                    MedioIncluido mi= null;
                    try
                    {
                        foreach (Asiento c in avion.puestos)
                        {
                            value += 300000;
                        }
                        MessageBoxPERop mess = new MessageBoxPERop();
                        mess.ShowDialog();

                        if (mess.OP.Equals("Almuerzo"))
                        {
                            mi = new MedioIncluido(Plan.lista_Actividades.Acuaticas, tbCiudadDestino.Text, dtpFechaSalida.Value, dtpFechaRegreso.Value, true, true, false, false, value);
                        }
                        else if (mess.OP.Equals("Cena"))
                        {
                            mi = new MedioIncluido(Plan.lista_Actividades.Terrestres, tbCiudadDestino.Text, dtpFechaSalida.Value, dtpFechaRegreso.Value, true, false, true, false, value);
                        }

                        ListaReserva.Add(new Reserva(mi, clienteR, client, avion.puestos, false));
                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hubo un error");
                        return;
                    }
                }else if (tipoPlan.Equals("Básico"))
                {
                    value = 0;
                    try
                    {
                        foreach (Asiento c in avion.puestos)
                        {
                            value += 200000;
                        }

                        Basico ba = new Basico(.1f, tbCiudadDestino.Text, dtpFechaSalida.Value, dtpFechaRegreso.Value, false, false, false, false, value);

                        ListaReserva.Add(new Reserva(ba, clienteR, client, avion.puestos, false));
                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hubo un error");
                        return;
                    }
                }

                
            }
            catch (Exception)
            {
                throw new Exception("No se pudo generar la Reserva");
            }
        }

        private void cbTipoIDV4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultarReservas_Click(object sender, EventArgs e)
        {
            string asientooo = "";
            try
            {
                
                foreach (Reserva re in ListaReserva)
                {

                    foreach (Asiento ASIE in re.Silla)
                    {
                        asientooo += "\n" + ASIE.NroSilla;


                    }
                    MessageBox.Show("NroReserva " + re.Plan.NroConsecutivo + " Cliente " + re.ClienteR.Nombre + " Valor " + re.Plan.Valor+"\nSillas"+asientooo);
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
                return;
            }


        }

        private void ImprimirReserva()
        {
            string sillas="";
            string viajeros = "";
            try
            {
                foreach (Reserva re in ListaReserva)
                {
                    if (re.ClienteR.NroID == nroID)
                    {
                        foreach (Asiento ASIE in re.Silla)
                        {
                            sillas += "\n" + ASIE.NroSilla;
                        }
                        foreach (Cliente cl in re.Viajeros)
                        {
                            viajeros += "\n" + cl.Nombre;
                        }

                        MessageBox.Show("AGENCIA DEL MECHUQUE\n\nNro Reserva:  "+re.Plan.NroConsecutivo+"\nTitular Reserva: "+re.ClienteR.Nombre.ToUpper()+"" +
                            "\nID: "+re.ClienteR.NroID+"\nPlan: "+tipoPlan+"\nSillas Seleccionadas\n"+sillas+"\n\nPrecio: "+value+"" +
                            "\n\nFecha Salida:  "+dtpFechaSalida.Value+"\nFecha Regreso:  "+dtpFechaRegreso.Value);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
                return;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            try
            {
                btnDoIt.Text = "Consultar Monto";
                pnroReserva.Visible = true;
                pnroReserva.Enabled = true;
                OPOP = 1;
                MessageBox.Show("Recuerde el Formato del Numero del Consecutivo\n\nTI-XXXXXXAB  MI-XXXXXXCD   BA-XXXXXXEF");
                
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err);
            }
        }



        

        private void btnDoIt_Click(object sender, EventArgs e)
        {
            
            try
            {
                switch (OPOP)
                {
                    case 1:
                        if (!string.IsNullOrEmpty(tbNROCONS.Text) && !string.IsNullOrWhiteSpace(tbNROCONS.Text))
                        {
                            foreach (Reserva res in ListaReserva)
                            {
                                if (res.Plan.NroConsecutivo == tbNROCONS.Text)
                                {
                                    valueM = res.ConsultarMonto();
                                    MessageBox.Show("El monto a pagar de la reserva numero\n" + res.Plan.NroConsecutivo + "" +
                                        "\n\nEs de:  $" +  valueM + " Pesos colombianos");
                                    OPOP = 0;
                                    pnroReserva.Visible = false;
                                    pnroReserva.Enabled = false;
                                    tbNROCONS.Clear();
                                  
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe Poner el nro De Reserva");
                        }
                        break;
                    case 2:
                        if(!string.IsNullOrEmpty(tbNROCONS.Text) && !string.IsNullOrWhiteSpace(tbNROCONS.Text))
                        {
                            foreach(Reserva res in ListaReserva)
                            {
                                if(res.Plan.NroConsecutivo == tbNROCONS.Text)
                                {
                                    OPOP = 4;
                                    nroRes = res.Plan.NroConsecutivo;
                                    labNroReserva.Text = "Ingrese Monto a Pagar";
                                    btnDoIt.Text = "Pagar Reserva";
                                    tbNROCONS.Clear();
                                    MessageBox.Show("El Monto a Pagar de la Reserva  " + res.Plan.NroConsecutivo + " Es " + res.Plan.Valor);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe Poner el nro De Reserva");
                        }
                        break;
                    case 3:
                        if(!string.IsNullOrEmpty(tbNROCONS.Text) && !string.IsNullOrWhiteSpace(tbNROCONS.Text))
                        {
                            foreach(Reserva res in ListaReserva)
                            {
                                if(res.Plan.NroConsecutivo == tbNROCONS.Text)
                                {
                                    if (avion.Cancelar(res.Silla))
                                    {
                                        ListaReserva.Remove(res);
                                        MessageBox.Show("Reserva Cancelada Exitosamente");
                                        pnroReserva.Visible = false;
                                        pnroReserva.Enabled = false;
                                        tbNROCONS.Clear();
                                        OPOP = 0;
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se Pudo Cancelar");
                                        return;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar Nro de Reserva");
                            return;
                        }
                        break;
                    case 4:
                        
                        
                        if(!string.IsNullOrEmpty(tbNROCONS.Text) && !string.IsNullOrWhiteSpace(tbNROCONS.Text))
                        {
                            bool b3 = false;
                            foreach(Reserva res in ListaReserva)
                            {
                                if(res.Plan.NroConsecutivo == nroRes)
                                {
                                   
                                    try
                                    {
                                        valueM = ulong.Parse(tbNROCONS.Text);
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("Debe Ingresar valores Numericos");
                                        return;
                                    }
                                    b3 = res.PagarReserva(nroRes, valueM);

                                    if (b3)
                                    {
                                        MessageBox.Show("Reserva  " + nroRes + "  Pagada");
                                        OPOP = 0;
                                        labNroReserva.Text = "Ingrese Nro de Reserva";
                                        tbNROCONS.Clear();
                                        pnroReserva.Visible = false;
                                        pnroReserva.Enabled = false;
                                    }
                                    else
                                    {
                                        MessageBox.Show("la reserva no pudo ser Pagada");
                                        tbNROCONS.Clear();
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe Poner el nro De Reserva");
                        }
                        break;
                    default:
                        OPOP = 0;
                        break;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo Error");
                return;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            { 

                MessageBox.Show("Recuerde el Formato del Numero del Consecutivo\n\nTI-XXXXXXAB  MI-XXXXXXCD   BA-XXXXXXEF");
                btnDoIt.Text = "Pagar Reserva";
                pnroReserva.Visible = true;
                pnroReserva.Enabled = true;
                OPOP = 2;


            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Recuerde el Formato del Numero del Consecutivo\n\nTI-XXXXXXAB  MI-XXXXXXCD   BA-XXXXXXEF");
                btnDoIt.Text = "Cancelar Reserva";
                pnroReserva.Visible = true;
                pnroReserva.Enabled = true;
                OPOP = 3;


            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err);
            }
        }
    }
}
