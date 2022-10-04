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
        }

        private void Button1_Click(object sender, EventArgs e)
        {

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
