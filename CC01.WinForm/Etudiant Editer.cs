using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WinForm
{
    public partial class Ecole : Form
    {
        public Ecole()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            Etudiant etudiant = new Etudiant(
                txtmatricule.Text,
                txtnom.Text, txtprenom.Text,
                int.Parse(txtcontact.Text),
                txtecole.Text,
                txtdatedenaissance.Text);
            EtudiantBLO etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
            etudiantBLO.CreateEtudiant(etudiant);
            MessageBox.Show(
                "save done!",
                "confirmation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txtmatricule.Clear();
            txtnom.Clear();
            txtprenom.Clear();
            txtcontact.Clear();
            txtecole.Clear();
            txtdatedenaissance.Clear();
            txtmatricule.Focus();
        }
    }
}
