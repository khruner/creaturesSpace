namespace animalSpace.Forms
{
    partial class FormCreatures
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
            this.lbCreateCreature = new System.Windows.Forms.Label();
            this.lbKingdom = new System.Windows.Forms.Label();
            this.cbCreatureKingdom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCreatureEnvironment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCreatureDiet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCreatureName = new System.Windows.Forms.TextBox();
            this.btnCreateCreature = new System.Windows.Forms.Button();
            this.dgvCreatures = new System.Windows.Forms.DataGridView();
            this.CreatureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kingdom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Environment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteCreature = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreatures)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCreateCreature
            // 
            this.lbCreateCreature.AutoSize = true;
            this.lbCreateCreature.Location = new System.Drawing.Point(13, 13);
            this.lbCreateCreature.Name = "lbCreateCreature";
            this.lbCreateCreature.Size = new System.Drawing.Size(137, 13);
            this.lbCreateCreature.TabIndex = 0;
            this.lbCreateCreature.Text = "You are creating a Creature";
            // 
            // lbKingdom
            // 
            this.lbKingdom.AutoSize = true;
            this.lbKingdom.Location = new System.Drawing.Point(12, 71);
            this.lbKingdom.Name = "lbKingdom";
            this.lbKingdom.Size = new System.Drawing.Size(147, 13);
            this.lbKingdom.TabIndex = 1;
            this.lbKingdom.Text = "Select the creature\'s kingdom";
            // 
            // cbCreatureKingdom
            // 
            this.cbCreatureKingdom.FormattingEnabled = true;
            this.cbCreatureKingdom.Location = new System.Drawing.Point(172, 71);
            this.cbCreatureKingdom.Name = "cbCreatureKingdom";
            this.cbCreatureKingdom.Size = new System.Drawing.Size(121, 21);
            this.cbCreatureKingdom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select the creature\'s environment";
            // 
            // cbCreatureEnvironment
            // 
            this.cbCreatureEnvironment.FormattingEnabled = true;
            this.cbCreatureEnvironment.Location = new System.Drawing.Point(184, 103);
            this.cbCreatureEnvironment.Name = "cbCreatureEnvironment";
            this.cbCreatureEnvironment.Size = new System.Drawing.Size(121, 21);
            this.cbCreatureEnvironment.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose your creature\'s diet";
            // 
            // cbCreatureDiet
            // 
            this.cbCreatureDiet.FormattingEnabled = true;
            this.cbCreatureDiet.Location = new System.Drawing.Point(165, 135);
            this.cbCreatureDiet.Name = "cbCreatureDiet";
            this.cbCreatureDiet.Size = new System.Drawing.Size(121, 21);
            this.cbCreatureDiet.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Choose your creature\'s Name!";
            // 
            // tbCreatureName
            // 
            this.tbCreatureName.Location = new System.Drawing.Point(172, 43);
            this.tbCreatureName.Name = "tbCreatureName";
            this.tbCreatureName.Size = new System.Drawing.Size(100, 20);
            this.tbCreatureName.TabIndex = 8;
            // 
            // btnCreateCreature
            // 
            this.btnCreateCreature.Location = new System.Drawing.Point(16, 170);
            this.btnCreateCreature.Name = "btnCreateCreature";
            this.btnCreateCreature.Size = new System.Drawing.Size(128, 23);
            this.btnCreateCreature.TabIndex = 9;
            this.btnCreateCreature.Text = "Create your Creature!";
            this.btnCreateCreature.UseVisualStyleBackColor = true;
            this.btnCreateCreature.Click += new System.EventHandler(this.btnCreateCreature_Click);
            // 
            // dgvCreatures
            // 
            this.dgvCreatures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreatures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CreatureName,
            this.Kingdom,
            this.Environment,
            this.Diet});
            this.dgvCreatures.Location = new System.Drawing.Point(346, 43);
            this.dgvCreatures.Name = "dgvCreatures";
            this.dgvCreatures.Size = new System.Drawing.Size(443, 150);
            this.dgvCreatures.TabIndex = 10;
            // 
            // CreatureName
            // 
            this.CreatureName.Frozen = true;
            this.CreatureName.HeaderText = "Name";
            this.CreatureName.Name = "CreatureName";
            // 
            // Kingdom
            // 
            this.Kingdom.Frozen = true;
            this.Kingdom.HeaderText = "Kingdom";
            this.Kingdom.Name = "Kingdom";
            // 
            // Environment
            // 
            this.Environment.Frozen = true;
            this.Environment.HeaderText = "Environment";
            this.Environment.Name = "Environment";
            // 
            // Diet
            // 
            this.Diet.Frozen = true;
            this.Diet.HeaderText = "Diet";
            this.Diet.Name = "Diet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Created creatures";
            // 
            // btnDeleteCreature
            // 
            this.btnDeleteCreature.Location = new System.Drawing.Point(815, 169);
            this.btnDeleteCreature.Name = "btnDeleteCreature";
            this.btnDeleteCreature.Size = new System.Drawing.Size(93, 23);
            this.btnDeleteCreature.TabIndex = 12;
            this.btnDeleteCreature.Text = "Delete creature";
            this.btnDeleteCreature.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(815, 46);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(93, 23);
            this.btnModify.TabIndex = 13;
            this.btnModify.Text = "Modify creature";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // FormCreatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 212);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDeleteCreature);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCreatures);
            this.Controls.Add(this.btnCreateCreature);
            this.Controls.Add(this.tbCreatureName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCreatureDiet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCreatureEnvironment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCreatureKingdom);
            this.Controls.Add(this.lbKingdom);
            this.Controls.Add(this.lbCreateCreature);
            this.Name = "FormCreatures";
            this.Text = "FormCreatures";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreatures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCreateCreature;
        private System.Windows.Forms.Label lbKingdom;
        private System.Windows.Forms.ComboBox cbCreatureKingdom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCreatureEnvironment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCreatureDiet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCreatureName;
        private System.Windows.Forms.Button btnCreateCreature;
        private System.Windows.Forms.DataGridView dgvCreatures;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteCreature;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kingdom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Environment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diet;
    }
}