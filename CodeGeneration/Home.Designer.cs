namespace CodeGeneration
{
    partial class Home
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.LabClassName = new System.Windows.Forms.Label();
            this.labClassDes = new System.Windows.Forms.Label();
            this.txtClassDes = new System.Windows.Forms.TextBox();
            this.txtNameSapace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.labInherit = new System.Windows.Forms.Label();
            this.txtInherit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveConfig = new System.Windows.Forms.Button();
            this.textParameter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSeparationType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textUsing = new System.Windows.Forms.TextBox();
            this.btnjoin = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.翻译ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.att = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(65, 23);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(201, 21);
            this.txtClassName.TabIndex = 0;
            // 
            // LabClassName
            // 
            this.LabClassName.AutoSize = true;
            this.LabClassName.Location = new System.Drawing.Point(24, 26);
            this.LabClassName.Name = "LabClassName";
            this.LabClassName.Size = new System.Drawing.Size(35, 12);
            this.LabClassName.TabIndex = 1;
            this.LabClassName.Text = "类名:";
            // 
            // labClassDes
            // 
            this.labClassDes.AutoSize = true;
            this.labClassDes.Location = new System.Drawing.Point(309, 26);
            this.labClassDes.Name = "labClassDes";
            this.labClassDes.Size = new System.Drawing.Size(47, 12);
            this.labClassDes.TabIndex = 3;
            this.labClassDes.Text = "类说明:";
            // 
            // txtClassDes
            // 
            this.txtClassDes.Location = new System.Drawing.Point(362, 23);
            this.txtClassDes.Name = "txtClassDes";
            this.txtClassDes.Size = new System.Drawing.Size(201, 21);
            this.txtClassDes.TabIndex = 1;
            // 
            // txtNameSapace
            // 
            this.txtNameSapace.Location = new System.Drawing.Point(661, 23);
            this.txtNameSapace.Name = "txtNameSapace";
            this.txtNameSapace.Size = new System.Drawing.Size(132, 21);
            this.txtNameSapace.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "命名空间:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(799, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "(为空不填写)";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.att,
            this.Column1,
            this.rem});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 358);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(917, 324);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(677, 48);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 8;
            this.btnPreview.Text = "预览";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(758, 48);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "保存实体";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // labInherit
            // 
            this.labInherit.AutoSize = true;
            this.labInherit.Location = new System.Drawing.Point(24, 53);
            this.labInherit.Name = "labInherit";
            this.labInherit.Size = new System.Drawing.Size(35, 12);
            this.labInherit.TabIndex = 9;
            this.labInherit.Text = "继承:";
            // 
            // txtInherit
            // 
            this.txtInherit.Location = new System.Drawing.Point(65, 50);
            this.txtInherit.Name = "txtInherit";
            this.txtInherit.Size = new System.Drawing.Size(113, 21);
            this.txtInherit.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(189, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "(为空不填写)";
            // 
            // saveConfig
            // 
            this.saveConfig.Location = new System.Drawing.Point(839, 48);
            this.saveConfig.Name = "saveConfig";
            this.saveConfig.Size = new System.Drawing.Size(75, 23);
            this.saveConfig.TabIndex = 10;
            this.saveConfig.Text = "保存配置";
            this.saveConfig.UseVisualStyleBackColor = true;
            this.saveConfig.Click += new System.EventHandler(this.saveConfig_Click);
            // 
            // textParameter
            // 
            this.textParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textParameter.Location = new System.Drawing.Point(3, 17);
            this.textParameter.Multiline = true;
            this.textParameter.Name = "textParameter";
            this.textParameter.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textParameter.Size = new System.Drawing.Size(911, 136);
            this.textParameter.TabIndex = 6;
            this.textParameter.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textParameter);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 156);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "需要生成实体参数";
            // 
            // txtSeparationType
            // 
            this.txtSeparationType.Location = new System.Drawing.Point(362, 50);
            this.txtSeparationType.Name = "txtSeparationType";
            this.txtSeparationType.Size = new System.Drawing.Size(201, 21);
            this.txtSeparationType.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "参数隔开方式:";
            // 
            // sfdFile
            // 
            this.sfdFile.Filter = "C# 文件|*.cs";
            this.sfdFile.Tag = "实体类保存到";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textUsing);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(917, 114);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "引入命名空间";
            // 
            // textUsing
            // 
            this.textUsing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textUsing.Location = new System.Drawing.Point(3, 17);
            this.textUsing.Multiline = true;
            this.textUsing.Name = "textUsing";
            this.textUsing.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textUsing.Size = new System.Drawing.Size(911, 94);
            this.textUsing.TabIndex = 5;
            // 
            // btnjoin
            // 
            this.btnjoin.Location = new System.Drawing.Point(596, 48);
            this.btnjoin.Name = "btnjoin";
            this.btnjoin.Size = new System.Drawing.Size(75, 23);
            this.btnjoin.TabIndex = 8;
            this.btnjoin.Text = "加入表格";
            this.btnjoin.UseVisualStyleBackColor = true;
            this.btnjoin.Click += new System.EventHandler(this.btnjoin_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.翻译ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 25);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 翻译ToolStripMenuItem
            // 
            this.翻译ToolStripMenuItem.Name = "翻译ToolStripMenuItem";
            this.翻译ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.翻译ToolStripMenuItem.Text = "翻译";
            this.翻译ToolStripMenuItem.Click += new System.EventHandler(this.翻译ToolStripMenuItem_Click);
            // 
            // att
            // 
            this.att.HeaderText = "属性";
            this.att.Name = "att";
            // 
            // Column1
            // 
            this.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Column1.HeaderText = "类型";
            this.Column1.Items.AddRange(new object[] {
            "string",
            "int",
            "bool",
            "DateTime",
            "byte",
            "Guid"});
            this.Column1.Name = "Column1";
            // 
            // rem
            // 
            this.rem.HeaderText = "备注";
            this.rem.Name = "rem";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 682);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveConfig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labInherit);
            this.Controls.Add(this.txtInherit);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnjoin);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labClassDes);
            this.Controls.Add(this.txtNameSapace);
            this.Controls.Add(this.txtSeparationType);
            this.Controls.Add(this.txtClassDes);
            this.Controls.Add(this.LabClassName);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy实体生成(生成实体参数可直接写中文，自动翻译成英文)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label LabClassName;
        private System.Windows.Forms.Label labClassDes;
        private System.Windows.Forms.TextBox txtClassDes;
        private System.Windows.Forms.TextBox txtNameSapace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label labInherit;
        private System.Windows.Forms.TextBox txtInherit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveConfig;
        private System.Windows.Forms.TextBox textParameter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSeparationType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textUsing;
        private System.Windows.Forms.Button btnjoin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 翻译ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn att;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rem;
    }
}

