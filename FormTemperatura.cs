using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace ArduinoTemperaturaFormsFramework_2022_II
{
    public partial class FormTemperatura : Form
    {
        private int tiempo;
        private sbyte temperatura;
        private Random aleatoria;
        private Form formpadre;
        public FormTemperatura(Form formpadre)
        {
            InitializeComponent();
            this.formpadre = formpadre;
        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerTemperatura.Start();
            aleatoria = new Random();
        }

        private void timerTemperatura_Tick(object sender, EventArgs e)
        {
            temperatura = (sbyte)aleatoria.Next(126);
            dgvTemperatura.Rows.Add(tiempo++, temperatura);
        }

        private void pararToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerTemperatura.Stop();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = null;
            SaveFileDialog sf = new SaveFileDialog();

            sf.Filter = "Archivos de Texto | *.txt|Todos los archivos (*.*)|*.*";
            sf.DefaultExt = ".txt";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sw = new StreamWriter(sf.FileName);
                    sw.WriteLine("Tiempo,Temperatura");
                    for (int i = 0; i < dgvTemperatura.Rows.Count; i++)
                    {
                        sw.WriteLine(dgvTemperatura.Rows[i].Cells[0].Value + "," + dgvTemperatura.Rows[i].Cells[1].Value);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: " + error.Message);
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter= "Archivos de Texto | *.txt|Todos los archivos (*.*)|*.*";
            ofd.DefaultExt = ".txt";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sr = new StreamReader(ofd.FileName);
                    string linea= sr.ReadLine();
                    
                    while(linea != null)                    {
                        linea = sr.ReadLine();
                        if (linea != null)
                        {
                            string[] aux = linea.Split(',');
                            dgvTemperatura.Rows.Add(aux[0], aux[1]);
                        }
                                                
                    }

                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    sr.Close();
                }
            }





        }
    }
}
