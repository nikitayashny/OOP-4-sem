using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int empty = 0;

                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                    empty = 1;
                if (empty == 0) {
                    label6.Text = "Введены не все необходимые данные";
                    return;
                }
                if (radioButton1.Checked && (Convert.ToInt32(textBox2.Text) != Convert.ToInt32(textBox5.Text))) {
                    label6.Text = "Некорректно задан желаемый вес";
                    return;
                }
                if (radioButton2.Checked && (Convert.ToInt32(textBox2.Text) <= Convert.ToInt32(textBox5.Text))){
                    label6.Text = "Некорректно задан желаемый вес";
                    return;
                }
                if (radioButton3.Checked && (Convert.ToInt32(textBox2.Text) >= Convert.ToInt32(textBox5.Text))) {
                    label6.Text = "Некорректно задан желаемый вес";
                    return;
                }
                else if (textBox1.Text == "мужской") 
                {
                    double km = 0;

                    if (radioButton1.Checked)
                        km = 88.36 + 13.4 * Convert.ToInt32(textBox2.Text) + 4.8 * Convert.ToInt32(textBox3.Text) - 5.7 * Convert.ToInt32(textBox4.Text);
                    if (radioButton2.Checked)
                        km = 88.36 + 13.4 * Convert.ToInt32(textBox2.Text) + 4.8 * Convert.ToInt32(textBox3.Text) - 5.7 * Convert.ToInt32(textBox4.Text) - 200;
                    if (radioButton3.Checked)
                        km = 88.36 + 13.4 * Convert.ToInt32(textBox2.Text) + 4.8 * Convert.ToInt32(textBox3.Text) - 5.7 * Convert.ToInt32(textBox4.Text) + 200;

                    label6.Text = km.ToString();
                    label6.Text += " ккал - суточная норма\n";

                    double imt = 0;
                    imt = Convert.ToInt32(textBox2.Text) / ((Convert.ToInt32(textBox3.Text) / 100) ^ 2);

                    if (imt < 18.5)
                        label6.Text += "Ниже нормального веса";
                    if (imt >= 18.5 && imt < 25)
                        label6.Text += "Нормальный вес";
                    if (imt >= 25 && imt < 30)
                        label6.Text += "Избыточный вес";
                    if (imt >= 30 && imt < 35)
                        label6.Text += "Ожирение I степени";
                    if (imt >= 35 && imt < 40)
                        label6.Text += "Ожирение II степени";
                    if (imt >= 40)
                        label6.Text += "Ожирение III степени";
                }
                else if (textBox1.Text == "женский") 
                {
                    double kw = 0;
                    
                    if (radioButton1.Checked)
                        kw = 447.6 + 9.2 * Convert.ToInt32(textBox2.Text) + 3.1 * Convert.ToInt32(textBox3.Text) - 4.3 * Convert.ToInt32(textBox4.Text);
                    if (radioButton2.Checked)
                        kw = 447.6 + 9.2 * Convert.ToInt32(textBox2.Text) + 3.1 * Convert.ToInt32(textBox3.Text) - 4.3 * Convert.ToInt32(textBox4.Text) - 200;
                    if (radioButton3.Checked)
                        kw = 447.6 + 9.2 * Convert.ToInt32(textBox2.Text) + 3.1 * Convert.ToInt32(textBox3.Text) - 4.3 * Convert.ToInt32(textBox4.Text) + 200;

                    label6.Text = kw.ToString();
                    label6.Text += " ккал - суточная норма\n";

                    double imt = 0;
                    imt = Convert.ToInt32(textBox2.Text) / ((Convert.ToInt32(textBox3.Text) / 100) ^ 2);

                    if (imt < 18.5)
                        label6.Text += "Ниже нормального веса";
                    if (imt >= 18.5 && imt < 25)
                        label6.Text += "Нормальный вес";
                    if (imt >= 25 && imt < 30)
                        label6.Text += "Избыточный вес";
                    if (imt >= 30 && imt < 35)
                        label6.Text += "Ожирение I степени";
                    if (imt >= 35 && imt < 40)
                        label6.Text += "Ожирение II степени";
                    if (imt >= 40)
                        label6.Text += "Ожирение III степени";
                }
                if (textBox1.Text != "мужской" && textBox1.Text != "женский")
                {
                    label6.Text = "Пол указан некорректно";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "дальнейшие подсчёты неверны");
            }
            finally
            {
                if (label6.Text != "Введены не все необходимые данные")
                    label6.Text += "\n\nрасчёт окончен";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

      
    }
}
