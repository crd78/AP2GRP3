namespace APPGSB
{
    partial class frmEtapesNormees
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
            this.lvEtp = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btModif = new System.Windows.Forms.Button();
            this.lbEtp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNorme = new System.Windows.Forms.TextBox();
            this.tbDateNorme = new System.Windows.Forms.TextBox();
            this.btValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvEtp
            // 
            this.lvEtp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvEtp.HideSelection = false;
            this.lvEtp.Location = new System.Drawing.Point(142, 24);
            this.lvEtp.Name = "lvEtp";
            this.lvEtp.Size = new System.Drawing.Size(1034, 426);
            this.lvEtp.TabIndex = 0;
            this.lvEtp.UseCompatibleStateImageBehavior = false;
            this.lvEtp.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numero";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Libelle";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Norme";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date Norme";
            this.columnHeader4.Width = 100;
            // 
            // btModif
            // 
            this.btModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModif.Location = new System.Drawing.Point(306, 466);
            this.btModif.Name = "btModif";
            this.btModif.Size = new System.Drawing.Size(626, 84);
            this.btModif.TabIndex = 1;
            this.btModif.Text = "Modifier";
            this.btModif.UseVisualStyleBackColor = true;
            this.btModif.Click += new System.EventHandler(this.btModif_Click);
            // 
            // lbEtp
            // 
            this.lbEtp.AutoSize = true;
            this.lbEtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEtp.Location = new System.Drawing.Point(300, 592);
            this.lbEtp.Name = "lbEtp";
            this.lbEtp.Size = new System.Drawing.Size(299, 32);
            this.lbEtp.TabIndex = 2;
            this.lbEtp.Text = "Sélectionne une étape";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 679);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Norme : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 737);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date Norme : ";
            // 
            // tbNorme
            // 
            this.tbNorme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNorme.Location = new System.Drawing.Point(306, 672);
            this.tbNorme.Name = "tbNorme";
            this.tbNorme.Size = new System.Drawing.Size(626, 39);
            this.tbNorme.TabIndex = 5;
            // 
            // tbDateNorme
            // 
            this.tbDateNorme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateNorme.Location = new System.Drawing.Point(306, 737);
            this.tbDateNorme.Name = "tbDateNorme";
            this.tbDateNorme.Size = new System.Drawing.Size(626, 39);
            this.tbDateNorme.TabIndex = 6;
            // 
            // btValider
            // 
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(964, 672);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(253, 104);
            this.btValider.TabIndex = 7;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // frmEtapesNormees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 815);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.tbDateNorme);
            this.Controls.Add(this.tbNorme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEtp);
            this.Controls.Add(this.btModif);
            this.Controls.Add(this.lvEtp);
            this.Name = "frmEtapesNormees";
            this.Text = "frmEtapesNormees";
            this.Load += new System.EventHandler(this.frmEtapesNormees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvEtp;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btModif;
        private System.Windows.Forms.Label lbEtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNorme;
        private System.Windows.Forms.TextBox tbDateNorme;
        private System.Windows.Forms.Button btValider;
    }
}