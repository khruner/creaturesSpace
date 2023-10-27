namespace animalSpace.Forms
{
    partial class FormDiet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDietName = new System.Windows.Forms.TextBox();
            this.dgvDiets = new System.Windows.Forms.DataGridView();
            this.btnCreateDiet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteDiet = new System.Windows.Forms.Button();
            this.btnModifyDiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiets)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creating diet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diet\'s name";
            // 
            // tbDietName
            // 
            this.tbDietName.Location = new System.Drawing.Point(85, 48);
            this.tbDietName.Name = "tbDietName";
            this.tbDietName.Size = new System.Drawing.Size(100, 20);
            this.tbDietName.TabIndex = 2;
            // 
            // dgvDiets
            // 
            this.dgvDiets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiets.Location = new System.Drawing.Point(208, 48);
            this.dgvDiets.Name = "dgvDiets";
            this.dgvDiets.Size = new System.Drawing.Size(374, 150);
            this.dgvDiets.TabIndex = 3;
            // 
            // btnCreateDiet
            // 
            this.btnCreateDiet.Location = new System.Drawing.Point(613, 205);
            this.btnCreateDiet.Name = "btnCreateDiet";
            this.btnCreateDiet.Size = new System.Drawing.Size(75, 23);
            this.btnCreateDiet.TabIndex = 4;
            this.btnCreateDiet.Text = "Create diet";
            this.btnCreateDiet.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current diets";
            // 
            // btnDeleteDiet
            // 
            this.btnDeleteDiet.Location = new System.Drawing.Point(613, 48);
            this.btnDeleteDiet.Name = "btnDeleteDiet";
            this.btnDeleteDiet.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDiet.TabIndex = 6;
            this.btnDeleteDiet.Text = "Delete diet";
            this.btnDeleteDiet.UseVisualStyleBackColor = true;
            // 
            // btnModifyDiet
            // 
            this.btnModifyDiet.Location = new System.Drawing.Point(506, 12);
            this.btnModifyDiet.Name = "btnModifyDiet";
            this.btnModifyDiet.Size = new System.Drawing.Size(75, 23);
            this.btnModifyDiet.TabIndex = 7;
            this.btnModifyDiet.Text = "Modify diet";
            this.btnModifyDiet.UseVisualStyleBackColor = true;
            // 
            // FormDiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 240);
            this.Controls.Add(this.btnModifyDiet);
            this.Controls.Add(this.btnDeleteDiet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreateDiet);
            this.Controls.Add(this.dgvDiets);
            this.Controls.Add(this.tbDietName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDiet";
            this.Text = "FormDiet";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDietName;
        private System.Windows.Forms.DataGridView dgvDiets;
        private System.Windows.Forms.Button btnCreateDiet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteDiet;
        private System.Windows.Forms.Button btnModifyDiet;
    }
}