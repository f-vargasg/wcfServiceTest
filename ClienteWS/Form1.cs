using ClienteWS.WSPersonas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var identificacion = txtIdentificacion.Text;
            try
            {
                using (WSPersonasClient client = new WSPersonas.WSPersonasClient())
                {
                    var persona = client.ObtenerPersona(identificacion);
                    var nombre = persona.Nombre;

                    Console.WriteLine(persona.Nombre);
                    Console.WriteLine(persona.Edad);
                    Console.WriteLine(persona.Error);
                    MessageBox.Show(client.ObtDatosPersonaStr(persona));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
