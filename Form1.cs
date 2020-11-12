using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WP_2020_01_HW01_3A713136
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] msg = { "買蛋糕給我謝謝 :D", "請，多喝滾水 :)", "請投砸摳 :> ", "導入失敗...再投砸摳:]", "出口在前方，門把往右轉，謝謝:3" };
        private void But1_Click(object sender, EventArgs e)
        {
            MD5 md5 = MD5.Create();//建立一個MD5
            byte[] source = Encoding.Default.GetBytes(tB1.Text);//將字串轉為Byte[]
            byte[] crypto = md5.ComputeHash(source);//進行MD5加密
                                                    //string result = Convert.ToBase64String(crypto);//把加密後的字串從Byte[]轉為字串
            int i= ((int)crypto[0]) % 5;

            rTB1.Text = ("大師認為.....  \n" + msg[i]);//輸出結果
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
