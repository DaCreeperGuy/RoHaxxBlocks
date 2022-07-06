
using System.Windows.Forms;

namespace RoHaxxBlocks
{
    partial class ScriptHub
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
            this.label1 = new System.Windows.Forms.Label();
            this.TopBar = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Arsenal = new System.Windows.Forms.Button();
            this.BreakingPoint = new System.Windows.Forms.Button();
            this.Bloxburg = new System.Windows.Forms.Button();
            this.PrisonLife = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "RoHaxxBlocks - Script Hub";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.TopBar.Controls.Add(this.button2);
            this.TopBar.Controls.Add(this.button1);
            this.TopBar.Controls.Add(this.Minimize);
            this.TopBar.Controls.Add(this.label1);
            this.TopBar.Controls.Add(this.Close);
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(750, 75);
            this.TopBar.TabIndex = 2;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(500, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 12;
            this.button2.Text = "🗕";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(556, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "✕";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Minimize.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.Lime;
            this.Minimize.Location = new System.Drawing.Point(882, 9);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(50, 50);
            this.Minimize.TabIndex = 10;
            this.Minimize.Text = "🗕";
            this.Minimize.UseVisualStyleBackColor = false;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Close.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.Red;
            this.Close.Location = new System.Drawing.Point(938, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(50, 50);
            this.Close.TabIndex = 9;
            this.Close.Text = "✕";
            this.Close.UseVisualStyleBackColor = false;
            // 
            // Arsenal
            // 
            this.Arsenal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Arsenal.ForeColor = System.Drawing.SystemColors.Control;
            this.Arsenal.Location = new System.Drawing.Point(12, 240);
            this.Arsenal.Name = "Arsenal";
            this.Arsenal.Size = new System.Drawing.Size(150, 50);
            this.Arsenal.TabIndex = 4;
            this.Arsenal.Text = "Arsenal";
            this.Arsenal.UseVisualStyleBackColor = false;
            this.Arsenal.Click += new System.EventHandler(this.Arsenal_Click);
            // 
            // BreakingPoint
            // 
            this.BreakingPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BreakingPoint.ForeColor = System.Drawing.SystemColors.Control;
            this.BreakingPoint.Location = new System.Drawing.Point(168, 240);
            this.BreakingPoint.Name = "BreakingPoint";
            this.BreakingPoint.Size = new System.Drawing.Size(150, 50);
            this.BreakingPoint.TabIndex = 6;
            this.BreakingPoint.Text = "Breaking Point";
            this.BreakingPoint.UseVisualStyleBackColor = false;
            this.BreakingPoint.Click += new System.EventHandler(this.BreakingPoint_Click);
            // 
            // Bloxburg
            // 
            this.Bloxburg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Bloxburg.ForeColor = System.Drawing.SystemColors.Control;
            this.Bloxburg.Location = new System.Drawing.Point(480, 240);
            this.Bloxburg.Name = "Bloxburg";
            this.Bloxburg.Size = new System.Drawing.Size(150, 50);
            this.Bloxburg.TabIndex = 10;
            this.Bloxburg.Text = "Bloxburg";
            this.Bloxburg.UseVisualStyleBackColor = false;
            this.Bloxburg.Click += new System.EventHandler(this.Bloxburg_Click);
            // 
            // PrisonLife
            // 
            this.PrisonLife.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PrisonLife.ForeColor = System.Drawing.SystemColors.Control;
            this.PrisonLife.Location = new System.Drawing.Point(324, 240);
            this.PrisonLife.Name = "PrisonLife";
            this.PrisonLife.Size = new System.Drawing.Size(150, 50);
            this.PrisonLife.TabIndex = 11;
            this.PrisonLife.Text = "Prison Life";
            this.PrisonLife.UseVisualStyleBackColor = false;
            this.PrisonLife.Click += new System.EventHandler(this.PrisonLife_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RoHaxxBlocks.Properties.Resources.BloxburgIcon2020;
            this.pictureBox4.Location = new System.Drawing.Point(481, 81);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 150);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RoHaxxBlocks.Properties.Resources.image__2_;
            this.pictureBox3.Location = new System.Drawing.Point(324, 81);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RoHaxxBlocks.Properties.Resources.Breakingpoint;
            this.pictureBox2.Location = new System.Drawing.Point(168, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RoHaxxBlocks.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(12, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ScriptHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(643, 302);
            this.Controls.Add(this.PrisonLife);
            this.Controls.Add(this.Bloxburg);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BreakingPoint);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Arsenal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TopBar);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ScriptHub";
            this.Text = "Script Hub";
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Button Minimize;
        private new System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        public ScriptHub(Button minimize)
        {
            Minimize = minimize;
        }

        private PictureBox pictureBox1;
        private Button Arsenal;
        private Button BreakingPoint;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button Bloxburg;
        private PictureBox pictureBox4;
        private Button PrisonLife;
    }
}