﻿namespace SnakePlay
{
    partial class Form1
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
            cube = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cube).BeginInit();
            SuspendLayout();
            // 
            // cube
            // 
            cube.BackColor = SystemColors.HotTrack;
            cube.Location = new Point(122, 112);
            cube.Name = "cube";
            cube.Size = new Size(40, 40);
            cube.TabIndex = 0;
            cube.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 311);
            Controls.Add(cube);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)cube).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cube;
    }
}