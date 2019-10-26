namespace SysmonCreator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ebubekirBastamaV01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.xmlCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sysmonİnstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sysmonUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 355);
            this.listBox1.TabIndex = 1;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 388);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Exe Name";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(173, 7);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(868, 441);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.Url = new System.Uri("https://www.ebubekirbastama.com", System.UriKind.Absolute);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(145, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(10, 10);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Xml Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ebubekirBastamaV01ToolStripMenuItem,
            this.toolStripSeparator1,
            this.xmlCreateToolStripMenuItem,
            this.sysmonİnstallToolStripMenuItem,
            this.sysmonUpdateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 120);
            // 
            // ebubekirBastamaV01ToolStripMenuItem
            // 
            this.ebubekirBastamaV01ToolStripMenuItem.Enabled = false;
            this.ebubekirBastamaV01ToolStripMenuItem.Name = "ebubekirBastamaV01ToolStripMenuItem";
            this.ebubekirBastamaV01ToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ebubekirBastamaV01ToolStripMenuItem.Text = "Ebubekir Bastama v0.1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // xmlCreateToolStripMenuItem
            // 
            this.xmlCreateToolStripMenuItem.Name = "xmlCreateToolStripMenuItem";
            this.xmlCreateToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.xmlCreateToolStripMenuItem.Text = "Xml Create";
            this.xmlCreateToolStripMenuItem.Click += new System.EventHandler(this.xmlCreateToolStripMenuItem_Click);
            // 
            // sysmonİnstallToolStripMenuItem
            // 
            this.sysmonİnstallToolStripMenuItem.Name = "sysmonİnstallToolStripMenuItem";
            this.sysmonİnstallToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.sysmonİnstallToolStripMenuItem.Text = "Sysmon İnstall";
            this.sysmonİnstallToolStripMenuItem.Click += new System.EventHandler(this.sysmonİnstallToolStripMenuItem_Click);
            // 
            // sysmonUpdateToolStripMenuItem
            // 
            this.sysmonUpdateToolStripMenuItem.Name = "sysmonUpdateToolStripMenuItem";
            this.sysmonUpdateToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.sysmonUpdateToolStripMenuItem.Text = "Sysmon Update";
            this.sysmonUpdateToolStripMenuItem.Click += new System.EventHandler(this.sysmonUpdateToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 460);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sysmon Creator By Bastama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ebubekirBastamaV01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem xmlCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sysmonİnstallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sysmonUpdateToolStripMenuItem;
    }
}

