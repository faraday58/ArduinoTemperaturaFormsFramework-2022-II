using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace ArduinoTemperaturaFormsFramework_2022_II
{
    public partial class FormContenedor : Form
    {
        private SerialPort serialPort;
        public FormContenedor()
        {
            InitializeComponent();
            serialPort = new SerialPort(); 
            Selecciona();
        }

        private void Selecciona()
        {
            string [] v= SerialPort.GetPortNames();
            Array.Sort(v);
            toolStripCmbPuertos.Items.AddRange(v);
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTemperatura formTemperatura = new FormTemperatura(this);
            //Se establece que el formulario Contenedor es padre de Formtemperatura
            formTemperatura.MdiParent = this;
            formTemperatura.Show();
        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" <a href=\"https://www.flaticon.es/iconos-gratis/temperatura\" title=\"temperatura iconos\">Temperatura iconos creados por fps web agency - Flaticon</a>  ");
        }

        private void verificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.BaudRate = 9600;
                serialPort.PortName = toolStripCmbPuertos.SelectedItem.ToString();

            }
            catch(Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort.Open();
        }

        private void pruebaLEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLED formLED = new FormLED(this.serialPort);
            formLED.MdiParent = this;
            formLED.Show();
        }
    }
}
