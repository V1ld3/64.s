using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _64.s
{
    public partial class Form1 : Form
    {
        List<Figur> Lista = new List<Figur>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnMC_Click(object sender, EventArgs e)
        {
            double height;
            bool antalOK = double.TryParse(tbxH.Text, out height);
            if (antalOK && height > 0 && tbxW.text > 0)
            
            {
                Figur nyFigur = new Figur(tbxW.text, tbxH.text);
                Lista.Add(nyFigur);
                tbxW.Text = "";
                tbxH.Text = "";
                FyllFigurlista();
            }
        }

        private void btnMT_Click(object sender, EventArgs e)
        {

        }

        private void btnML_Click(object sender, EventArgs e)
        {

        }


        private void FyllFigurlista()
        {
            lbxFL.Items.Clear();
            foreach (Figur m in Lista)
            {
                lbxFL.Items.Add(m);
            }
        }
    }



}
