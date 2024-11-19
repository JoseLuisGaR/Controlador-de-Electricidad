using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador_de_Electricidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int Fallo = random.Next(3);
            if (Fallo == 0)
            {
                if (checkBox4.Checked)
                {
                    Luz1.BackColor = Color.Red;
                    Luz11.BackColor = Color.Red;
                }
                else
                {
                    Luz1.BackColor = Color.Gray;
                    Luz11.BackColor = Color.Gray;
                }

            }
            else if (Fallo > 0)
            {

                if (checkBox4.Checked)
                {
                    Luz1.BackColor = Color.Green;
                    Luz11.BackColor = Color.Green;
                }
                else
                {
                    Luz1.BackColor = Color.Gray;
                    Luz11.BackColor = Color.Gray;
                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int Fallo = random.Next(3);
            if (Fallo == 0)
            {
                if (checkBox6.Checked)
                {
                    Luz5.BackColor = Color.Red;
                    Luz13.BackColor = Color.Red;
                }
                else
                {
                    Luz5.BackColor = Color.Gray;
                    Luz13.BackColor = Color.Gray;
                }

            }
            else if (Fallo > 0)
            {

                if (checkBox6.Checked)
                {
                    Luz5.BackColor = Color.Green;
                    Luz13.BackColor = Color.Green;
                }
                else
                {
                    Luz5.BackColor = Color.Gray;
                    Luz13.BackColor = Color.Gray;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int Fallo = random.Next(3);
            if (Fallo == 0)
            {
                if (checkBox2.Checked)
                {
                    Luz2.BackColor = Color.Red;
                    Luz12.BackColor = Color.Red;
                }
                else
                {
                    Luz2.BackColor = Color.Gray;
                    Luz12.BackColor = Color.Gray;
                }

            }
            else if (Fallo > 0)
            {

                if (checkBox2.Checked)
                {
                    Luz2.BackColor = Color.Green;
                    Luz12.BackColor = Color.Green;
                }
                else
                {
                    Luz2.BackColor = Color.Gray;
                    Luz12.BackColor = Color.Gray;
                }
            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int Fallo = random.Next(3);
            if (Fallo == 0)
            {
                if (checkBox5.Checked)
                {
                    Luz6.BackColor = Color.Red;
                    Luz16.BackColor = Color.Red;
                }
                else
                {
                    Luz6.BackColor = Color.Gray;
                    Luz16.BackColor = Color.Gray;
                }

            }
            else if (Fallo > 0)
            {

                if (checkBox5.Checked)
                {
                    Luz6.BackColor = Color.Green;
                    Luz16.BackColor = Color.Green;
                }
                else
                {
                    Luz6.BackColor = Color.Gray;
                    Luz16.BackColor = Color.Gray;
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int Fallo = random.Next(3);
            if (Fallo == 0)
            {
                if (checkBox1.Checked)
                {
                    Luz3.BackColor = Color.Red;
                    Luz14.BackColor = Color.Red;
                }
                else
                {
                    Luz3.BackColor = Color.Gray;
                    Luz14.BackColor = Color.Gray;
                }

            }
            else if (Fallo > 0)
            {

                if (checkBox1.Checked)
                {
                    Luz3.BackColor = Color.Green;
                    Luz14.BackColor = Color.Green;
                }
                else
                {
                    Luz3.BackColor = Color.Gray;
                    Luz14.BackColor = Color.Gray;
                }
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int Fallo = random.Next(3);
            if (Fallo == 0)
            {
                if (checkBox8.Checked)
                {
                    Luz7.BackColor = Color.Red;
                    Luz9.BackColor = Color.Red;
                }
                else
                {
                    Luz7.BackColor = Color.Gray;
                    Luz9.BackColor = Color.Gray;
                }

            }
            else if (Fallo > 0)
            {

                if (checkBox8.Checked)
                {
                    Luz7.BackColor = Color.Green;
                    Luz9.BackColor = Color.Green;
                }
                else
                {
                    Luz7.BackColor = Color.Gray;
                    Luz9.BackColor = Color.Gray;
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int Fallo = random.Next(3);
            if (Fallo == 0)
            {
                if (checkBox3.Checked)
                {
                    Luz4.BackColor = Color.Red;
                    Luz15.BackColor = Color.Red;
                }
                else
                {
                    Luz4.BackColor = Color.Gray;
                    Luz15.BackColor = Color.Gray;
                }

            }
            else if (Fallo > 0)
            {

                if (checkBox3.Checked)
                {
                    Luz4.BackColor = Color.Green;
                    Luz15.BackColor = Color.Green;
                }
                else
                {
                    Luz4.BackColor = Color.Gray;
                    Luz15.BackColor = Color.Gray;
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int Fallo = random.Next(3);
            if (Fallo == 0)
            {
                if (checkBox7.Checked)
                {
                    Luz8.BackColor = Color.Red;
                    Luz10.BackColor = Color.Red;
                }
                else
                {
                    Luz8.BackColor = Color.Gray;
                    Luz10.BackColor = Color.Gray;
                }

            }
            else if (Fallo > 0)
            {

                if (checkBox7.Checked)
                {
                    Luz8.BackColor = Color.Green;
                    Luz10.BackColor = Color.Green;
                }
                else
                {
                    Luz8.BackColor = Color.Gray;
                    Luz10.BackColor = Color.Gray;
                }
            }
        }

        
    }
}
