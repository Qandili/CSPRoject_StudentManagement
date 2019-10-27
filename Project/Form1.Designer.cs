namespace Project
{
    partial class Form1
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
            this.tab = new System.Windows.Forms.TabControl();
            this.filiere = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filiere_name = new System.Windows.Forms.TextBox();
            this.Etudiant = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.message = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.filiere.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.filiere);
            this.tab.Controls.Add(this.Etudiant);
            this.tab.Location = new System.Drawing.Point(12, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(776, 426);
            this.tab.TabIndex = 0;
            // 
            // filiere
            // 
            this.filiere.Controls.Add(this.dataGridView1);
            this.filiere.Controls.Add(this.groupBox1);
            this.filiere.Location = new System.Drawing.Point(4, 22);
            this.filiere.Name = "filiere";
            this.filiere.Padding = new System.Windows.Forms.Padding(3);
            this.filiere.Size = new System.Drawing.Size(768, 400);
            this.filiere.TabIndex = 0;
            this.filiere.Text = "Filiere";
            this.filiere.UseVisualStyleBackColor = true;
            this.filiere.Click += new System.EventHandler(this.filiere_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.message);
            this.groupBox1.Controls.Add(this.Ajouter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.filiere_name);
            this.groupBox1.Location = new System.Drawing.Point(76, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 133);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AJouter une filiere";
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(182, 82);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 0;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom de filiere";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // filiere_name
            // 
            this.filiere_name.Location = new System.Drawing.Point(89, 40);
            this.filiere_name.Name = "filiere_name";
            this.filiere_name.Size = new System.Drawing.Size(168, 20);
            this.filiere_name.TabIndex = 2;
            // 
            // Etudiant
            // 
            this.Etudiant.Location = new System.Drawing.Point(4, 22);
            this.Etudiant.Name = "Etudiant";
            this.Etudiant.Padding = new System.Windows.Forms.Padding(3);
            this.Etudiant.Size = new System.Drawing.Size(768, 400);
            this.Etudiant.TabIndex = 1;
            this.Etudiant.Text = "Etudiant";
            this.Etudiant.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(430, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.ForeColor = System.Drawing.Color.Red;
            this.message.Location = new System.Drawing.Point(86, 63);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab.ResumeLayout(false);
            this.filiere.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage filiere;
        private System.Windows.Forms.TabPage Etudiant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filiere_name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label message;
    }
}

