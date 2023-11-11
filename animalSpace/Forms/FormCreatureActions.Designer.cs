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
            this.button1 = new System.Windows.Forms.Button();
            this.btnUseItem = new System.Windows.Forms.Button();
            this.cbCreatures1 = new System.Windows.Forms.ComboBox();
            this.cbCreatures2 = new System.Windows.Forms.ComboBox();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAction = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAffectedObject = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Try to Attack";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnUseItem
            // 
            this.btnUseItem.Location = new System.Drawing.Point(265, 161);
            this.btnUseItem.Name = "btnUseItem";
            this.btnUseItem.Size = new System.Drawing.Size(75, 23);
            this.btnUseItem.TabIndex = 1;
            this.btnUseItem.Text = "Use item";
            this.btnUseItem.UseVisualStyleBackColor = true;
            // 
            // cbCreatures1
            // 
            this.cbCreatures1.FormattingEnabled = true;
            this.cbCreatures1.Location = new System.Drawing.Point(97, 58);
            this.cbCreatures1.Name = "cbCreatures1";
            this.cbCreatures1.Size = new System.Drawing.Size(121, 21);
            this.cbCreatures1.TabIndex = 2;
            // 
            // cbCreatures2
            // 
            this.cbCreatures2.FormattingEnabled = true;
            this.cbCreatures2.Location = new System.Drawing.Point(373, 58);
            this.cbCreatures2.Name = "cbCreatures2";
            this.cbCreatures2.Size = new System.Drawing.Size(121, 21);
            this.cbCreatures2.TabIndex = 3;
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(240, 204);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(121, 21);
            this.cbItems.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Accion realizada:";
            // 
            // lbAction
            // 
            this.lbAction.AutoSize = true;
            this.lbAction.Location = new System.Drawing.Point(262, 61);
            this.lbAction.Name = "lbAction";
            this.lbAction.Size = new System.Drawing.Size(59, 13);
            this.lbAction.TabIndex = 6;
            this.lbAction.Text = "--ACCION--";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Objecto afectado";
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
            // FormCreatureActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 437);
            this.Controls.Add(this.lbAffectedObject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbAction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbItems);
            this.Controls.Add(this.cbCreatures2);
            this.Controls.Add(this.cbCreatures1);
            this.Controls.Add(this.btnUseItem);
            this.Controls.Add(this.button1);
            this.Name = "FormCreatureActions";
            this.Text = "FormCreatureActions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUseItem;
        private System.Windows.Forms.ComboBox cbCreatures1;
        private System.Windows.Forms.ComboBox cbCreatures2;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAction;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAffectedObject;
    }
}