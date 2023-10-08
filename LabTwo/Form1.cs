using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTwo
{
    public partial class Form1 : Form
    {
        ProductionWork pro = new ProductionWork();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pro.Ename = tbxName.Text;
            pro.Number = int.Parse(tbxNum.Text);
            pro.Shift = tbxShift.Text;
            pro.PayRate =decimal.Parse(tbxRate.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int hours = int.Parse(tbxHours.Text);

            lblname.Text = pro.Ename;
            lblNum.Text = pro.Number.ToString();
            lblrate.Text = pro.PayRate.ToString();
            lblshift.Text = pro.Shift;
            lblsalery.Text = (pro.PayRate * hours).ToString();

        }
    }
}
