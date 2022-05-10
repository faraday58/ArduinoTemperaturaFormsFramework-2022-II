using System;

using System.Windows.Forms;

namespace ArduinoTemperaturaFormsFramework_2022_II
{
    public partial class FormContenedor : Form
    {
        public FormContenedor()
        {
            InitializeComponent();
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTemperatura formTemperatura = new FormTemperatura(this);
            //Se establece que el formulario Contenedor es padre de Formtemperatura
            formTemperatura.MdiParent = this;
            formTemperatura.Show();
        }
    }
}
