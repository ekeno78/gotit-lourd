using System;
using System.Windows.Forms;


namespace GOTIT
{
    public partial class FrgestionUser : Form
    {
        
        public FrgestionUser()
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fr_Load(object sender, EventArgs e)
        {
  
        }

        private void ltUtilisateur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrgestionUser_Load(object sender, EventArgs e)
        {
            ClassADO cl = new ClassADO();

            cl.ConnexionBase();

        }
    }
}
