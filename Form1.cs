using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBoxA.Text);
            double b = double.Parse(textBoxB.Text);
            double c = double.Parse(textBoxC.Text);

            double dick = Math.Pow(b, 2) - 4 * a * c;
            if (dick > 0)
            {
                // Два корня
                double x1 = (-b + Math.Sqrt(dick)) / (2 * a);
                double x2 = (-b - Math.Sqrt(dick)) / (2 * a);
                textBoxResult.Text = $"x1 = {x1:F2}";
                textBoxresult2.Text = $"x2 = {x2:F2}";

            }
            else if( dick == 0)
            {
                // Два совпавших корня
                double x3 = (-b + Math.Sqrt(dick)) / (2 * a);
                textBoxResult.Text = $"x1 = {x3:F2}";
                textBoxresult2.Clear();
            }
            else
            {
                // Нет действительных корней
                textBoxResult.Text = "Уравнение не имеет корней.";
                textBoxresult2.Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonZak_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    
}
