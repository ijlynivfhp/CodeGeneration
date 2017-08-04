using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.IO;
using System.Runtime.Serialization.Json;
using CodeGeneration.Helper;

namespace CodeGeneration
{
    public partial class TranslationForm : Form
    {
        public TranslationForm()
        {
            InitializeComponent();
        }
        BackgroundWorker bginit;

        string translator = "";
        private void button1_Click(object sender, EventArgs e)
        {
            bginit = new System.ComponentModel.BackgroundWorker();
            bginit.DoWork += bginit_DoWork;
            bginit.RunWorkerCompleted += bginit_RunWorkerCompleted;
            bginit.ProgressChanged += bginit_ProgressChanged;
            bginit.RunWorkerAsync();
        }

        void bginit_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void bginit_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            //throw new NotImplementedException();
            textBox2.Text = translator;
        }

        void bginit_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var trans = TransApi.GetTransResult(this.textBox1.Text);

            string ls_strTmp = "";

            ls_strTmp = "查询:" + trans.query + "\r\n";
            ls_strTmp += "翻译:";
            for (int i = 0; i < trans.translation.Length; i++)
            {
                ls_strTmp += trans.translation[i] + ",";
            }
            ls_strTmp = ls_strTmp.Remove(ls_strTmp.LastIndexOf(',')) + "\r\n";

            if (trans.basic != null)
            {
                ls_strTmp += "拼音:" + trans.basic.phonetic + "\r\n";
                ls_strTmp += "释义:";

                for (int i = 0; i < trans.basic.explains.Length; i++)
                {
                    ls_strTmp += trans.basic.explains[i] + ",";
                }
                ls_strTmp = ls_strTmp.Remove(ls_strTmp.LastIndexOf(',')) + "\r\n";
            }
            ls_strTmp += "网络扩展:" + "\r\n";

            for (int i = 0; i < trans.web.Length; i++)
            {
                ls_strTmp += trans.web[i].key + "\r\n";
                for (int j = 0; j < trans.web[i].value.Length; j++)
                {
                    ls_strTmp += trans.web[i].value[j] + ";";
                }
                ls_strTmp = ls_strTmp.Remove(ls_strTmp.LastIndexOf(';')) + "\r\n";
            }
            translator = ls_strTmp;
        }


    }
}
