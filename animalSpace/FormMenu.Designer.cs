namespace animalSpace
{
    partial class FormMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreatures = new System.Windows.Forms.Button();
            this.btnCreateItems = new System.Windows.Forms.Button();
            this.btnGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreatures
            // 
            this.btnCreatures.Location = new System.Drawing.Point(52, 36);
            this.btnCreatures.Name = "btnCreatures";
            this.btnCreatures.Size = new System.Drawing.Size(97, 23);
            this.btnCreatures.TabIndex = 0;
            this.btnCreatures.Text = "Crear criaturas";
            this.btnCreatures.UseVisualStyleBackColor = true;
            this.btnCreatures.Click += new System.EventHandler(this.btnCreatures_Click);
            // 
            // btnCreateItems
            // 
            this.btnCreateItems.Location = new System.Drawing.Point(52, 79);
            this.btnCreateItems.Name = "btnCreateItems";
            this.btnCreateItems.Size = new System.Drawing.Size(97, 23);
            this.btnCreateItems.TabIndex = 1;
            this.btnCreateItems.Text = "Crear items";
            this.btnCreateItems.UseVisualStyleBackColor = true;
            this.btnCreateItems.Click += new System.EventHandler(this.btnCreateItems_Click);
            // 
            // btnGame
            // 
            this.btnGame.Location = new System.Drawing.Point(52, 119);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(97, 37);
            this.btnGame.TabIndex = 2;
            this.btnGame.Text = "Acceder al Juego";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 197);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.btnCreateItems);
            this.Controls.Add(this.btnCreatures);
            this.Name = "FormMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreatures;
        private System.Windows.Forms.Button btnCreateItems;
        private System.Windows.Forms.Button btnGame;
    }
}

