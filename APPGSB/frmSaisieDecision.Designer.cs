namespace APPGSB
{
    partial class frmSaisieDecision
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
            this.cbMedicament = new System.Windows.Forms.ComboBox();
            this.cbEtapes = new System.Windows.Forms.ComboBox();
            this.cbDecision = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btSaisir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbMedicament
            // 
            this.cbMedicament.FormattingEnabled = true;
            this.cbMedicament.Location = new System.Drawing.Point(44, 74);
            this.cbMedicament.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMedicament.Name = "cbMedicament";
            this.cbMedicament.Size = new System.Drawing.Size(303, 24);
            this.cbMedicament.TabIndex = 0;
            this.cbMedicament.SelectedIndexChanged += new System.EventHandler(this.cbMedicament_SelectedIndexChanged);
            // 
            // cbEtapes
            // 
            this.cbEtapes.FormattingEnabled = true;
            this.cbEtapes.Location = new System.Drawing.Point(386, 74);
            this.cbEtapes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEtapes.Name = "cbEtapes";
            this.cbEtapes.Size = new System.Drawing.Size(594, 24);
            this.cbEtapes.TabIndex = 1;
            this.cbEtapes.SelectedIndexChanged += new System.EventHandler(this.cbEtapes_SelectedIndexChanged);
            // 
            // cbDecision
            // 
            this.cbDecision.FormattingEnabled = true;
            this.cbDecision.Location = new System.Drawing.Point(44, 284);
            this.cbDecision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDecision.Name = "cbDecision";
            this.cbDecision.Size = new System.Drawing.Size(209, 24);
            this.cbDecision.TabIndex = 2;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(386, 286);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(292, 22);
            this.dtpDate.TabIndex = 3;
            // 
            // btSaisir
            // 
            this.btSaisir.Location = new System.Drawing.Point(253, 402);
            this.btSaisir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSaisir.Name = "btSaisir";
            this.btSaisir.Size = new System.Drawing.Size(355, 89);
            this.btSaisir.TabIndex = 4;
            this.btSaisir.Text = "Saisir";
            this.btSaisir.UseVisualStyleBackColor = true;
            this.btSaisir.Click += new System.EventHandler(this.btSaisir_Click);
            // 
            // frmSaisieDecision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 546);
            this.Controls.Add(this.btSaisir);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbDecision);
            this.Controls.Add(this.cbEtapes);
            this.Controls.Add(this.cbMedicament);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSaisieDecision";
            this.Text = "frmSaisieDecision";
            this.Load += new System.EventHandler(this.frmSaisieDecision_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMedicament;
        private System.Windows.Forms.ComboBox cbEtapes;
        private System.Windows.Forms.ComboBox cbDecision;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btSaisir;
    }
}