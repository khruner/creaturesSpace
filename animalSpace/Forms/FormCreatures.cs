using animalSpace.Controllers;
using animalSpace.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Environment = animalSpace.Model.Environment;

namespace animalSpace.Forms
{
    public partial class FormCreatures : Form
    {
        ControllerCreature ctrCreature = ControllerCreature.getInstance();
        public FormCreatures()
        {
            InitializeComponent();
            addItemsToCbCreatureDiet();
            addItemsToCbCreatureEnvironment();
            addItemsToCbCreatureKingdom();
        }

        public void addItemsToCbCreatureDiet()
        {
        }

        public void addItemsToCbCreatureEnvironment()
        {
            Environment terrestrial = new Environment("terrestrial");
            Environment Aero = new Environment("Aero");
            Environment Acuatic = new Environment("Acuatic");
            cbCreatureEnvironment.Items.Add(terrestrial.getEnvironmentName());
            cbCreatureEnvironment.Items.Add(Aero.getEnvironmentName());
            cbCreatureEnvironment.Items.Add(Acuatic.getEnvironmentName());
            cbCreatureEnvironment.SelectedIndex = 0;
        }

        public void addItemsToCbCreatureKingdom()
        {
            //cbCreatureKingdom.SelectedIndex = 0;
        }

        private void btnCreateCreature_Click(object sender, EventArgs e)
        {
            /*ctrCreature.createCreature(tbCreatureName.Text,
                cbCreatureEnvironment.SelectedItem.ToString());*/
            loadDgvCreatures();
        }

        public void loadDgvCreatures()
        {
            List<Creature> listCreatures = ctrCreature.getCreatures();
            dgvCreatures.Rows.Clear();
            foreach (var creature in listCreatures)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvCreatures, creature.getCreatureName(), creature.getCreatureKingdom(), creature.getCreatureEnvironment(), creature.getCreatureDiet());
                dgvCreatures.Rows.Add(row);
            }
        }


    
    }
}
