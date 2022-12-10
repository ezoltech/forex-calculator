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
        int money = 10;
        double lot_size, trading_amount;
        float pips_size, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            lot_size = double.Parse(txt_lot.Text);
            pips_size = float.Parse(txt_pips.Text);
            trading_amount = double.Parse(txt_amnt.Text);
            lbl_result.Text = (trading_amount * lot_size * pips_size * money).ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_pips.Text = "";
            txt_lot.Text = "";
            txt_amnt.Text = "";
            lbl_result.Text = "";
        }
    }
}
