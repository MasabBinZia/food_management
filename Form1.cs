using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood_management1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double friesp = 80, burgerp = 250, pizzap = 1000, pastap = 200, noodlesp = 100, swarmap= 120, meatballp = 25.0;
        double cokep = 60, dewp = 60, chocoshakep = 150, mintshakep = 150, dougnautp = 170, icecreamp = 120, puddingp =130 ;
        double friestp, burgertp, pizzatp, pastatp, noodlestp, swarmatp, meatballtp, coketp, dewtp, chocoshaketp, mintshaketp, dougnauttp, icecreamtp, puddingtp,tax,total;

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(receiptTextbox.Text + " Subtotal: " + subTotallbl.Text + "; VAT: " + vatlbl.Text + "; Total: " + totallbl.Text, new Font("Century Gothic", 17, FontStyle.Regular), Brushes.Blue, new Point(130));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        double subtotal = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            friesCheck.Checked = false;
            burgerCheck.Checked = false;
            pizzaCheck.Checked = false;
            pastaCheck.Checked = false;
            noodlesCheck.Checked = false;
            swarmaCHeck.Checked = false;
            meatballCheck.Checked = false;
            cokeCheck.Checked = false;
            dewCheck.Checked = false;
            chocoShakeCheck.Checked = false;
            mintShakeCheck.Checked = false;
            dougnautCheck.Checked = false;
            icecreamCheck.Checked = false;
            puddingCheck.Checked = false;
            receiptTextbox.Clear();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var dt1 = DateTime.Now;
            string dates = dt1.ToString("dddd, dd MMMM yyyy");
            friestp = friesp * Convert.ToDouble(friesTextbox.Text);
            burgertp = burgerp * Convert.ToDouble(burgerTextbox.Text);
            pizzatp = pizzap * Convert.ToDouble(pizzaTextbox.Text);
            pastatp = pastap * Convert.ToDouble(pastaTextbox.Text);
            noodlestp = noodlesp * Convert.ToDouble(noodlesTextbox.Text);
            swarmatp = swarmap * Convert.ToDouble(swarmaTextbox.Text);
            meatballtp = meatballp * Convert.ToDouble(meatballTextbox.Text);
            coketp = cokep * Convert.ToDouble(cokeTextbox.Text);
            dewtp = dewp * Convert.ToDouble(dewTextbox.Text);
            chocoshaketp = chocoshakep * Convert.ToDouble(chocoshakeTextbox.Text);
            mintshaketp = mintshakep * Convert.ToDouble(mintshakeTextbox.Text);
            dougnauttp = dougnautp * Convert.ToDouble(dougnautTextbox.Text);
            icecreamtp = icecreamp * Convert.ToDouble(icecreamTexbox.Text);
            puddingtp = puddingp * Convert.ToDouble(puddingTextbox.Text);
            receiptTextbox.Clear();
            receiptTextbox.AppendText(Environment.NewLine);
            receiptTextbox.AppendText("\t Fast Food" + Environment.NewLine);
            receiptTextbox.AppendText("\t********************************************" + Environment.NewLine);
            receiptTextbox.AppendText("\t" + dates + "\t" + Datelbl.Text + Environment.NewLine);
            receiptTextbox.AppendText(Environment.NewLine);
            receiptTextbox.AppendText(Environment.NewLine);
            int count = 0;
            if (friesCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".Fries:" + friestp + " Rs" + Environment.NewLine);
                subtotal = subtotal + friestp;
                subTotallbl.Text ="" + Convert.ToString(subtotal) + " Rupees/-";
            }
            if (burgerCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Burger:" + burgertp + " Rs" + Environment.NewLine);
                subtotal = subtotal + burgertp;
                subTotallbl.Text ="" + Convert.ToString(subtotal) + " Rupees/-";
            }
            if (pizzaCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Pizza:" + pizzatp + " Rs" + Environment.NewLine);
                subtotal = subtotal + pizzatp;
                subTotallbl.Text ="" + Convert.ToString(subtotal) + " Rupees/-";
            }
            if (pastaCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Pasta:" + pastatp + " Rs" + Environment.NewLine);
                subtotal = subtotal + pastatp;
                subTotallbl.Text ="" + Convert.ToString(subtotal) + " Rupees/-";
            }
            if (noodlesCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Noodles:" + noodlestp + " Rs" + Environment.NewLine);
                subtotal = subtotal + noodlestp;
                subTotallbl.Text ="" + Convert.ToString(subtotal) + " Rupees/-";
            }
            if (swarmaCHeck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Swarma:" + swarmatp + " Rs" + Environment.NewLine);
                subtotal = subtotal + swarmatp;
                subTotallbl.Text ="" + Convert.ToString(subtotal) + " Rupees/-";
            }
            if (meatballCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Meat-Balls:" + meatballtp + " Rs" + Environment.NewLine);
                subtotal = subtotal + meatballtp;
                subTotallbl.Text ="" + Convert.ToString(subtotal) + " Rupees/-";
            }
            if (cokeCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Coka-Cola:" + coketp + " Rs" + Environment.NewLine);
                subtotal = subtotal + coketp;
                subTotallbl.Text ="" + Convert.ToString(subtotal) + " Rupees/-";
            }
            if (dewCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Mountain-Dew:" + dewtp + " Rs" + Environment.NewLine);
                subtotal = subtotal + dewtp;
                subTotallbl.Text ="" + Convert.ToString(subtotal) + " Rupees/-";
            }
            if (chocoShakeCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  ChocoShake:" + chocoshaketp + " Rs" + Environment.NewLine);
                subtotal = subtotal + chocoshaketp;
                subTotallbl.Text ="" + Convert.ToString(subtotal) + " Rupees/-";
            }
            if (mintShakeCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  MintShake:" + mintshakep + " Rs" + Environment.NewLine);
                subtotal = subtotal + mintshakep;
                subTotallbl.Text = "" + Convert.ToString(subtotal) + " Rupees/-";
            }
            if (dougnautCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Dougnauts:" + dougnautp + " Bdt" + Environment.NewLine);
                subtotal = subtotal + dougnautp;
                subTotallbl.Text =""+ Convert.ToString(subtotal) + " Rupees/-";
            }
            if (icecreamCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Ice -Cream:" + icecreamtp + " Rs" + Environment.NewLine);
                subtotal = subtotal + icecreamtp;
                subTotallbl.Text = "" + Convert.ToString(subtotal) + " Rupees/-";
            }
            if (puddingCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t"+Convert.ToString(count) +".  Pudding:" + puddingtp + " Rs" + Environment.NewLine);
                subtotal = subtotal + puddingtp;
                subTotallbl.Text =  "" + Convert.ToString(subtotal) + " Rupees/-";
            }
            tax = subtotal * 0;
            total = subtotal + tax;
            vatlbl.Text = Convert.ToString(tax) + " Rupees/-";
            totallbl.Text = Convert.ToString(total) + " Rupees/-";
            receiptTextbox.AppendText(Environment.NewLine);
            receiptTextbox.AppendText(Environment.NewLine);
 
        }
            

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            var dt1 = DateTime.Now;
            string dates = dt1.ToString("dddd, dd MMMM yyyy");
            label1.Text = dates;
        }

        private void friesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (friesCheck.Checked == true)
            {
                friesTextbox.Enabled = true;
            }
            if (friesCheck.Checked == false)
            {
                friesTextbox.Enabled = false;
                friesTextbox.Text = "0";
            }
        }

        private void burgerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (burgerCheck.Checked == true)
            {
                burgerTextbox.Enabled = true;
            }
            if (burgerCheck.Checked == false)
            {
                burgerTextbox.Enabled = false;
                burgerTextbox.Text = "0";
            }
        }

        private void pizzaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (pizzaCheck.Checked == true)
            {
                pizzaTextbox.Enabled = true;
            }
            if (pizzaCheck.Checked == false)
            {
                pizzaTextbox.Enabled = false;
                pizzaTextbox.Text = "0";
            }
        }

        private void pastaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (pastaCheck.Checked == true)
            {
                pastaTextbox.Enabled = true;
            }
            if (pastaCheck.Checked == false)
            {
                pastaTextbox.Enabled = false;
                pastaTextbox.Text = "0";
            }
        }

        private void noodlesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (noodlesCheck.Checked == true)
            {
                noodlesTextbox.Enabled = true;
            }
            if (noodlesCheck.Checked == false)
            {
                noodlesTextbox.Enabled = false;
                noodlesTextbox.Text = "0";
            }
        }

        private void swarmaCHeck_CheckedChanged(object sender, EventArgs e)
        {
            if (swarmaCHeck.Checked == true)
            {
                swarmaTextbox.Enabled = true;
            }
            if (swarmaCHeck.Checked == false)
            {
                swarmaTextbox.Enabled = false;
                swarmaTextbox.Text = "0";
            }
        }

        private void meatballCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (meatballCheck.Checked == true)
            {
                meatballTextbox.Enabled = true;
            }
            if (meatballCheck.Checked == false)
            {
                meatballTextbox.Enabled = false;
                meatballTextbox.Text = "0";
            }
        }

        private void cokeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cokeCheck.Checked == true)
            {
                cokeTextbox.Enabled = true;
            }
            if (cokeCheck.Checked == false)
            {
                cokeTextbox.Enabled = false;
                cokeTextbox.Text = "0";
            }
        }

        private void dewCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (dewCheck.Checked == true)
            {
                dewTextbox.Enabled = true;
            }
            if (dewCheck.Checked == false)
            {
                dewTextbox.Enabled = false;
                dewTextbox.Text = "0";
            }
        }

        private void chocoShakeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chocoShakeCheck.Checked == true)
            {
                chocoshakeTextbox.Enabled = true;
            }
            if (chocoShakeCheck.Checked == false)
            {
                chocoshakeTextbox.Enabled = false;
                chocoshakeTextbox.Text = "0";
            }
        }

        private void mintShakeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (mintShakeCheck.Checked == true)
            {
                mintshakeTextbox.Enabled = true;
            }
            if (mintShakeCheck.Checked == false)
            {
                mintshakeTextbox.Enabled = false;
                mintshakeTextbox.Text = "0";
            }
        }

        private void dougnautCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (dougnautCheck.Checked == true)
            {
                dougnautTextbox.Enabled = true;
            }
            if (dougnautCheck.Checked == false)
            {
                dougnautTextbox.Enabled = false;
                dougnautTextbox.Text = "0";
            }
        }

        private void icecreamCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (icecreamCheck.Checked == true)
            {
                icecreamTexbox.Enabled = true;
            }
            if (icecreamCheck.Checked == false)
            {
                icecreamTexbox.Enabled = false;
                icecreamTexbox.Text = "0";
            }
        }

        private void puddingCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (puddingCheck.Checked == true)
            {
                puddingTextbox.Enabled = true;
            }
            if (puddingCheck.Checked == false)
            {
                puddingTextbox.Enabled = false;
                puddingTextbox.Text = "0";
            }
        }

        private void closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
