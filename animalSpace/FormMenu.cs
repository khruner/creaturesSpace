using animalSpace.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animalSpace
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnCreatures_Click(object sender, EventArgs e)
        {
            FormCreatures formCreatures = new FormCreatures();
            formCreatures.Show();
            this.Hide();
        }

        private void btnCreateItems_Click(object sender, EventArgs e)
        {
            FormItems formItems = new FormItems();
            formItems.Show();
            this.Hide();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            FormCreatureActions formCreaturesActions = new FormCreatureActions();
            formCreaturesActions.Show();
            this.Hide();
        }
    }
}
