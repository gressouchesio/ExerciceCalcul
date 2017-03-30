namespace SIO1_ProfDeCalcul
{
    partial class frmJeu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnJouer = new System.Windows.Forms.Button();
            this.rbtnL1 = new System.Windows.Forms.RadioButton();
            this.rbtnL2 = new System.Windows.Forms.RadioButton();
            this.rbtnL3 = new System.Windows.Forms.RadioButton();
            this.grpSolutions = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblExercice = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSolutions.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJouer
            // 
            this.btnJouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJouer.Location = new System.Drawing.Point(68, 72);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(230, 34);
            this.btnJouer.TabIndex = 0;
            this.btnJouer.Text = "JOUER";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // rbtnL1
            // 
            this.rbtnL1.AutoSize = true;
            this.rbtnL1.Location = new System.Drawing.Point(20, 19);
            this.rbtnL1.Name = "rbtnL1";
            this.rbtnL1.Size = new System.Drawing.Size(14, 13);
            this.rbtnL1.TabIndex = 1;
            this.rbtnL1.TabStop = true;
            this.rbtnL1.UseVisualStyleBackColor = true;
            // 
            // rbtnL2
            // 
            this.rbtnL2.AutoSize = true;
            this.rbtnL2.Location = new System.Drawing.Point(20, 48);
            this.rbtnL2.Name = "rbtnL2";
            this.rbtnL2.Size = new System.Drawing.Size(14, 13);
            this.rbtnL2.TabIndex = 2;
            this.rbtnL2.TabStop = true;
            this.rbtnL2.UseVisualStyleBackColor = true;
            // 
            // rbtnL3
            // 
            this.rbtnL3.AutoSize = true;
            this.rbtnL3.Location = new System.Drawing.Point(20, 81);
            this.rbtnL3.Name = "rbtnL3";
            this.rbtnL3.Size = new System.Drawing.Size(14, 13);
            this.rbtnL3.TabIndex = 3;
            this.rbtnL3.TabStop = true;
            this.rbtnL3.UseVisualStyleBackColor = true;
            // 
            // grpSolutions
            // 
            this.grpSolutions.Controls.Add(this.rbtnL1);
            this.grpSolutions.Controls.Add(this.rbtnL3);
            this.grpSolutions.Controls.Add(this.rbtnL2);
            this.grpSolutions.Location = new System.Drawing.Point(68, 218);
            this.grpSolutions.Name = "grpSolutions";
            this.grpSolutions.Size = new System.Drawing.Size(230, 115);
            this.grpSolutions.TabIndex = 4;
            this.grpSolutions.TabStop = false;
            this.grpSolutions.Text = "Solution";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(68, 379);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(230, 44);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblExercice
            // 
            this.lblExercice.AutoSize = true;
            this.lblExercice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExercice.Location = new System.Drawing.Point(73, 152);
            this.lblExercice.Name = "lblExercice";
            this.lblExercice.Size = new System.Drawing.Size(0, 24);
            this.lblExercice.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // frmJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 455);
            this.Controls.Add(this.lblExercice);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpSolutions);
            this.Controls.Add(this.btnJouer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmJeu";
            this.Text = "Prof de calcul";
            this.Load += new System.EventHandler(this.frmJeu_Load);
            this.grpSolutions.ResumeLayout(false);
            this.grpSolutions.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJouer;
        private System.Windows.Forms.RadioButton rbtnL1;
        private System.Windows.Forms.RadioButton rbtnL2;
        private System.Windows.Forms.RadioButton rbtnL3;
        private System.Windows.Forms.GroupBox grpSolutions;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblExercice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

