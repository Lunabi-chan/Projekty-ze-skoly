using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Něco_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Ahoj zdraví tě C#!", 
                "Pozdrav",
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("Was it you who I was searching for" +
                "\nSpent my life alone and waited for" +
                "\nSo tenderly and endlessly" +
                "\nYou made me whole, you made me whole...",
               "Lmyk - Zero",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Information);*/
            
            DialogResult volba;
            volba = MessageBox.Show("Chceš barvu aqua nebo ne?", "Barva pozadí", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (volba == DialogResult.Yes)
                this.BackColor = Color.Aqua;
            if (volba == DialogResult.No)
            {                 
                MessageBox.Show("Oké", "Tak nebude aqua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.BackColor = Color.AliceBlue;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string soubor = string.Empty;
            OpenFileDialog otevření = new OpenFileDialog();
            otevření.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            otevření.InitialDirectory = "C:\\";
            otevření.Title = "Výběr textového souboru";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
