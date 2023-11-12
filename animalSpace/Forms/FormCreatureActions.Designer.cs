namespace animalSpace.Forms
{
    partial class FormCreatureActions
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
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnUseItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAction = new System.Windows.Forms.Label();
            this.dgvCreaturesAffected = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAffectedObject = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.dgvCreatures1 = new System.Windows.Forms.DataGridView();
            this.dgvCreatures2 = new System.Windows.Forms.DataGridView();
            this.Creature1Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kingdom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Environment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Defensa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Health = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentEnergy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreaturesAffected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreatures1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreatures2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(383, 90);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(95, 23);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "Try to Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnUseItem
            // 
            this.btnUseItem.Location = new System.Drawing.Point(391, 149);
            this.btnUseItem.Name = "btnUseItem";
            this.btnUseItem.Size = new System.Drawing.Size(75, 23);
            this.btnUseItem.TabIndex = 1;
            this.btnUseItem.Text = "Use item";
            this.btnUseItem.UseVisualStyleBackColor = true;
            this.btnUseItem.Click += new System.EventHandler(this.btnUseItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Accion realizada:";
            // 
            // lbAction
            // 
            this.lbAction.AutoSize = true;
            this.lbAction.Location = new System.Drawing.Point(407, 48);
            this.lbAction.Name = "lbAction";
            this.lbAction.Size = new System.Drawing.Size(59, 13);
            this.lbAction.TabIndex = 6;
            this.lbAction.Text = "--ACCION--";
            // 
            // dgvCreaturesAffected
            // 
            this.dgvCreaturesAffected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreaturesAffected.Location = new System.Drawing.Point(31, 275);
            this.dgvCreaturesAffected.Name = "dgvCreaturesAffected";
            this.dgvCreaturesAffected.Size = new System.Drawing.Size(809, 150);
            this.dgvCreaturesAffected.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Objeto afectado";
            // 
            // lbAffectedObject
            // 
            this.lbAffectedObject.AutoSize = true;
            this.lbAffectedObject.Location = new System.Drawing.Point(134, 248);
            this.lbAffectedObject.Name = "lbAffectedObject";
            this.lbAffectedObject.Size = new System.Drawing.Size(60, 13);
            this.lbAffectedObject.TabIndex = 9;
            this.lbAffectedObject.Text = "--OBJECT--";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(765, 442);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Volver atras";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(366, 192);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(121, 21);
            this.cbItems.TabIndex = 4;
            // 
            // dgvCreatures1
            // 
            this.dgvCreatures1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreatures1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Creature1Id,
            this.CreatureName,
            this.Kingdom,
            this.Environment,
            this.Diet,
            this.Attack,
            this.Defensa,
            this.Health,
            this.CurrentEnergy});
            this.dgvCreatures1.Location = new System.Drawing.Point(12, 22);
            this.dgvCreatures1.Name = "dgvCreatures1";
            this.dgvCreatures1.Size = new System.Drawing.Size(365, 150);
            this.dgvCreatures1.TabIndex = 13;
            // 
            // dgvCreatures2
            // 
            this.dgvCreatures2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreatures2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvCreatures2.Location = new System.Drawing.Point(484, 22);
            this.dgvCreatures2.Name = "dgvCreatures2";
            this.dgvCreatures2.Size = new System.Drawing.Size(443, 150);
            this.dgvCreatures2.TabIndex = 14;
            // 
            // Creature1Id
            // 
            this.Creature1Id.HeaderText = "ID";
            this.Creature1Id.Name = "Creature1Id";
            this.Creature1Id.Visible = false;
            // 
            // CreatureName
            // 
            this.CreatureName.HeaderText = "Name";
            this.CreatureName.Name = "CreatureName";
            this.CreatureName.Width = 80;
            // 
            // Kingdom
            // 
            this.Kingdom.HeaderText = "Kingdom";
            this.Kingdom.Name = "Kingdom";
            this.Kingdom.Width = 80;
            // 
            // Environment
            // 
            this.Environment.HeaderText = "Environment";
            this.Environment.Name = "Environment";
            this.Environment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Environment.Width = 80;
            // 
            // Diet
            // 
            this.Diet.HeaderText = "Diet";
            this.Diet.Name = "Diet";
            this.Diet.Width = 80;
            // 
            // Attack
            // 
            this.Attack.HeaderText = "Attack";
            this.Attack.Name = "Attack";
            this.Attack.Width = 50;
            // 
            // Defensa
            // 
            this.Defensa.HeaderText = "Defense";
            this.Defensa.Name = "Defensa";
            this.Defensa.Width = 50;
            // 
            // Health
            // 
            this.Health.HeaderText = "Health";
            this.Health.Name = "Health";
            this.Health.Width = 50;
            // 
            // CurrentEnergy
            // 
            this.CurrentEnergy.HeaderText = "Energy";
            this.CurrentEnergy.Name = "CurrentEnergy";
            this.CurrentEnergy.Width = 50;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Kingdom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Environment";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Diet";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Attack";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Defense";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Health";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Energy";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // FormCreatureActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 477);
            this.Controls.Add(this.dgvCreatures2);
            this.Controls.Add(this.dgvCreatures1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbAffectedObject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCreaturesAffected);
            this.Controls.Add(this.lbAction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbItems);
            this.Controls.Add(this.btnUseItem);
            this.Controls.Add(this.btnAttack);
            this.Name = "FormCreatureActions";
            this.Text = "FormCreatureActions";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreaturesAffected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreatures1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreatures2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnUseItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAction;
        private System.Windows.Forms.DataGridView dgvCreaturesAffected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAffectedObject;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.DataGridView dgvCreatures1;
        private System.Windows.Forms.DataGridView dgvCreatures2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creature1Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kingdom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Environment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Defensa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Health;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentEnergy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}