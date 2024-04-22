using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.unite_uygulama_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tt=new ToolTip();
            tt.SetToolTip(txtAd, "Adınızı giriniz.");
            tt.SetToolTip(txtSoyad,"Soyadınızı giriniz");
            tt.SetToolTip(txtTArih, "Doğum tarihinizi gg / aa / yyyy şeklinde giriniz.");
            tt.SetToolTip(txtAdres, "Adresinizi giriniz.");
            tt.SetToolTip(button1, "Kaydetmek için tıklayınız.");
        }
    }
}
