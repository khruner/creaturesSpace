using animalSpace.Controllers;
using animalSpace.Interfaces;
using animalSpace.Model;
using animalSpace.Model.Diets;
using animalSpace.Model.Environments;
using animalSpace.Model.Kingdoms;
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
            cbCreatureDiet.Items.Add(new CarnivorousDiet());
            cbCreatureDiet.Items.Add(new HerviborousDiet());
            cbCreatureDiet.Items.Add(new OmnivorousDiet());
            cbCreatureDiet.SelectedIndex = 0;
            cbCreatureDiet.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void addItemsToCbCreatureEnvironment()
        {
            /*Environment terrestrial = new Environment("Terrestrial");
            Environment Aero = new Environment("Aero");
            Environment Acuatic = new Environment("Acuatic");*/
            listBoxEnvironments.Items.Add(new Terrestrial());
            listBoxEnvironments.Items.Add(new Aerial());
            listBoxEnvironments.Items.Add(new Aquatic());
            listBoxEnvironments.SelectedIndex = 0;
            listBoxEnvironments.SelectionMode = SelectionMode.MultiSimple;
        }

        public void addItemsToCbCreatureKingdom()
        {
            cbCreatureKingdom.Items.Add(new AnimalKingdom());
            cbCreatureKingdom.Items.Add(new MytholigicKingdom());
            cbCreatureKingdom.Items.Add(new MachineKingdom());
            cbCreatureKingdom.SelectedIndex = 0;
            cbCreatureKingdom.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCreateCreature_Click(object sender, EventArgs e)
        {
            List<IEnvironment> selectedEnvironments = selectedEnvironmentsInListbox();
            ctrCreature.createCreature(tbCreatureName.Text,
                (IDiet)cbCreatureDiet.SelectedItem, 
                (IKingdom)cbCreatureKingdom.SelectedItem,
                selectedEnvironments);
            loadDgvCreatures();
        }

        private List<IEnvironment> selectedEnvironmentsInListbox() 
        {
            List<IEnvironment> itemsInListbox = new List<IEnvironment>();
            foreach (IEnvironment environment in listBoxEnvironments.SelectedItems) 
            {
                itemsInListbox.Add(environment);
            }
            return itemsInListbox;
        }

        public void loadDgvCreatures()
        {
            List<Creature> listCreatures = ctrCreature.getCreatures();
            dgvCreatures.Rows.Clear();
            foreach (var creature in listCreatures)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvCreatures, creature.getCreatureName(), creature.getCreatureKingdom(), creature.CompatibleEnvironments(), creature.getCreatureDiet());
                dgvCreatures.Rows.Add(row);
            }
        }


    
    }
}
