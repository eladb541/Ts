using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int counter1 = 0;
        int counter2 = 0;
        int counter3 = 0;
        int counter4 = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1")
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;

                label1.Text = counter1.ToString();
            }
            else if (comboBox1.Text == "2")
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;

                label1.Text = counter1.ToString();
            }
            else if (comboBox1.Text == "3")
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;

                label1.Text = counter1.ToString();
            }
            else if (comboBox1.Text == "4")
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;

                label1.Text = counter1.ToString();
            }


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            counter1 = counter1 + 1;
            label1.Text = counter1.ToString();
            if (counter1 == 2)
            {
                this.ovalShape1.BackColor = Color.Yellow;
                this.ovalShape1.BorderColor = Color.Yellow;

            }
            else if (counter1 >= 3 && counter1 <= 18)
            {
                this.ovalShape1.BackColor = Color.Green;
                this.ovalShape1.BorderColor = Color.Green;

                if (pictureBox1.Visible == true)
                {
                    pictureBox1.Top += +43;

                }
                if (pictureBox2.Visible == true)
                {
                    pictureBox2.Top += 43;
                }
                if (counter1 >= 4 && counter1 <= 11 && pictureBox3.Visible == true)
                {
                    pictureBox3.Top += 25;
                }
                if (counter1 >= 12 && counter1 <= 17 && pictureBox3.Visible == true)
                {
                    pictureBox3.Left += -60;
                }
                if (counter1 >= 4 && counter1 <= 14 && pictureBox4.Visible == true)
                {
                    pictureBox4.Top += 42;
                }
                if (counter1 >= 13 && counter1 <= 17 && pictureBox4.Visible == true)
                {
                    pictureBox4.Left += 80;
                }
            }
            else if (counter1 >= 18 && counter1 <= 19)
            {
                this.ovalShape1.BackColor = Color.Yellow;
                this.ovalShape1.BorderColor = Color.Yellow;

            }
            else if (counter1 == 20)
            {
                timer1.Stop();
                this.ovalShape1.BackColor = Color.Red;
                this.ovalShape1.BorderColor = Color.Red;
                counter1 = 0;
                timer2.Start();

            }
        }

        private void Startbutt_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "1")
            {
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;

                label2.Text = counter2.ToString();
            }
            else if (comboBox2.Text == "2")
            {
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;

                label2.Text = counter2.ToString();


            }
            else if (comboBox2.Text == "3")
            {
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = false;

                label2.Text = counter2.ToString();
            }
            else if (comboBox2.Text == "4")
            {
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;

                label2.Text = counter2.ToString();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            counter2 = counter2 + 1;
            label2.Text = counter2.ToString();
            if (counter2 == 2)
            {
                this.ovalShape2.BackColor = Color.Yellow;
                this.ovalShape2.BorderColor = Color.Yellow;

            }
            else if (counter2 >= 3 && counter2 <= 18)
            {
                this.ovalShape2.BackColor = Color.Green;
                this.ovalShape2.BorderColor = Color.Green;

                if (pictureBox5.Visible == true)
                {
                    pictureBox5.Left += +47;

                }
                if (pictureBox6.Visible == true)
                {
                    pictureBox6.Left += 47;
                }


                if (counter2 >= 4 && counter2 <= 13 && pictureBox7.Visible == true)
                {
                    pictureBox7.Left += 48;
                }
                if (counter2 >= 12 && counter2 <= 17 && pictureBox7.Visible == true)
                {
                    pictureBox7.Top += -60;
                }


                if (counter2 >= 4 && counter2 <= 14 && pictureBox8.Visible == true)
                {
                    pictureBox8.Left += 35;
                }
                if (counter2 >= 13 && counter2 <= 17 && pictureBox8.Visible == true)
                {
                    pictureBox8.Top += 40;
                }
            }
            else if (counter2 >= 18 && counter2 <= 19)
            {
                this.ovalShape2.BackColor = Color.Yellow;
                this.ovalShape2.BorderColor = Color.Yellow;

            }
            else if (counter2 == 20)
            {
                timer2.Stop();
                this.ovalShape2.BackColor = Color.Red;
                this.ovalShape2.BorderColor = Color.Red;
                counter2 = 0;
                timer3.Start();
            }
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "1")
            {
                pictureBox9.Visible = true;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;

                label3.Text = counter3.ToString();
            }
            else if (comboBox3.Text == "2")
            {
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;

                label3.Text = counter3.ToString();
            }
            else if (comboBox3.Text == "3")
            {
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = false;

                label3.Text = counter3.ToString();
            }
            else if (comboBox3.Text == "4")
            {
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true; ;

                label3.Text = counter3.ToString();
            }
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            counter3 = counter3 + 1;
            label3.Text = counter3.ToString();
            if (counter3 == 2)
            {
                this.ovalShape3.BackColor = Color.Yellow;
                this.ovalShape3.BorderColor = Color.Yellow;

            }
            else if (counter3 >= 3 && counter3 <= 18)
            {
                this.ovalShape3.BackColor = Color.Green;
                this.ovalShape3.BorderColor = Color.Green;

                if (pictureBox9.Visible == true)
                {
                    pictureBox9.Top += -43;

                }
                if (pictureBox10.Visible == true)
                {
                    pictureBox10.Top += -43;
                }
                if (counter3 >= 4 && counter3 <= 11 && pictureBox11.Visible == true)
                {
                    pictureBox11.Top += -30;
                }
                if (counter3 >= 12 && counter3 <= 17 && pictureBox11.Visible == true)
                {
                    pictureBox11.Left += +61;
                }
                if (counter3 >= 4 && counter3 <= 14 && pictureBox12.Visible == true)
                {
                    pictureBox12.Top += -42;
                }
                if (counter3 >= 13 && counter3 <= 17 && pictureBox12.Visible == true)
                {
                    pictureBox12.Left += -80;
                }
            }
            else if (counter3 >= 18 && counter3 <= 19)
            {
                this.ovalShape3.BackColor = Color.Yellow;
                this.ovalShape3.BorderColor = Color.Yellow;

            }
            else if (counter3 == 20)
            {
                timer3.Stop();
                this.ovalShape3.BackColor = Color.Red;
                this.ovalShape3.BorderColor = Color.Red;
                counter3 = 0;
                timer4.Start();
                

            }
        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //13,15,18,22
            if (comboBox4.Text == "1")
            {
                pictureBox13.Visible = true;
                pictureBox15.Visible = false;
                pictureBox18.Visible = false;
                pictureBox22.Visible = false;

                label4.Text = counter4.ToString();
            }
            else if (comboBox4.Text == "2")
            {
                pictureBox13.Visible = true;
                pictureBox15.Visible = true;
                pictureBox18.Visible = false;
                pictureBox22.Visible = false;

                label4.Text = counter4.ToString();
            }
            else if (comboBox4.Text == "3")
            {
                pictureBox13.Visible = true;
                pictureBox15.Visible = true;
                pictureBox18.Visible = true;
                pictureBox22.Visible = false;

                label4.Text = counter4.ToString();
            }
            else if (comboBox4.Text == "4")
            {
                pictureBox13.Visible = true;
                pictureBox15.Visible = true;
                pictureBox18.Visible = true;
                pictureBox22.Visible = true;

                label4.Text = counter4.ToString();
            }
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            counter4 = counter4 + 1;
            label4.Text = counter4.ToString();
            if (counter4 == 2)
            {
                this.ovalShape4.BackColor = Color.Yellow;
                this.ovalShape4.BorderColor = Color.Yellow;

            }
            else if (counter4 >= 3 && counter4 <= 18)
            {
                this.ovalShape4.BackColor = Color.Green;
                this.ovalShape4.BorderColor = Color.Green;

                if (pictureBox13.Visible == true)
                {
                    pictureBox13.Left += -47;

                }
                if (pictureBox15.Visible == true)
                {
                    pictureBox15.Left += -47;
                }


                if (counter4 >= 4 && counter4 <= 13 && pictureBox18.Visible == true)
                {
                    pictureBox18.Left += -39;
                }
                if (counter4 >= 12 && counter4 <= 17 && pictureBox18.Visible == true)
                {
                    pictureBox18.Top += -60;
                }


                if (counter4 >= 4 && counter4 <= 14 && pictureBox22.Visible == true)
                {
                    pictureBox22.Left += -43;
                }
                if (counter4 >= 13 && counter4 <= 17 && pictureBox22.Visible == true)
                {
                    pictureBox22.Top += 55;
                }
            }
            else if (counter4 >= 18 && counter4 <= 19)
            {
                this.ovalShape4.BackColor = Color.Yellow;
                this.ovalShape4.BorderColor = Color.Yellow;

            }
            else if (counter4 == 20)
            {
                timer4.Stop();
                this.ovalShape4.BackColor = Color.Red;
                this.ovalShape4.BorderColor = Color.Red;
                counter4 = 0;
                
            }
        }
    }
}
