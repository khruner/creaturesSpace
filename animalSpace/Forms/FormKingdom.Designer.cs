namespace animalSpace.Forms
{
    partial class FormKingdom
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
            this.lbKingdomName = new System.Windows.Forms.Label();
            this.tbKingdomName = new System.Windows.Forms.TextBox();
            this.dgvKingdoms = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateKingdom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKingdoms)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "You\'re creating creature\'s kingdoms";
            // 
            // lbKingdomName
            // 
            this.lbKingdomName.AutoSize = true;
            this.lbKingdomName.Location = new System.Drawing.Point(13, 50);
            this.lbKingdomName.Name = "lbKingdomName";
            this.lbKingdomName.Size = new System.Drawing.Size(84, 13);
            this.lbKingdomName.TabIndex = 1;
            this.lbKingdomName.Text = "Kingdom\'s name";
            // 
            // tbKingdomName
            // 
            this.tbKingdomName.Location = new System.Drawing.Point(104, 50);
            this.tbKingdomName.Name = "tbKingdomName";
            this.tbKingdomName.Size = new System.Drawing.Size(100, 20);
            this.tbKingdomName.TabIndex = 2;
            // 
            // dgvKingdoms
            // 
            this.dgvKingdoms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKingdoms.Location = new System.Drawing.Point(273, 38);
            this.dgvKingdoms.Name = "dgvKingdoms";
            this.dgvKingdoms.Size = new System.Drawing.Size(304, 150);
            this.dgvKingdoms.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Already created kingdoms";
            // 
            // btnCreateKingdom
            // 
            this.btnCreateKingdom.Location = new System.Drawing.Point(477, 210);
            this.btnCreateKingdom.Name = "btnCreateKingdom";
            this.btnCreateKingdom.Size = new System.Drawing.Size(100, 23);
            this.btnCreateKingdom.TabIndex = 5;
            this.btnCreateKingdom.Text = "Create kingdom";
            this.btnCreateKingdom.UseVisualStyleBackColor = true;
            // 
            // FormKingdom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 245);
            this.Controls.Add(this.btnCreateKingdom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvKingdoms);
            this.Controls.Add(this.tbKingdomName);
            this.Controls.Add(this.lbKingdomName);
            this.Controls.Add(this.label1);
            this.Name = "FormKingdom";
            this.Text = "FormKingdom";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKingdoms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbKingdomName;
        private System.Windows.Forms.TextBox tbKingdomName;
        private System.Windows.Forms.DataGridView dgvKingdoms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateKingdom;
    }
}