//Vizitiu Alexandru 3123b
using System.Drawing;

namespace Interfata
{
    partial class General
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            this.cautareData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cautareData
            // 
            this.cautareData.AutoSize = true;
            this.cautareData.BackColor = System.Drawing.Color.Transparent;
            this.cautareData.Location = new System.Drawing.Point(2, 336);
            this.cautareData.Name = "cautareData";
            this.cautareData.Size = new System.Drawing.Size(148, 15);
            this.cautareData.TabIndex = 0;
            this.cautareData.Text = "Introduceti intervalul dorit:";
            //this.cautareData.Click += new System.EventHandler(this.cautareData_Click);
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(756, 422);
            this.Controls.Add(this.cautareData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "General";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cautareData;
    }
}

