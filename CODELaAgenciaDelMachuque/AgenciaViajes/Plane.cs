using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenciaViajes.Clases;

namespace AgenciaViajes
{
    public partial class Plane : Form
    {
        

        public Plane()
        {
            InitializeComponent();
            Generar();
           
            VolverMatriz();
            actualizar();
            Guardar();
            
            Form1.BOOL = true;
            

            
        
        }

        
        private int cbChecked=0;
        internal  List<Asiento> puestos;
        private List<Asiento> PUESTOS1 = new List<Asiento>();
        private List<string> sillas = new List<string>();
        internal string[,] asientos = new string[10, 3];
        private string[,] asientos1 = new string[10, 3];
        




        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReservar_Click(object sender, EventArgs e) //btnCancelar
        {
            this.Close();
        }

        private void btnFReserva_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (Comparar())
                {
                    VolverMatriz();
                    
                    Guardar();
                    Convertir();
                    actualizar();
                   
                    Form1.Client.Clear();
                    Close();
                };

            }catch(Exception err)
            {
                MessageBox.Show(""+err);
            }
        }

        private void VolverMatriz()
        {
            string A1, A2, A3, A4, A5, A6, A7, A8, A9, A10;
            string B1, B2, B3, B4, B5, B6, B7, B8, B9, B10;
            string C1, C2, C3, C4, C5, C6, C7, C8, C9, C10;

            try
            {
                if (!cbA1.Enabled) A1 = "True";
                else A1 = "False";
                if (!cbA2.Enabled) A2 = "True";
                else A2 = "False";
                if (!cbA3.Enabled) A3 = "True";
                else A3 = "False";
                if (!cbA4.Enabled) A4 = "True";
                else A4 = "False";
                if (!cbA5.Enabled) A5 = "True";
                else A5 = "False";
                if (!cbA6.Enabled) A6 = "True";
                else A6 = "False";
                if (!cbA7.Enabled) A7 = "True";
                else A7 = "False";
                if (!cbA8.Enabled) A8 = "True";
                else A8 = "False";
                if (!cbA9.Enabled) A9 = "True";
                else A9 = "False";
                if (!cbA10.Enabled) A10 = "True";
                else A10 = "False";

                if (!cbB1.Enabled) B1 = "True";
                else B1 = "False";
                if (!cbB2.Enabled) B2 = "True";
                else B2 = "False";
                if (!cbB3.Enabled) B3 = "True";
                else B3 = "False";
                if (!cbB4.Enabled) B4 = "True";
                else B4 = "False";
                if (!cbB5.Enabled) B5 = "True";
                else B5 = "False";
                if (!cbB6.Enabled) B6 = "True";
                else B6 = "False";
                if (!cbB7.Enabled) B7 = "True";
                else B7 = "False";
                if (!cbB8.Enabled) B8 = "True";
                else B8 = "False";
                if (!cbB9.Enabled) B9 = "True";
                else B9 = "False";
                if (!cbB10.Enabled) B10 = "True";
                else B10 = "False";

                if (!cbC1.Enabled) C1 = "True";
                else C1 = "False";
                if (!cbC2.Enabled) C2 = "True";
                else C2 = "False";
                if (!cbC3.Enabled) C3 = "True";
                else C3 = "False";
                if (!cbC4.Enabled) C4 = "True";
                else C4 = "False";
                if (!cbC5.Enabled) C5 = "True";
                else C5 = "False";
                if (!cbC6.Enabled) C6 = "True";
                else C6 = "False";
                if (!cbC7.Enabled) C7 = "True";
                else C7 = "False";
                if (!cbC8.Enabled) C8 = "True";
                else C8 = "False";
                if (!cbC9.Enabled) C9 = "True";
                else C9 = "False";
                if (!cbC10.Enabled) C10 = "True";
                else C10 = "False";

                asientos1[0, 0] = cbA1.Text.Split('@')[0] + "@" + A1 + "\n@False";
                asientos1[1, 0] = cbA2.Text.Split('@')[0] + "@" + A2 + "\n@False";
                asientos1[2, 0] = cbA3.Text.Split('@')[0] + "@" + A3 + "\n@False";
                asientos1[3, 0] = cbA4.Text.Split('@')[0] + "@" + A4 + "\n@False";
                asientos1[4, 0] = cbA5.Text.Split('@')[0] + "@" + A5 + "\n@False";
                asientos1[5, 0] = cbA6.Text.Split('@')[0] + "@" + A6 + "\n@False";
                asientos1[6, 0] = cbA7.Text.Split('@')[0] + "@" + A7 + "\n@False";
                asientos1[7, 0] = cbA8.Text.Split('@')[0] + "@" + A8 + "\n@False";
                asientos1[8, 0] = cbA9.Text.Split('@')[0] + "@" + A9 + "\n@False";
                asientos1[9, 0] = cbA10.Text.Split('@')[0] + "@" + A10 + "\n@False";

                asientos1[0, 1] = cbB1.Text.Split('@')[0] + "@" + B1 + "\n@False";
                asientos1[1, 1] = cbB2.Text.Split('@')[0] + "@" + B2 + "\n@False";
                asientos1[2, 1] = cbB3.Text.Split('@')[0] + "@" + B3 + "\n@False";
                asientos1[3, 1] = cbB4.Text.Split('@')[0] + "@" + B4 + "\n@False";
                asientos1[4, 1] = cbB5.Text.Split('@')[0] + "@" + B5 + "\n@False";
                asientos1[5, 1] = cbB6.Text.Split('@')[0] + "@" + B6 + "\n@False";
                asientos1[6, 1] = cbB7.Text.Split('@')[0] + "@" + B7 + "\n@False";
                asientos1[7, 1] = cbB8.Text.Split('@')[0] + "@" + B8 + "\n@False";
                asientos1[8, 1] = cbB9.Text.Split('@')[0] + "@" + B9 + "\n@False";
                asientos1[9, 1] = cbB10.Text.Split('@')[0] + "@" + B10 + "\n@False";

                asientos1[0, 2] = cbC1.Text.Split('@')[0] + "@" + C1 + "\n@False";
                asientos1[1, 2] = cbC2.Text.Split('@')[0] + "@" + C2 + "\n@False";
                asientos1[2, 2] = cbC3.Text.Split('@')[0] + "@" + C3 + "\n@False";
                asientos1[3, 2] = cbC4.Text.Split('@')[0] + "@" + C4 + "\n@False";
                asientos1[4, 2] = cbC5.Text.Split('@')[0] + "@" + C5 + "\n@False";
                asientos1[5, 2] = cbC6.Text.Split('@')[0] + "@" + C6 + "\n@False";
                asientos1[6, 2] = cbC7.Text.Split('@')[0] + "@" + C7 + "\n@False";
                asientos1[7, 2] = cbC8.Text.Split('@')[0] + "@" + C8 + "\n@False";
                asientos1[8, 2] = cbC9.Text.Split('@')[0] + "@" + C9 + "\n@False";
                asientos1[9, 2] = cbC10.Text.Split('@')[0] + "@" + C10 + "\n@False";

               

            }
            catch(Exception)
            {
                MessageBox.Show("Hubo un error Convirtiendo a matriz");
            }
        }

        
        
        private void Guardar()
        {
            for(short i=0; i<10; i++)
            {
                for(short j=0; j<3; j++)
                {
                    asientos[i, j] = asientos1[i, j];

                }
            }
            foreach (Control c in Controls)
            {
                if (c is CheckBox && (c as CheckBox).Checked)
                {
                    if ((c as CheckBox).Checked && (c as CheckBox).Enabled)
                    {
                        (c as CheckBox).Enabled = false;
                        (c as CheckBox).Checked = false;
                    }
                    else if(!(c as CheckBox).Checked && !(c as CheckBox).Enabled)
                    {
                        (c as CheckBox).Enabled = false;
                        (c as CheckBox).Checked = false;
                    }
                    else (c as CheckBox).Enabled = true;
                }
            }

        }

        private void actualizar()
        {
            try
            {

                cbA1.Text = asientos[0, 0];
                cbA2.Text = asientos[1, 0];
                cbA3.Text = asientos[2, 0];
                cbA4.Text = asientos[3, 0];
                cbA5.Text = asientos[4, 0];
                cbA6.Text = asientos[5, 0];
                cbA7.Text = asientos[6, 0];
                cbA8.Text = asientos[7, 0];
                cbA9.Text = asientos[8, 0];
                cbA10.Text = asientos[9, 0];

                cbB1.Text = asientos[0, 1];
                cbB2.Text = asientos[1, 1];
                cbB3.Text = asientos[2, 1];
                cbB4.Text = asientos[3, 1];
                cbB5.Text = asientos[4, 1];
                cbB6.Text = asientos[5, 1];
                cbB7.Text = asientos[6, 1];
                cbB8.Text = asientos[7, 1];
                cbB9.Text = asientos[8, 1];
                cbB10.Text = asientos[9, 1];

                cbC1.Text = asientos[0, 2];
                cbC2.Text = asientos[1, 2];
                cbC3.Text = asientos[2, 2];
                cbC4.Text = asientos[3, 2];
                cbC5.Text = asientos[4, 2];
                cbC6.Text = asientos[5, 2];
                cbC7.Text = asientos[6, 2];
                cbC8.Text = asientos[7, 2];
                cbC9.Text = asientos[8, 2];
                cbC10.Text = asientos[9, 2];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error en Actualizar");
            }
        }

        private bool Comparar()
        {

            string[] splited = new string[2];

            short Cont1 = 1;

            
            short checkBoxes = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    if (c is CheckBox && (c as CheckBox).Checked)
                    {
                        checkBoxes++;
                        sillas.Add(c.Text);
                    }
                }
                foreach (Cliente c in Form1.Client)
                {
                    Cont1++;
                }
                


                if (checkBoxes <= 5 && Cont1 == checkBoxes)
                {
                    cbChecked += checkBoxes;
                    return true;
                }
                else
                {
                    sillas.Clear();
                    MessageBox.Show("Los puestos seeccionados fueron diferentes");
                    return false;
                }



            }
            catch (Exception err)
            {
                throw new Exception("" + err);
            }


        }

        private void Convertir()
        {
            bool BOOL;
            PUESTOS1.Add(new Asiento("D1", false));
            try
            {
                puestos = new List<Asiento>();
                foreach(string elem in sillas)
                {
                    if (elem.Split('@')[2].Equals("True")) BOOL = true;
                    else BOOL = false;

                   
                        
                     puestos.Add(new Asiento(elem.Split('@')[0], BOOL));
                        
                    

                    

                }

                sillas.Clear();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error en Convertir " + err);
                return;
            }
        }

        private void Generar()
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    asientos[i, 0] = "A" + (i + 1) + "\n@False\n@False";
                    
                }
                for (int i = 0; i < 10; i++)
                {
                    asientos[i, 1] = "B" + (i + 1) + "\n@False\n@False";
                    
                }
                for (int i = 0; i < 10; i++)
                {
                    asientos[i, 2] = "C" + (i + 1) + "\n@False\n@False";
                    
                }
                GenerarLAB();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
                return;
            }

        }

        private void GenerarLAB()
        {
            try
            {
                labA1.Text = "A1\nL";
                labA2.Text = "A2\nL";
                labA3.Text = "A3\nL";
                labA4.Text = "A4\nL";
                labA5.Text = "A5\nL";
                labA6.Text = "A6\nL";
                labA7.Text = "A7\nL";
                labA8.Text = "A8\nL";
                labA9.Text = "A9\nL";
                labA10.Text = "A10\nL";

                labB1.Text = "B1\nL";
                labB2.Text = "B2\nL";
                labB3.Text = "B3\nL";
                labB4.Text = "B4\nL";
                labB5.Text = "B5\nL";
                labB6.Text = "B6\nL";
                labB7.Text = "B7\nL";
                labB8.Text = "B8\nL";
                labB9.Text = "B9\nL";
                labB10.Text = "B10\nL";

                labC1.Text = "C1\nL";
                labC2.Text = "C2\nL";
                labC3.Text = "C3\nL";
                labC4.Text = "C4\nL";
                labC5.Text = "C5\nL";
                labC6.Text = "C6\nL";
                labC7.Text = "C7\nL";
                labC8.Text = "C8\nL";
                labC9.Text = "C9\nL";
                labC10.Text = "C10\nL";
            }
            catch (Exception)
            {
                throw new Exception("Error");
            }
        }

        internal bool Cancelar(List<Asiento> sillasBor)
        {
            try
            {
                foreach(Asiento asiento in sillasBor)
                {
                    if (asiento.NroSilla == "A1\n") cbA1.Enabled = true;
                    if (asiento.NroSilla == "A2\n") cbA2.Enabled = true;
                    if (asiento.NroSilla == "A3\n") cbA3.Enabled = true;
                    if (asiento.NroSilla == "A4\n") cbA4.Enabled = true;
                    if (asiento.NroSilla == "A5\n") cbA5.Enabled = true;
                    if (asiento.NroSilla == "A6\n") cbA6.Enabled = true;
                    if (asiento.NroSilla == "A7\n") cbA7.Enabled = true;
                    if (asiento.NroSilla == "A8\n") cbA8.Enabled = true;
                    if (asiento.NroSilla == "A9\n") cbA9.Enabled = true;
                    if (asiento.NroSilla == "A10\n") cbA10.Enabled = true;

                    if (asiento.NroSilla == "B1\n") cbB1.Enabled = true;
                    if (asiento.NroSilla == "B2\n") cbB2.Enabled = true;
                    if (asiento.NroSilla == "B3\n") cbB3.Enabled = true;
                    if (asiento.NroSilla == "B4\n") cbB4.Enabled = true;
                    if (asiento.NroSilla == "B5\n") cbB5.Enabled = true;
                    if (asiento.NroSilla == "B6\n") cbB6.Enabled = true;
                    if (asiento.NroSilla == "B7\n") cbB7.Enabled = true;
                    if (asiento.NroSilla == "B8\n") cbB8.Enabled = true;
                    if (asiento.NroSilla == "B9\n") cbB9.Enabled = true;
                    if (asiento.NroSilla == "B10\n") cbB10.Enabled = true;

                    if (asiento.NroSilla == "C1\n") cbC1.Enabled = true;
                    if (asiento.NroSilla == "C2\n") cbC2.Enabled = true;
                    if (asiento.NroSilla == "C3\n") cbC3.Enabled = true;
                    if (asiento.NroSilla == "C4\n") cbC4.Enabled = true;
                    if (asiento.NroSilla == "C5\n") cbC5.Enabled = true;
                    if (asiento.NroSilla == "C6\n") cbC6.Enabled = true;
                    if (asiento.NroSilla == "C7\n") cbC7.Enabled = true;
                    if (asiento.NroSilla == "C8\n") cbC8.Enabled = true;
                    if (asiento.NroSilla == "C9\n") cbC9.Enabled = true;
                    if (asiento.NroSilla == "C10\n") cbC10.Enabled = true;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal void AgregarNroRes()
        {
            try
            {

                labA1.Text = "A1\nL";
                labA2.Text = "A2\nL";
                labA3.Text = "A3\nL";
                labA4.Text = "A4\nL";
                labA5.Text = "A5\nL";
                labA6.Text = "A6\nL";
                labA7.Text = "A7\nL";
                labA8.Text = "A8\nL";
                labA9.Text = "A9\nL";
                labA10.Text = "A10\nL";

                labB1.Text = "B1\nL";
                labB2.Text = "B2\nL";
                labB3.Text = "B3\nL";
                labB4.Text = "B4\nL";
                labB5.Text = "B5\nL";
                labB6.Text = "B6\nL";
                labB7.Text = "B7\nL";
                labB8.Text = "B8\nL";
                labB9.Text = "B9\nL";
                labB10.Text = "B10\nL";

                labC1.Text = "C1\nL";
                labC2.Text = "C2\nL";
                labC3.Text = "C3\nL";
                labC4.Text = "C4\nL";
                labC5.Text = "C5\nL";
                labC6.Text = "C6\nL";
                labC7.Text = "C7\nL";
                labC8.Text = "C8\nL";
                labC9.Text = "C9\nL";
                labC10.Text = "C10\nL";

                foreach (Reserva asiento in Form1.ListaReserva)
                {
                    foreach (Asiento silla in asiento.Silla)
                    {
                        if(silla.NroSilla == "A1\n" && silla.StatusR == true) labA1.Text = "A1\n"+asiento.Plan.NroConsecutivo+"\nPago";
                        else if(silla.NroSilla == "A1\n" && silla.StatusR == false) labA1.Text = "A1\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "A2\n" && silla.StatusR == true) labA2.Text = "A2\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "A2\n" && silla.StatusR == false) labA2.Text = "A2\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "A3\n" && silla.StatusR == true) labA3.Text = "A3\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "A3\n" && silla.StatusR == false) labA3.Text = "A3\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "A4\n" && silla.StatusR == true) labA4.Text = "A4\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "A4\n" && silla.StatusR == false) labA4.Text = "A4\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "A5\n" && silla.StatusR == true) labA5.Text = "A5\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "A5\n" && silla.StatusR == false) labA5.Text = "A5\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "A6\n" && silla.StatusR == true) labA6.Text = "A6\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "A6\n" && silla.StatusR == false) labA6.Text = "A6\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "A7\n" && silla.StatusR == true) labA7.Text = "A7\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "A7\n" && silla.StatusR == false) labA7.Text = "A7\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "A8\n" && silla.StatusR == true) labA8.Text = "A8\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "A8\n" && silla.StatusR == false) labA8.Text = "A8\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "A9\n" && silla.StatusR == true) labA9.Text = "A9\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "A9\n" && silla.StatusR == false) labA9.Text = "A9\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "A10\n" && silla.StatusR == true) labA10.Text = "A10\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "A10\n" && silla.StatusR == false) labA10.Text = "A10\n" + asiento.Plan.NroConsecutivo;

                        if (silla.NroSilla == "B1\n" && silla.StatusR == true) labB1.Text = "B1\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "B1\n" && silla.StatusR == false) labB1.Text = "B1\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "B2\n" && silla.StatusR == true) labB2.Text = "B2\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "B2\n" && silla.StatusR == false) labB2.Text = "B2\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "B3\n" && silla.StatusR == true) labB3.Text = "B3\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "B3\n" && silla.StatusR == false) labB3.Text = "B3\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "B4\n" && silla.StatusR == true) labB4.Text = "B4\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "B4\n" && silla.StatusR == false) labB4.Text = "B4\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "B5\n" && silla.StatusR == true) labB5.Text = "B5\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "B5\n" && silla.StatusR == false) labB5.Text = "B5\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "B6\n" && silla.StatusR == true) labB6.Text = "B6\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "B6\n" && silla.StatusR == false) labB6.Text = "B6\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "B7\n" && silla.StatusR == true) labB7.Text = "B7\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "B7\n" && silla.StatusR == false) labB7.Text = "B7\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "B8\n" && silla.StatusR == true) labB8.Text = "B8\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "B8\n" && silla.StatusR == false) labB8.Text = "B8\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "B9\n" && silla.StatusR == true) labB9.Text = "B9\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "B9\n" && silla.StatusR == false) labB9.Text = "B9\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "B10\n" && silla.StatusR == true) labB10.Text = "B10\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "B10\n" && silla.StatusR == false) labB10.Text = "B10\n" + asiento.Plan.NroConsecutivo;

                        if (silla.NroSilla == "C1\n" && silla.StatusR == true) labC1.Text = "C1\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "C1\n" && silla.StatusR == false) labC1.Text = "C1\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "C2\n" && silla.StatusR == true) labC2.Text = "C2\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "C2\n" && silla.StatusR == false) labC2.Text = "C2\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "C3\n" && silla.StatusR == true) labC3.Text = "C3\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "C3\n" && silla.StatusR == false) labC3.Text = "C3\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "C4\n" && silla.StatusR == true) labC4.Text = "C4\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "C4\n" && silla.StatusR == false) labC4.Text = "C4\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "C5\n" && silla.StatusR == true) labC5.Text = "C5\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "C5\n" && silla.StatusR == false) labC5.Text = "C5\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "C6\n" && silla.StatusR == true) labC6.Text = "C6\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "C6\n" && silla.StatusR == false) labC6.Text = "C6\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "C7\n" && silla.StatusR == true) labC7.Text = "C7\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "C7\n" && silla.StatusR == false) labC7.Text = "C7\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "C8\n" && silla.StatusR == true) labC8.Text = "C8\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "C8\n" && silla.StatusR == false) labC8.Text = "C8\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "C9\n" && silla.StatusR == true) labC9.Text = "C9\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "C9\n" && silla.StatusR == false) labC9.Text = "C9\n" + asiento.Plan.NroConsecutivo;
                        if (silla.NroSilla == "C10\n" && silla.StatusR == true) labC10.Text = "C10\n" + asiento.Plan.NroConsecutivo + "\nPago";
                        else if (silla.NroSilla == "C10\n" && silla.StatusR == false) labC10.Text = "C10\n" + asiento.Plan.NroConsecutivo;

                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Error en AgregarNroRes");
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
