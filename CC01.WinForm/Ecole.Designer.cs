﻿
namespace CC01.WinForm
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
            this.lbnom = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbcontact = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbnom
            // 
            this.lbnom.AutoSize = true;
            this.lbnom.Location = new System.Drawing.Point(72, 70);
            this.lbnom.Name = "lbnom";
            this.lbnom.Size = new System.Drawing.Size(29, 13);
            this.lbnom.TabIndex = 0;
            this.lbnom.Text = "Nom";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(75, 204);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(176, 23);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(366, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 4;
            // 
            // lbcontact
            // 
            this.lbcontact.AutoSize = true;
            this.lbcontact.Location = new System.Drawing.Point(363, 70);
            this.lbcontact.Name = "lbcontact";
            this.lbcontact.Size = new System.Drawing.Size(44, 13);
            this.lbcontact.TabIndex = 3;
            this.lbcontact.Text = "Contact";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(75, 258);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(176, 23);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbcontact);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lbnom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnom;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbcontact;
        private System.Windows.Forms.Button btncancel;
    }
}

