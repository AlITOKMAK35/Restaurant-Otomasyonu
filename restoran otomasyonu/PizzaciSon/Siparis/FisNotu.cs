using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaciSon.Siparis
{
    public partial class FisNotu : Form
    {
        public FisNotu()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            SiparisAna.fisNotu = txtBxFisNotu.Text;
            this.Hide();
        }
        private void FisNotu_Load(object sender, EventArgs e)
        {
            txtBxFisNotu.Text = SiparisAna.fisNotu;
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnOnayla_Click_1(object sender, EventArgs e)
        {

        }
    }
}
