using animalSpace.Controllers;
using animalSpace.Interfaces;
using animalSpace.Model.Environments;
using animalSpace.Model.InteractablesAndItems;
using animalSpace.Model.InteractablesAndItems.ItemStrategies;
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
    public partial class FormItems : Form
    {
        ControllerItem ctrItem = ControllerItem.getInstance();
        public FormItems()
        {
            InitializeComponent();
            addItemsToLbEffects();
        }
        public void addItemsToLbEffects()
        {
            lbEffects.Items.Add(new IncreaseAttack());
            lbEffects.Items.Add(new IncreaseDefense());
            lbEffects.Items.Add(new ReduceAttack());
            lbEffects.Items.Add(new ReduceDefense());
            lbEffects.SelectedIndex = 0;
            lbEffects.SelectionMode = SelectionMode.MultiSimple;
        }

        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            List<IStrategyEffect> selectedStrategies = selectedEffectsInListbox();
            ctrItem.createItem(tbItemName.Text, selectedStrategies);
            loadDgvItems();
        }

        private List<IStrategyEffect> selectedEffectsInListbox()
        {
            List<IStrategyEffect> itemsInListbox = new List<IStrategyEffect>();
            foreach (IStrategyEffect effect in lbEffects.SelectedItems)
            {
                itemsInListbox.Add(effect);
            }
            return itemsInListbox;

        }

        private void loadDgvItems()
        {
            List<Item> itemsList = ctrItem.getItems();
            dgvItems.Rows.Clear();
            foreach (Item item in itemsList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvItems,
                    item.ToString(),
                    item.getEffectsString());
                dgvItems.Rows.Add(row);
            }
        }
    }
}
