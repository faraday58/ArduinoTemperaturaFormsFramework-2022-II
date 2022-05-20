using System;
using System.IO.Ports;
using System.Drawing;
using System.Windows.Forms;

namespace ArduinoTemperaturaFormsFramework_2022_II
{
    public partial class FormLED : Form
    {
        SerialPort serialPort;
        bool prendeApaga = true;
        public FormLED(SerialPort padre)
        {
            InitializeComponent();
            this.serialPort= padre;
        }

        private void ptbLED_Click(object sender, EventArgs e)
        {
            if( prendeApaga)
            {
                ptbLED.BackColor = Color.Yellow;
                prendeApaga = false;
                serialPort.Write("A");
            }
            else
            {
                ptbLED.BackColor = Color.Blue;
                prendeApaga = true;
                serialPort.Write("B");
            }
            
        }
    }
}
