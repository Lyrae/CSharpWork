using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsCalculator
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

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      double a = double.Parse(textBox1.Text);
      string oper = comboBox1.Text;
      double b = double.Parse(textBox2.Text);
      double result;
      switch (oper)
      {
        case "+":
          result = a + b;
          textBox3.Text = result.ToString();
          break;
        case "-":
          result = a - b;
          textBox3.Text = result.ToString();
          break;
        case "*":
          result = a * b;
          textBox3.Text = result.ToString();
          break;
        case "/":
          if (b == 0) { textBox3.Text = "Math error!"; break; }
          else result = a / b;
          textBox3.Text = result.ToString();
          break;
        default:
          textBox3.Text = "input invalid";
          break;
      }
      
    }
  }
}
