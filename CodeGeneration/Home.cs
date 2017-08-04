using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeGeneration.Helper;

namespace CodeGeneration
{
    public partial class Home : Form
    {
        public static string Path = AppDomain.CurrentDomain.BaseDirectory + "/config.xml";
        public static List<string> ComboBoxList = new List<string>();
        public Home()
        {
            InitializeComponent();
            if (File.Exists(Path))
            {
                Config config = (Config)XmlHelper.DeserializeFromXml(Path, typeof(Config));
                txtClassName.Text = config.ClassName;
                txtNameSapace.Text = config.NameSapace;
                txtClassDes.Text = config.ClassDes;
                var usingsplit = Regex.Replace(config.Using, "\n", "").Split(';');
                var text = "";
                foreach (var item in usingsplit)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        text += item + ";\r\n";
                    }
                }
                textUsing.Text = text;
                txtInherit.Text = config.Inherit;
                txtSeparationType.Text = config.SeparationType;
            }
            ComboBoxList.Add("string");
            ComboBoxList.Add("int");
            ComboBoxList.Add("bool");
            ComboBoxList.Add("DateTime");
            ComboBoxList.Add("byte");
            ComboBoxList.Add("Guid");
            ComboBoxList.Add("object");
            
            DataGridViewTextBoxCell textboxcell = dataGridView.Rows[0].Cells[0] as DataGridViewTextBoxCell;
            if (textboxcell != null) textboxcell.Value = "";
            DataGridViewComboBoxCell comboxcell = dataGridView.Rows[0].Cells[1] as DataGridViewComboBoxCell;
            if (comboxcell != null) comboxcell.DataSource = ComboBoxList;

            DataGridViewTextBoxCell textboxcel2 = dataGridView.Rows[0].Cells[2] as DataGridViewTextBoxCell;
            if (textboxcel2 != null) textboxcel2.Value = "";
            dataGridView.Rows[0].Cells[1].Value = "string";
        }
        private void saveConfig_Click(object sender, EventArgs e)
        {
            Config config = new Config
            {
                ClassName = txtClassName.Text.Trim(),
                NameSapace = txtNameSapace.Text.Trim(),
                ClassDes = txtClassDes.Text.Trim(),
                Inherit = txtInherit.Text.Trim(),
                SeparationType = txtSeparationType.Text.Trim()
            };
            var usingText = Regex.Replace(textUsing.Text, "\n", "");
            config.Using = usingText;
            XmlHelper.SerializeToXml(config, config.GetType(), Path, null);
            MessageBox.Show("保存成功");
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string className = txtClassName.Text.Trim();
            string nameSpace = txtNameSapace.Text.Trim();
            string classDes = txtClassDes.Text.Trim();
            string usingtxt = textUsing.Text.Trim();
            string inherit = txtInherit.Text.Trim();
            if (className.Length == 0)
            {
                MessageBox.Show("类名不能为空");
                return;
            }
            string path = AppDomain.CurrentDomain.BaseDirectory + "/temp/";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            var file = path + DateTime.Now.ToString("yyyyMMddHHmmss") + ".cs";
            using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                if (!string.IsNullOrEmpty(usingtxt))
                {
                    sw.WriteLine(usingtxt);
                    sw.WriteLine("");
                }
                if (!string.IsNullOrEmpty(txtNameSapace.Text.Trim()))
                {
                    sw.WriteLine("namespace " + nameSpace);
                    sw.WriteLine("{");
                }
                if (!string.IsNullOrEmpty(classDes))
                {
                    sw.WriteLine("  /// <summary>");
                    sw.WriteLine("  /// " + classDes);
                    sw.WriteLine("  /// </summary>");
                    sw.WriteLine("  [DisplayName(\"" + classDes + "\")]");
                }

                if (string.IsNullOrEmpty(inherit))
                {
                    sw.WriteLine("  public class " + className);
                }
                else
                {
                    sw.WriteLine("  public class " + className + " : " + inherit);
                }
                sw.WriteLine("  {");
                int i = 0;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    i++;
                    if (dataGridView.Rows.Count == i)
                    {
                        continue;
                    }
                    if (row.Cells[0].Value != null && row.Cells[0].Value != null)
                    {
                        string propname = row.Cells[0].Value.ToString();
                        if (string.IsNullOrEmpty(propname))
                        {
                            MessageBox.Show("属性不能为空");
                            return;
                        }
                        string type = row.Cells[1].Value.ToString();
                        if (string.IsNullOrEmpty(type))
                        {
                            MessageBox.Show("类型不能为空");
                            return;
                        }
                        string remarks = row.Cells[2].Value.ToString();

                        //替换propname前一个或多个下划线，中间下划线不替换  
                        string propname1 = Regex.Replace(propname, "^_+", "");
                        propname1 = Regex.Replace(propname1, " ", "");
                        //把propname首字母变为大写  
                        string functionname = propname1.Substring(0, 1).ToUpper() + propname1.Substring(1);
                        if (!string.IsNullOrEmpty(remarks))
                        {
                            sw.WriteLine("        /// <summary>");
                            sw.WriteLine("        /// " + remarks);
                            sw.WriteLine("        /// </summary>");
                            sw.WriteLine("        [DisplayName(\"" + remarks + "\")]");
                        }
                        sw.WriteLine("        public " + type + " " + functionname + " { get; set; }");
                    }
                }
                sw.WriteLine("  }");

                if (!string.IsNullOrEmpty(txtNameSapace.Text.Trim()))
                {
                    sw.WriteLine("}");
                }
                sw.Close();
                fs.Close();
            }


            Preview fromp = new Preview(file);
            fromp.ShowDialog();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string className = txtClassName.Text.Trim();
            string nameSpace = txtNameSapace.Text.Trim();
            string classDes = txtClassDes.Text.Trim();
            string usingtxt = textUsing.Text.Trim();
            string inherit = txtInherit.Text.Trim();
            if (className.Length == 0)
            {
                MessageBox.Show("类名不能为空");
                return;
            }

            sfdFile.FileName = className;
            if (sfdFile.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfdFile.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                if (!string.IsNullOrEmpty(usingtxt))
                {
                    sw.WriteLine(usingtxt);
                    sw.WriteLine("");
                }
                if (!string.IsNullOrEmpty(txtNameSapace.Text.Trim()))
                {
                    sw.WriteLine("namespace " + nameSpace);
                    sw.WriteLine("{");
                }
                if (!string.IsNullOrEmpty(classDes))
                {
                    sw.WriteLine("  /// <summary>");
                    sw.WriteLine("  /// " + classDes);
                    sw.WriteLine("  /// </summary>");
                    sw.WriteLine("  [DisplayName(\"" + classDes + "\")]");
                }

                if (string.IsNullOrEmpty(inherit))
                {
                    sw.WriteLine("  public class " + className);
                }
                else
                {
                    sw.WriteLine("  public class " + className + " : " + inherit);
                }
                sw.WriteLine("  {");
                int i = 0;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    i++;
                    if (dataGridView.Rows.Count == i)
                    {
                        continue;
                    }
                    if (row.Cells[0].Value != null && row.Cells[0].Value != null)
                    {
                        string propname = row.Cells[0].Value.ToString();
                        if (string.IsNullOrEmpty(propname))
                        {
                            MessageBox.Show("属性不能为空");
                            return;
                        }
                        string type = row.Cells[1].Value.ToString();
                        if (string.IsNullOrEmpty(type))
                        {
                            MessageBox.Show("类型不能为空");
                            return;
                        }
                        string remarks = row.Cells[2].Value.ToString();

                        //替换propname前一个或多个下划线，中间下划线不替换  
                        string propname1 = Regex.Replace(propname, "^_+", "");
                        propname1 = Regex.Replace(propname1, " ", "");
                        //把propname首字母变为大写  
                        string functionname = propname1.Substring(0, 1).ToUpper() + propname1.Substring(1);
                        if (!string.IsNullOrEmpty(remarks))
                        {
                            sw.WriteLine("        /// <summary>");
                            sw.WriteLine("        /// " + remarks);
                            sw.WriteLine("        /// </summary>");
                            sw.WriteLine("        [DisplayName(\"" + remarks + "\")]");
                        }
                        sw.WriteLine("        public " + type + " " + functionname + " { get; set; }");
                    }
                }
                sw.WriteLine("  }");

                if (!string.IsNullOrEmpty(txtNameSapace.Text.Trim()))
                {
                    sw.WriteLine("}");
                }
                sw.Close();
                fs.Close();
                MessageBox.Show("实体类创建成功！");
            }
        }

        private void btnjoin_Click(object sender, EventArgs e)
        {
            var separationType = txtSeparationType.Text;
            if (string.IsNullOrEmpty(separationType))
            {
                MessageBox.Show("参数隔开方式不能为空");
                return;
            }
            var sepchar = char.Parse(separationType);
            if (string.IsNullOrEmpty(textParameter.Text))
            {
                MessageBox.Show("参数不能为空");
                return;
            }
            var paramlist = textParameter.Text.Split(sepchar);
            foreach (var item in paramlist)
            {
                var result = TransApi.GetTransResult(item);

                var jieguoResult = "";
             
                if (result.translation[0] != null)
                {
                    jieguoResult = result.translation[0];
                }
                jieguoResult= Regex.Replace(jieguoResult, " ", "");
                jieguoResult = Regex.Replace(jieguoResult, "Tia ohe", "");
                jieguoResult = Regex.Replace(jieguoResult, "the", "");
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell textboxcell = new DataGridViewTextBoxCell();
                textboxcell.Value = jieguoResult;
                row.Cells.Add(textboxcell);
                DataGridViewComboBoxCell comboxcell = new DataGridViewComboBoxCell();
                comboxcell.DataSource = ComboBoxList;

                //comboxcell.DisplayMember = "string";
                row.Cells.Add(comboxcell);
                DataGridViewTextBoxCell textboxcel2 = new DataGridViewTextBoxCell();
                textboxcel2.Value = item;
                row.Cells.Add(textboxcel2);
                row.Cells[1].Value = "string";
                dataGridView.Rows.Add(row);
            }

        }

        private void 翻译ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TranslationForm tf = new TranslationForm();
            tf.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var comboxcell = dataGridView.Rows[e.RowIndex].Cells[1] as DataGridViewComboBoxCell;
            if (comboxcell != null) comboxcell.DataSource = ComboBoxList;
            dataGridView.Rows[e.RowIndex].Cells[1].Value = "string";
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dataGridView[e.ColumnIndex, e.RowIndex] != null && !dataGridView[e.ColumnIndex, e.RowIndex].ReadOnly)
            {
                DataGridViewComboBoxColumn comboBoxColumn = dataGridView.Columns[e.ColumnIndex] as DataGridViewComboBoxColumn;
                if (comboBoxColumn != null)
                {
                    this.dataGridView.CurrentCell = dataGridView[e.ColumnIndex, e.RowIndex];
                    dataGridView.BeginEdit(true);
                    DataGridViewComboBoxEditingControl comboBoxEditingControl = dataGridView.EditingControl as DataGridViewComboBoxEditingControl;
                    if (comboBoxEditingControl != null)
                    {
                        comboBoxEditingControl.DroppedDown = true;
                    }
                }
            }
        }
    }
}
