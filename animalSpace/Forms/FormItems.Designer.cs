namespace animalSpace.Forms
{
    partial class FormItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateItem = new System.Windows.Forms.Button();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.lbItemName = new System.Windows.Forms.Label();
            this.lbItemEffects = new System.Windows.Forms.Label();
            this.lbItem = new System.Windows.Forms.Label();
            this.lbEffects = new System.Windows.Forms.ListBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Effects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateItem
            // 
            this.btnCreateItem.Location = new System.Drawing.Point(24, 225);
            this.btnCreateItem.Name = "btnCreateItem";
            this.btnCreateItem.Size = new System.Drawing.Size(75, 23);
            this.btnCreateItem.TabIndex = 0;
            this.btnCreateItem.Text = "Create";
            this.btnCreateItem.UseVisualStyleBackColor = true;
            this.btnCreateItem.Click += new System.EventHandler(this.btnCreateItem_Click);
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(93, 73);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(100, 20);
            this.tbItemName.TabIndex = 1;
            // 
            // lbItemName
            // 
            this.lbItemName.AutoSize = true;
            this.lbItemName.Location = new System.Drawing.Point(36, 76);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(35, 13);
            this.lbItemName.TabIndex = 2;
            this.lbItemName.Text = "Name";
            // 
            // lbItemEffects
            // 
            this.lbItemEffects.AutoSize = true;
            this.lbItemEffects.Location = new System.Drawing.Point(36, 112);
            this.lbItemEffects.Name = "lbItemEffects";
            this.lbItemEffects.Size = new System.Drawing.Size(40, 13);
            this.lbItemEffects.TabIndex = 3;
            this.lbItemEffects.Text = "Effects";
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Location = new System.Drawing.Point(39, 28);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(115, 13);
            this.lbItem.TabIndex = 4;
            this.lbItem.Text = "You\'re creating an item";
            // 
            // lbEffects
            // 
            this.lbEffects.FormattingEnabled = true;
            this.lbEffects.Location = new System.Drawing.Point(93, 112);
            this.lbEffects.Name = "lbEffects";
            this.lbEffects.Size = new System.Drawing.Size(120, 95);
            this.lbEffects.TabIndex = 5;
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.Effects});
            this.dgvItems.Location = new System.Drawing.Point(219, 28);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(402, 150);
            this.dgvItems.TabIndex = 6;
            // 
            // item
            // 
            this.item.HeaderText = "Name";
            this.item.Name = "item";
            // 
            // Effects
            // 
            this.Effects.HeaderText = "Effects";
            this.Effects.Name = "Effects";
            // 
            // FormItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 261);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.lbEffects);
            this.Controls.Add(this.lbItem);
            this.Controls.Add(this.lbItemEffects);
            this.Controls.Add(this.lbItemName);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.btnCreateItem);
            this.Name = "FormItems";
            this.Text = "FormItems";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateItem;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label lbItemName;
        private System.Windows.Forms.Label lbItemEffects;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.ListBox lbEffects;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Effects;
    }
}