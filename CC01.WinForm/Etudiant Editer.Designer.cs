
namespace CC01.WinForm
{
    partial class Ecole
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
            this.btnsave = new System.Windows.Forms.Button();
            this.txtecole = new System.Windows.Forms.TextBox();
            this.lbecole = new System.Windows.Forms.Label();
            this.lbnom = new System.Windows.Forms.Label();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.lbprenom = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.lbcontact = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.lbdatedenaissance = new System.Windows.Forms.Label();
            this.txtdatedenaissance = new System.Windows.Forms.TextBox();
            this.lbmatricule = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmatricule = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(587, 335);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(78, 46);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // txtecole
            // 
            this.txtecole.Location = new System.Drawing.Point(547, 212);
            this.txtecole.Name = "txtecole";
            this.txtecole.Size = new System.Drawing.Size(167, 20);
            this.txtecole.TabIndex = 20;
            // 
            // lbecole
            // 
            this.lbecole.AutoSize = true;
            this.lbecole.Location = new System.Drawing.Point(543, 180);
            this.lbecole.Name = "lbecole";
            this.lbecole.Size = new System.Drawing.Size(34, 13);
            this.lbecole.TabIndex = 27;
            this.lbecole.Text = "Ecole";
            // 
            // lbnom
            // 
            this.lbnom.AutoSize = true;
            this.lbnom.Location = new System.Drawing.Point(87, 180);
            this.lbnom.Name = "lbnom";
            this.lbnom.Size = new System.Drawing.Size(29, 13);
            this.lbnom.TabIndex = 26;
            this.lbnom.Text = "Nom";
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(321, 135);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(167, 20);
            this.txtprenom.TabIndex = 16;
            // 
            // lbprenom
            // 
            this.lbprenom.AutoSize = true;
            this.lbprenom.Location = new System.Drawing.Point(317, 97);
            this.lbprenom.Name = "lbprenom";
            this.lbprenom.Size = new System.Drawing.Size(43, 13);
            this.lbprenom.TabIndex = 25;
            this.lbprenom.Text = "Prenom";
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(321, 212);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(167, 20);
            this.txtcontact.TabIndex = 17;
            // 
            // lbcontact
            // 
            this.lbcontact.AutoSize = true;
            this.lbcontact.Location = new System.Drawing.Point(317, 180);
            this.lbcontact.Name = "lbcontact";
            this.lbcontact.Size = new System.Drawing.Size(44, 13);
            this.lbcontact.TabIndex = 24;
            this.lbcontact.Text = "Contact";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(91, 212);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(167, 20);
            this.txtnom.TabIndex = 14;
            // 
            // lbdatedenaissance
            // 
            this.lbdatedenaissance.AutoSize = true;
            this.lbdatedenaissance.Location = new System.Drawing.Point(543, 97);
            this.lbdatedenaissance.Name = "lbdatedenaissance";
            this.lbdatedenaissance.Size = new System.Drawing.Size(96, 13);
            this.lbdatedenaissance.TabIndex = 21;
            this.lbdatedenaissance.Text = "Date de naissance";
            // 
            // txtdatedenaissance
            // 
            this.txtdatedenaissance.Location = new System.Drawing.Point(547, 135);
            this.txtdatedenaissance.Name = "txtdatedenaissance";
            this.txtdatedenaissance.Size = new System.Drawing.Size(167, 20);
            this.txtdatedenaissance.TabIndex = 19;
            // 
            // lbmatricule
            // 
            this.lbmatricule.AutoSize = true;
            this.lbmatricule.Location = new System.Drawing.Point(87, 97);
            this.lbmatricule.Name = "lbmatricule";
            this.lbmatricule.Size = new System.Drawing.Size(50, 13);
            this.lbmatricule.TabIndex = 18;
            this.lbmatricule.Text = "Matricule";
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(146, 335);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(82, 46);
            this.btncancel.TabIndex = 22;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Etudiant";
            // 
            // txtmatricule
            // 
            this.txtmatricule.Location = new System.Drawing.Point(91, 135);
            this.txtmatricule.Name = "txtmatricule";
            this.txtmatricule.Size = new System.Drawing.Size(167, 20);
            this.txtmatricule.TabIndex = 13;
            // 
            // Ecole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtecole);
            this.Controls.Add(this.lbecole);
            this.Controls.Add(this.lbnom);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.lbprenom);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.lbcontact);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.lbdatedenaissance);
            this.Controls.Add(this.txtdatedenaissance);
            this.Controls.Add(this.lbmatricule);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmatricule);
            this.Name = "Ecole";
            this.Text = "Ecole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtecole;
        private System.Windows.Forms.Label lbecole;
        private System.Windows.Forms.Label lbnom;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.Label lbprenom;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Label lbcontact;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label lbdatedenaissance;
        private System.Windows.Forms.TextBox txtdatedenaissance;
        private System.Windows.Forms.Label lbmatricule;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmatricule;
    }
}