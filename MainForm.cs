using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakturaHanterare
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void clearAll()
        {
            company_txtBox.Clear();
            Invoice_txtBox.Clear();
            OCR_textBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Faktura f = new Faktura();
            f.CompanyName = company_txtBox.Text;
            f.InvoiceNbr = Invoice_txtBox.Text;
            f.OcrNbr = OCR_textBox.Text;
            f.PayDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            listBox1.Items.Add(f);
            clearAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem == null)
            {
                MessageBox.Show("Ingen rad har valts", "OBS!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }else
            {
                string curItem = listBox1.SelectedItem.ToString();
                Console.WriteLine(curItem);
            }
            
        }
    }
}
