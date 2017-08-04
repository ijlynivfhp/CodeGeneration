namespace CodeGeneration
{
    partial class Preview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preview));
            this.syntaxTextBox1 = new CodeGeneration.SyntaxTextBox.SyntaxTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.点击复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // syntaxTextBox1
            // 
            this.syntaxTextBox1.AcceptsTab = true;
            this.syntaxTextBox1.CaseSensitive = false;
            this.syntaxTextBox1.ConfigFile = "csharp.xml";
            this.syntaxTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.syntaxTextBox1.FilterAutoComplete = true;
            this.syntaxTextBox1.Location = new System.Drawing.Point(0, 25);
            this.syntaxTextBox1.MaxUndoRedoSteps = 50;
            this.syntaxTextBox1.Name = "syntaxTextBox1";
            this.syntaxTextBox1.Size = new System.Drawing.Size(1042, 701);
            this.syntaxTextBox1.TabIndex = 0;
            this.syntaxTextBox1.Text = "";
            this.syntaxTextBox1.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.点击复制ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 点击复制ToolStripMenuItem
            // 
            this.点击复制ToolStripMenuItem.Name = "点击复制ToolStripMenuItem";
            this.点击复制ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.点击复制ToolStripMenuItem.Text = "点击复制";
            this.点击复制ToolStripMenuItem.Click += new System.EventHandler(this.点击复制ToolStripMenuItem_Click);
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 726);
            this.Controls.Add(this.syntaxTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预览";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SyntaxTextBox.SyntaxTextBox syntaxTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 点击复制ToolStripMenuItem;
    }
}