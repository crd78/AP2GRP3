
namespace APPGSB
{
    partial class WorkFlow
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
            this.lv_medicament = new System.Windows.Forms.ListView();
            this.num_etape = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.libelléétape = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datedécision = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.libelledecision = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numnorme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datenorme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_medicament
            // 
            this.lv_medicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lv_medicament.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num_etape,
            this.libelléétape,
            this.datedécision,
            this.libelledecision,
            this.numnorme,
            this.datenorme});
            this.lv_medicament.HideSelection = false;
            this.lv_medicament.Location = new System.Drawing.Point(124, 196);
            this.lv_medicament.Name = "lv_medicament";
            this.lv_medicament.Size = new System.Drawing.Size(814, 273);
            this.lv_medicament.TabIndex = 0;
            this.lv_medicament.UseCompatibleStateImageBehavior = false;
            this.lv_medicament.View = System.Windows.Forms.View.Details;
            // 
            // num_etape
            // 
            this.num_etape.Text = "Numéro de l\'étape";
            this.num_etape.Width = 130;
            // 
            // libelléétape
            // 
            this.libelléétape.Text = "Libellé de l\'étape";
            this.libelléétape.Width = 120;
            // 
            // datedécision
            // 
            this.datedécision.Text = "Date de la décision";
            this.datedécision.Width = 140;
            // 
            // libelledecision
            // 
            this.libelledecision.Text = "Libellé de la décision";
            this.libelledecision.Width = 140;
            // 
            // numnorme
            // 
            this.numnorme.Text = "Numéro de la norme";
            this.numnorme.Width = 140;
            // 
            // datenorme
            // 
            this.datenorme.Text = "Date de la norme";
            this.datenorme.Width = 140;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(472, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(304, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(242, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Médicament existant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "WorkFlow des étapes";
            // 
            // WorkFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lv_medicament);
            this.Name = "WorkFlow";
            this.Text = "WorkFlow";
            this.Load += new System.EventHandler(this.WorkFlow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_medicament;
        private System.Windows.Forms.ColumnHeader num_etape;
        private System.Windows.Forms.ColumnHeader libelléétape;
        private System.Windows.Forms.ColumnHeader datedécision;
        private System.Windows.Forms.ColumnHeader libelledecision;
        private System.Windows.Forms.ColumnHeader numnorme;
        private System.Windows.Forms.ColumnHeader datenorme;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}