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
            this.cbMedicament.Location = new System.Drawing.Point(50, 93);
            this.cbMedicament.Name = "cbMedicament";
            this.cbMedicament.Size = new System.Drawing.Size(340, 28);
            this.cbMedicament.TabIndex = 0;
            this.cbMedicament.SelectedIndexChanged += new System.EventHandler(this.cbMedicament_SelectedIndexChanged);
            // 
            // cbEtapes
            // 
            this.cbEtapes.FormattingEnabled = true;
            this.cbEtapes.Location = new System.Drawing.Point(434, 93);
            this.cbEtapes.Name = "cbEtapes";
            this.cbEtapes.Size = new System.Drawing.Size(668, 28);
            this.cbEtapes.TabIndex = 1;
            // 
            // cbDecision
            // 
            this.cbDecision.FormattingEnabled = true;
            this.cbDecision.Location = new System.Drawing.Point(50, 355);
            this.cbDecision.Name = "cbDecision";
            this.cbDecision.Size = new System.Drawing.Size(235, 28);
            this.cbDecision.TabIndex = 2;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(434, 357);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(328, 26);
            this.dtpDate.TabIndex = 3;
            // 
            // btSaisir
            // 
            this.btSaisir.Location = new System.Drawing.Point(285, 503);
            this.btSaisir.Name = "btSaisir";
            this.btSaisir.Size = new System.Drawing.Size(399, 111);
            this.btSaisir.TabIndex = 4;
            this.btSaisir.Text = "Saisir";
            this.btSaisir.UseVisualStyleBackColor = true;
            this.btSaisir.Click += new System.EventHandler(this.btSaisir_Click);
            // 
            // frmSaisieDecision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 683);
            this.Controls.Add(this.btSaisir);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbDecision);
            this.Controls.Add(this.cbEtapes);
            this.Controls.Add(this.cbMedicament);
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