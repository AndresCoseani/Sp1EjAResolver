using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoseaniAndresSp1EjAResolver
{
    public partial class Login : Form
    {  //declaracion de variables
        string VartxtUsuario;
        string VartxtContraseña;
        string VarcboModulo;
        int Varintentos=0; 







        public Login()
        {
            InitializeComponent();
        }

        private void cboMódulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Contrasenia = txtContraseña.Text;
            string Modulo = cboMódulo.SelectedItem.ToString();
            





            if ((Usuario == "Adm" && Contrasenia == "@1a") && (Modulo == "ADM" || Modulo == "COM" || Modulo == "VTA") ||
                (Usuario == "Jhon" && Contrasenia == "*2b") && (Modulo == "SIST") ||
                (Usuario == "Ceci" && Contrasenia == "*@3c") && (Modulo == "ADM" || Modulo == "VTA") ||
                (Usuario == "God" && Contrasenia == "*@#4d"))




            {
                this.Hide();
                Bienvenido frm = new Bienvenido();
                frm.Show();
            }

            else
            {
               
                MessageBox.Show("Usuario y/o Contraseña Incorrecta");

                Varintentos++;
                if (Varintentos == 3)
                { 
                    this.Close();   
                }
            }



        }

    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           




        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
