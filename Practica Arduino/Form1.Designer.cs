﻿namespace Practica_Arduino
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Encender = new System.Windows.Forms.Button();
            this.btn_Apagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Encender
            // 
            this.btn_Encender.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Encender.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Encender.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Encender.Location = new System.Drawing.Point(84, 99);
            this.btn_Encender.Name = "btn_Encender";
            this.btn_Encender.Size = new System.Drawing.Size(190, 84);
            this.btn_Encender.TabIndex = 0;
            this.btn_Encender.Text = "Encender ";
            this.btn_Encender.UseVisualStyleBackColor = false;
            this.btn_Encender.Click += new System.EventHandler(this.btn_Encender_Click);
            // 
            // btn_Apagar
            // 
            this.btn_Apagar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Apagar.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_Apagar.Location = new System.Drawing.Point(84, 222);
            this.btn_Apagar.Name = "btn_Apagar";
            this.btn_Apagar.Size = new System.Drawing.Size(190, 97);
            this.btn_Apagar.TabIndex = 1;
            this.btn_Apagar.Text = "Apagar ";
            this.btn_Apagar.UseVisualStyleBackColor = false;
            this.btn_Apagar.Click += new System.EventHandler(this.btn_Apagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(367, 436);
            this.Controls.Add(this.btn_Apagar);
            this.Controls.Add(this.btn_Encender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Encender;
        private System.Windows.Forms.Button btn_Apagar;
    }
}

