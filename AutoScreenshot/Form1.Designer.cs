using System.ComponentModel;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace AutoScreenshot
{
    partial class Form1
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
            this.components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new NotifyIcon(this.components);
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.maximizeToolStripMenuItem = new ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new ToolStripMenuItem();
            this.backgroundWorker1 = new BackgroundWorker();
            this.panel1 = new Panel();
            this.panel3 = new Panel();
            this.pictureBox1 = new PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.screencapbox = new PictureBox();
            this.panel4 = new Panel();
            this.panel5 = new Panel();
            this.panel6 = new Panel();
            this.panel7 = new Panel();
            this.button1 = new Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            ((ISupportInitialize)this.screencapbox).BeginInit();
            this.panel2.SuspendLayout();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new Point(178, 208);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0, 13);
            this.label1.TabIndex = 0;
            this.notifyIcon1.BalloonTipText = "Automatically Save Screenshot";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            this.notifyIcon1.Text = "ASS";
            this.notifyIcon1.Visible = true;
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[]
            {
                this.maximizeToolStripMenuItem,
                this.closeToolStripMenuItem1
            });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(125, 48);
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            this.maximizeToolStripMenuItem.Size = new Size(124, 22);
            this.maximizeToolStripMenuItem.Text = "Maximize";
            this.maximizeToolStripMenuItem.Click += this.maximizeToolStripMenuItem_Click;
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new Size(124, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += this.closeToolStripMenuItem1_Click;
            this.panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = Color.FromArgb(41, 53, 65);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = DockStyle.Left;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(194, 729);
            this.panel1.TabIndex = 3;
            this.panel3.AutoScroll = true;
            this.panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = Color.FromArgb(213, 118, 1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = DockStyle.Top;
            this.panel3.Location = new Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new Size(194, 65);
            this.panel3.TabIndex = 5;
            this.pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox1.Dock = DockStyle.Bottom;
            this.pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            this.pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            this.pictureBox1.Location = new Point(0, 643);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(194, 86);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.label2.Dock = DockStyle.Fill;
            this.label2.Font = new Font("Century Gothic", 24f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.ForeColor = Color.White;
            this.label2.Location = new Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new Size(194, 65);
            this.label2.TabIndex = 0;
            this.label2.Text = "ASS";
            this.label2.TextAlign = ContentAlignment.MiddleCenter;
            this.screencapbox.BackgroundImageLayout = ImageLayout.Stretch;
            this.screencapbox.BorderStyle = BorderStyle.Fixed3D;
            this.screencapbox.Dock = DockStyle.Fill;
            this.screencapbox.Location = new Point(194, 0);
            this.screencapbox.Margin = new Padding(150);
            this.screencapbox.Name = "screencapbox";
            this.screencapbox.Padding = new Padding(125);
            this.screencapbox.Size = new Size(814, 729);
            this.screencapbox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.screencapbox.TabIndex = 6;
            this.screencapbox.TabStop = false;
            this.panel4.Dock = DockStyle.Top;
            this.panel4.Location = new Point(194, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new Size(814, 50);
            this.panel4.TabIndex = 7;
            this.panel5.Dock = DockStyle.Left;
            this.panel5.Location = new Point(194, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new Size(50, 679);
            this.panel5.TabIndex = 8;
            this.panel6.Dock = DockStyle.Right;
            this.panel6.Location = new Point(958, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new Size(50, 679);
            this.panel6.TabIndex = 9;
            this.panel7.Dock = DockStyle.Bottom;
            this.panel7.Location = new Point(244, 679);
            this.panel7.Name = "panel7";
            this.panel7.Size = new Size(714, 50);
            this.panel7.TabIndex = 10;
            this.button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = Color.FromArgb(41, 53, 65);
            this.button1.Cursor = Cursors.Hand;
            this.button1.Dock = DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button1.ForeColor = Color.Transparent;
            this.button1.Location = new Point(0, 0);
            this.button1.Margin = new Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new Size(193, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Take Screenshot";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += this.button1_Click;
            this.label3.Dock = DockStyle.Bottom;
            this.label3.Font = new Font("Century Gothic", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.ForeColor = Color.White;
            this.label3.Location = new Point(0, 111);
            this.label3.Name = "label3";
            this.label3.Size = new Size(193, 49);
            this.label3.TabIndex = 7;
            this.label3.TextAlign = ContentAlignment.MiddleCenter;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new Point(1, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(193, 160);
            this.panel2.TabIndex = 8;
            base.AutoScaleMode = AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = Color.Gainsboro;
            base.ClientSize = new Size(1008, 729);
            base.Controls.Add(this.panel7);
            base.Controls.Add(this.panel6);
            base.Controls.Add(this.panel5);
            base.Controls.Add(this.panel4);
            base.Controls.Add(this.screencapbox);
            base.Controls.Add(this.panel1);
            base.Controls.Add(this.label1);
            base.Icon = (Icon)resources.GetObject("$this.Icon");
            base.KeyPreview = true;
            base.Name = "Form1";
            this.Text = "Automatic Screenshot Saver";
            base.Resize += this.Form1_Resize;
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((ISupportInitialize)this.pictureBox1).EndInit();
            ((ISupportInitialize)this.screencapbox).EndInit();
            this.panel2.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion

        public System.Windows.Forms.Label label1;

        // Token: 0x0400000A RID: 10
        private NotifyIcon notifyIcon1;

        // Token: 0x0400000B RID: 11
        private BackgroundWorker backgroundWorker1;

        // Token: 0x0400000C RID: 12
        private ContextMenuStrip contextMenuStrip1;

        // Token: 0x0400000D RID: 13
        private ToolStripMenuItem maximizeToolStripMenuItem;

        // Token: 0x0400000E RID: 14
        private ToolStripMenuItem closeToolStripMenuItem1;

        // Token: 0x0400000F RID: 15
        private Panel panel1;

        // Token: 0x04000010 RID: 16
        private PictureBox pictureBox1;

        // Token: 0x04000011 RID: 17
        private System.Windows.Forms.Label label2;

        // Token: 0x04000012 RID: 18
        private Panel panel3;

        // Token: 0x04000013 RID: 19
        private PictureBox screencapbox;

        // Token: 0x04000014 RID: 20
        private Panel panel4;

        // Token: 0x04000015 RID: 21
        private Panel panel5;

        // Token: 0x04000016 RID: 22
        private Panel panel6;

        // Token: 0x04000017 RID: 23
        private Panel panel7;

        // Token: 0x04000018 RID: 24
        private Button button1;

        // Token: 0x04000019 RID: 25
        private System.Windows.Forms.Label label3;

        // Token: 0x0400001A RID: 26
        private Panel panel2;
    }
}

