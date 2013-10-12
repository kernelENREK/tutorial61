using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(mskNum1.Text);
            int num2 = Convert.ToInt32(mskNum2.Text);

            Operaciones operaciones = new Operaciones();

            try
            {
                int suma = operaciones.Sumar(num1, num2);
                lblResultado.Text = suma.ToString();
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }            
        }
    }
}
