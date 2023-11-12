using animalSpace.Controllers;
using animalSpace.Model;
using animalSpace.Model.InteractablesAndItems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animalSpace.Forms
{
    public partial class FormCreatureActions : Form
    {
        /*
         * Aca tendria que poder moverse entre terrenos, tener diferentes items/criaturas
         * en diferentes terrenos
         * poder usar un item, o varios
         * atacarse entre entidades
         * 
         */

        ControllerCreature creatureCtr = ControllerCreature.getInstance();
        ControllerItem itemCtr = ControllerItem.getInstance();
        public FormCreatureActions()
        {
            InitializeComponent();
            loadCreatures();
            loadItems();
            dgvCreatures1.ScrollBars = ScrollBars.Both;
            dgvCreatures2.ScrollBars = ScrollBars.Both;
        }

        public void loadCreatures()
        {
            List<Creature> creaturesList1 = creatureCtr.loadPreDefinedCreaturesTest1();
            List<Creature> creaturesList2 = creatureCtr.loadPreDefinedCreaturesTest2();
            dgvCreatures1.Rows.Clear();
            foreach (var creature in creaturesList1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvCreatures1,
                    creature.getCreatureName(),
                    creature.getCreatureKingdom(),
                    creature.getEnvironmentsString(),
                    creature.getCreatureDiet(),
                    creature.getAtkPoints(),
                    creature.getDefPoints(),
                    creature.getCurrentHealth(),
                    creature.getCurrentEnergy());
                dgvCreatures1.Rows.Add(row);
            }
            foreach (var creature in creaturesList2)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvCreatures2,
                    creature.getCreatureName(),
                    creature.getCreatureKingdom(),
                    creature.getEnvironmentsString(),
                    creature.getCreatureDiet(),
                    creature.getAtkPoints(),
                    creature.getDefPoints(),
                    creature.getCurrentHealth(),
                    creature.getCurrentEnergy());
                dgvCreatures2.Rows.Add(row);
            }
        }

        public void loadItems()
        {
            List<Item> itemsList = itemCtr.generatePredefinedItems();
            foreach (Item item in itemsList)
            {
                cbItems.Items.Add(item);
            }
            cbItems.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Close();
        }
    }
}
