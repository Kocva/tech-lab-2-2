using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txt1Code.Text = Properties.Settings.Default.code1.ToString();
            txt2Code.Text = Properties.Settings.Default.code2.ToString();
            txtCodeWord.Text = Properties.Settings.Default.codeWord.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string code1, code2, codeWord;
            try
            {
                code1 = this.txt1Code.Text;
                code2 = this.txt2Code.Text;
                codeWord = this.txtCodeWord.Text;
            }
            catch
            {
                return;
            }
            Properties.Settings.Default.code1 = code1;
            Properties.Settings.Default.code2 = code2;
            Properties.Settings.Default.codeWord = codeWord;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.Replace(codeWord, code1, code2));
            

        }
    }

    public class Logic
    {
        public static string Replace(string str, string code1, string code2)
        {
            string newStr = str.Replace(code1[0], code2[0]).Replace(code1[1], code2[1]).Replace(code1[2], code2[2]).Replace(code1[3], code2[3]);
            return newStr;
        }
    }
}
