﻿
namespace TpCalculette
{
    partial class frmCalculette
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
            this.txtAffichage = new System.Windows.Forms.TextBox();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAffichage
            // 
            this.txtAffichage.Location = new System.Drawing.Point(71, 185);
            this.txtAffichage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAffichage.Name = "txtAffichage";
            this.txtAffichage.ReadOnly = true;
            this.txtAffichage.Size = new System.Drawing.Size(76, 20);
            this.txtAffichage.TabIndex = 0;
            this.txtAffichage.Text = "0";
            this.txtAffichage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAffichage_KeyPress);
            // 
            // btnCalculer
            // 
            this.btnCalculer.Location = new System.Drawing.Point(257, 28);
            this.btnCalculer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(94, 19);
            this.btnCalculer.TabIndex = 1;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            this.btnCalculer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCalculer_MouseMove);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(21, 28);
            this.btn8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(56, 19);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(182, 28);
            this.btn5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(56, 19);
            this.btn5.TabIndex = 3;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(100, 28);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(63, 20);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // frmCalculette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 492);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.txtAffichage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCalculette";
            this.Text = "Ma calculette";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCalculette_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAffichage;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnPlus;
    }
}

