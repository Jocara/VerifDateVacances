namespace Validation_dates_vancances_solaires
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textDepartement = new System.Windows.Forms.TextBox();
            this.btnValidation = new System.Windows.Forms.Button();
            this.groupBoxDepartement = new System.Windows.Forms.GroupBox();
            this.labelErreurDepartement = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelZone = new System.Windows.Forms.Label();
            this.labelNomDepartement = new System.Windows.Forms.Label();
            this.labelNumeroDepartement = new System.Windows.Forms.Label();
            this.dateDebutResa = new System.Windows.Forms.DateTimePicker();
            this.TexBoxNbrNuitees = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelErreurNbrNuitees = new System.Windows.Forms.Label();
            this.labelDateFinResa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelResultat = new System.Windows.Forms.Label();
            this.groupBoxDepartement.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textDepartement
            // 
            this.textDepartement.Location = new System.Drawing.Point(124, 23);
            this.textDepartement.Name = "textDepartement";
            this.textDepartement.Size = new System.Drawing.Size(40, 23);
            this.textDepartement.TabIndex = 0;
            this.textDepartement.TextChanged += new System.EventHandler(this.CheckInfoDépartment);
            this.textDepartement.Leave += new System.EventHandler(this.GetInfoDépartment);
            // 
            // btnValidation
            // 
            this.btnValidation.Location = new System.Drawing.Point(368, 221);
            this.btnValidation.Name = "btnValidation";
            this.btnValidation.Size = new System.Drawing.Size(209, 47);
            this.btnValidation.TabIndex = 1;
            this.btnValidation.Text = "Valider";
            this.btnValidation.UseVisualStyleBackColor = true;
            this.btnValidation.Click += new System.EventHandler(this.btnValidation_Click);
            // 
            // groupBoxDepartement
            // 
            this.groupBoxDepartement.Controls.Add(this.labelErreurDepartement);
            this.groupBoxDepartement.Controls.Add(this.label2);
            this.groupBoxDepartement.Controls.Add(this.label1);
            this.groupBoxDepartement.Controls.Add(this.labelZone);
            this.groupBoxDepartement.Controls.Add(this.labelNomDepartement);
            this.groupBoxDepartement.Controls.Add(this.textDepartement);
            this.groupBoxDepartement.Controls.Add(this.labelNumeroDepartement);
            this.groupBoxDepartement.Location = new System.Drawing.Point(28, 12);
            this.groupBoxDepartement.Name = "groupBoxDepartement";
            this.groupBoxDepartement.Size = new System.Drawing.Size(303, 164);
            this.groupBoxDepartement.TabIndex = 3;
            this.groupBoxDepartement.TabStop = false;
            this.groupBoxDepartement.Text = "Département";
            // 
            // labelErreurDepartement
            // 
            this.labelErreurDepartement.AutoSize = true;
            this.labelErreurDepartement.ForeColor = System.Drawing.Color.Red;
            this.labelErreurDepartement.Location = new System.Drawing.Point(38, 125);
            this.labelErreurDepartement.Name = "labelErreurDepartement";
            this.labelErreurDepartement.Size = new System.Drawing.Size(38, 15);
            this.labelErreurDepartement.TabIndex = 7;
            this.labelErreurDepartement.Text = "Erreur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom";
            // 
            // labelZone
            // 
            this.labelZone.AutoSize = true;
            this.labelZone.Location = new System.Drawing.Point(124, 96);
            this.labelZone.Name = "labelZone";
            this.labelZone.Size = new System.Drawing.Size(34, 15);
            this.labelZone.TabIndex = 4;
            this.labelZone.Text = "Zone";
            // 
            // labelNomDepartement
            // 
            this.labelNomDepartement.AutoSize = true;
            this.labelNomDepartement.Location = new System.Drawing.Point(124, 64);
            this.labelNomDepartement.Name = "labelNomDepartement";
            this.labelNomDepartement.Size = new System.Drawing.Size(34, 15);
            this.labelNomDepartement.TabIndex = 3;
            this.labelNomDepartement.Text = "Nom";
            // 
            // labelNumeroDepartement
            // 
            this.labelNumeroDepartement.AutoSize = true;
            this.labelNumeroDepartement.Location = new System.Drawing.Point(33, 26);
            this.labelNumeroDepartement.Name = "labelNumeroDepartement";
            this.labelNumeroDepartement.Size = new System.Drawing.Size(51, 15);
            this.labelNumeroDepartement.TabIndex = 2;
            this.labelNumeroDepartement.Text = "Numéro";
            // 
            // dateDebutResa
            // 
            this.dateDebutResa.Location = new System.Drawing.Point(177, 26);
            this.dateDebutResa.Name = "dateDebutResa";
            this.dateDebutResa.Size = new System.Drawing.Size(180, 23);
            this.dateDebutResa.TabIndex = 4;
            // 
            // TexBoxNbrNuitees
            // 
            this.TexBoxNbrNuitees.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TexBoxNbrNuitees.Location = new System.Drawing.Point(177, 59);
            this.TexBoxNbrNuitees.Name = "TexBoxNbrNuitees";
            this.TexBoxNbrNuitees.Size = new System.Drawing.Size(97, 23);
            this.TexBoxNbrNuitees.TabIndex = 5;
            this.TexBoxNbrNuitees.TextChanged += new System.EventHandler(this.PullDateFinResa);
            this.TexBoxNbrNuitees.Leave += new System.EventHandler(this.GetNbrNuitee);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre de nuitées";
            // 
            // labelErreurNbrNuitees
            // 
            this.labelErreurNbrNuitees.AutoSize = true;
            this.labelErreurNbrNuitees.ForeColor = System.Drawing.Color.Red;
            this.labelErreurNbrNuitees.Location = new System.Drawing.Point(20, 128);
            this.labelErreurNbrNuitees.Name = "labelErreurNbrNuitees";
            this.labelErreurNbrNuitees.Size = new System.Drawing.Size(98, 15);
            this.labelErreurNbrNuitees.TabIndex = 7;
            this.labelErreurNbrNuitees.Text = "ErreurNbrNuitees";
            // 
            // labelDateFinResa
            // 
            this.labelDateFinResa.AutoSize = true;
            this.labelDateFinResa.Location = new System.Drawing.Point(177, 99);
            this.labelDateFinResa.Name = "labelDateFinResa";
            this.labelDateFinResa.Size = new System.Drawing.Size(96, 15);
            this.labelDateFinResa.TabIndex = 8;
            this.labelDateFinResa.Text = "labelDateFinResa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelErreurNbrNuitees);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateDebutResa);
            this.groupBox1.Controls.Add(this.labelDateFinResa);
            this.groupBox1.Controls.Add(this.TexBoxNbrNuitees);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(368, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 165);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dates réservation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Début de la réservation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fin de la réservation";
            // 
            // labelResultat
            // 
            this.labelResultat.AutoSize = true;
            this.labelResultat.Location = new System.Drawing.Point(388, 184);
            this.labelResultat.Name = "labelResultat";
            this.labelResultat.Size = new System.Drawing.Size(74, 15);
            this.labelResultat.TabIndex = 10;
            this.labelResultat.Text = "labelResultat";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 327);
            this.Controls.Add(this.labelResultat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDepartement);
            this.Controls.Add(this.btnValidation);
            this.Name = "main";
            this.Text = "Validation des dates de vacances scolaire";
            this.groupBoxDepartement.ResumeLayout(false);
            this.groupBoxDepartement.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textDepartement;
        private Button btnValidation;
        private GroupBox groupBoxDepartement;
        private Label labelNomDepartement;
        private Label labelNumeroDepartement;
        private Label labelZone;
        private Label label2;
        private Label label1;
        private Label labelErreurDepartement;
        private DateTimePicker dateDebutResa;
        private TextBox TexBoxNbrNuitees;
        private Label label3;
        private Label labelErreurNbrNuitees;
        private Label labelDateFinResa;
        private GroupBox groupBox1;
        private Label label4;
        private Label label6;
        private Label labelResultat;
    }
}