﻿namespace MegaMan
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblOptions1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblOptions2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("High Tower Text", 53.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblHelp.Location = new System.Drawing.Point(264, 22);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(185, 84);
            this.lblHelp.TabIndex = 0;
            this.lblHelp.Text = "Help";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Constantia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblPlayer1.Location = new System.Drawing.Point(82, 93);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(138, 45);
            this.lblPlayer1.TabIndex = 1;
            this.lblPlayer1.Text = "Player 1";
            // 
            // lblOptions1
            // 
            this.lblOptions1.AutoSize = true;
            this.lblOptions1.Font = new System.Drawing.Font("Constantia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions1.ForeColor = System.Drawing.Color.White;
            this.lblOptions1.Location = new System.Drawing.Point(52, 161);
            this.lblOptions1.Name = "lblOptions1";
            this.lblOptions1.Size = new System.Drawing.Size(375, 360);
            this.lblOptions1.TabIndex = 2;
            this.lblOptions1.Text = "Left: leftArrow\r\n\r\nRight: rightArrow\r\n\r\nUp: topArrow\r\n\r\nDown: bottomArrow\r\n      " +
    "                       ";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Constantia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblPlayer2.Location = new System.Drawing.Point(468, 106);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(144, 45);
            this.lblPlayer2.TabIndex = 3;
            this.lblPlayer2.Text = "Player 2";
            // 
            // lblOptions2
            // 
            this.lblOptions2.AutoSize = true;
            this.lblOptions2.Font = new System.Drawing.Font("Constantia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions2.ForeColor = System.Drawing.Color.White;
            this.lblOptions2.Location = new System.Drawing.Point(420, 131);
            this.lblOptions2.Name = "lblOptions2";
            this.lblOptions2.Size = new System.Drawing.Size(281, 360);
            this.lblOptions2.TabIndex = 4;
            this.lblOptions2.Text = "Left:   A\r\n\r\nRight:   D\r\n\r\nUp:   W\r\n\r\nDown:   S\r\n                             ";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(514, 390);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(151, 61);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 609);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDescription.Location = new System.Drawing.Point(360, 521);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(994, 88);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 609);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblOptions2);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblOptions1);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Help";
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblOptions1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblOptions2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDescription;
    }
}