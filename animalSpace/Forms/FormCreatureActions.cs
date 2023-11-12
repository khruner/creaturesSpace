using animalSpace.Controllers;
using animalSpace.Interfaces;
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
            dgvCreatures1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCreatures2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                    creature.getCreatureId(),
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
                    creature.getCreatureId(),
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
            cbItems.Items.AddRange(itemsList.ToArray());
            cbItems.DisplayMember = "Name";
            cbItems.SelectedItem = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Close();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            int selectedCreature1Id = (int)dgvCreatures1.SelectedRows[0].Cells[0].Value;
            int selectedCreature2Id = (int)dgvCreatures2.SelectedRows[0].Cells[0].Value;
            Creature selectedCreature = creatureCtr.getCreatureById(selectedCreature1Id);
            Creature selectedCreature2 = creatureCtr.getCreatureById(selectedCreature2Id);
            if (selectedCreature != null && selectedCreature2 != null)
            {
                selectedCreature.Attack(selectedCreature2);
                MessageBox.Show("Se pudo atacar a la criatura correctamente");
            }
        }

        private void btnUseItem_Click(object sender, EventArgs e)
        {
            int selectedCreatureId = -1; // Inicializa con un valor que no sea un ID válido
            Item selectedItem = (Item)cbItems.SelectedItem;
            int selectedItemId = selectedItem.getItemId();
            IInteractable item = itemCtr.getItemById(selectedItemId);
            if (dgvCreatures1.SelectedRows.Count > 0)
            {
                selectedCreatureId = (int)dgvCreatures1.SelectedRows[0].Cells[0].Value;
            }
            else if (dgvCreatures2.SelectedRows.Count > 0)
            {
                selectedCreatureId = (int)dgvCreatures2.SelectedRows[0].Cells[0].Value;
            }

            if (selectedCreatureId != -1)
            {
                Creature selectedCreature = creatureCtr.getCreatureById(selectedCreatureId);
                item.Interact(selectedCreature);
            }
            else
            {
                MessageBox.Show("Selecciona una criatura");
            }
        }
    }
}
