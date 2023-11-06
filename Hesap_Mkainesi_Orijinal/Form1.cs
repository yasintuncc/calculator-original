using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Mkainesi_Orijinal
{
    public partial class Form1 : Form
    {
        private Char _işlem;
        private bool _ekrantemizlenecekmi;
        private double _ilksayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rakam1button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) ekranlabel.Text = ""; _ekrantemizlenecekmi = false;
            if(ekranlabel.Text=="0") ekranlabel.Text="";
            ekranlabel.Text += "1";
        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) ekranlabel.Text = ""; _ekrantemizlenecekmi=false;
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "2";
        }

        private void rakam3button_Click(object sender, EventArgs e)
        {

            if (_ekrantemizlenecekmi) ekranlabel.Text = ""; _ekrantemizlenecekmi=!false;
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "3";
        }

        private void rakam4button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
                ekranlabel.Text = ""; _ekrantemizlenecekmi = false;
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "4";
        }

        private void rakam5button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) ekranlabel.Text = ""; _ekrantemizlenecekmi=false;
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "5";
        }

        private void rakam6button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) ekranlabel.Text = ""; _ekrantemizlenecekmi = false;
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "6";
        }

        private void rakam7button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) ekranlabel.Text = ""; _ekrantemizlenecekmi = false;
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "7";
        }

        private void rakam8button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) ekranlabel.Text = ""; _ekrantemizlenecekmi=false;
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "8";
        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) ekranlabel.Text = "";  _ekrantemizlenecekmi = false;
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "9";
        }

        private void rakam0button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) ekranlabel.Text = ""; _ekrantemizlenecekmi = false;
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "0";
        }

        private void artıbutton_Click(object sender, EventArgs e)
        {
            _işlem = '+';
            _ekrantemizlenecekmi = true;
            _ilksayi=Convert.ToDouble(ekranlabel.Text);
        }

        private void esittirbutton_Click(object sender, EventArgs e)
        {
            double ikincisayı=Convert.ToDouble(ekranlabel.Text);
            double sonuc;


            switch(_işlem)
            {
                case '+':
                    sonuc = _ilksayi + ikincisayı;
                    break;
                case '-':
                    sonuc = _ilksayi - ikincisayı;
                    break;
                case '*':
                    sonuc = _ilksayi * ikincisayı;
                    break;
                case '/':
                    sonuc = _ilksayi / ikincisayı;
                    break;
                default:
                    sonuc= 0;
                    break;
            }
            ekranlabel.Text=Convert.ToString(sonuc);
        }

        private void eksibutton_Click(object sender, EventArgs e)
        {
            _işlem = '-';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt16(ekranlabel.Text);
        }

        private void carpıbutton_Click(object sender, EventArgs e)
        {
            _işlem = '*';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt16(ekranlabel.Text);
        }

        private void bolübutton_Click(object sender, EventArgs e)
        {
            _işlem = '/';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt16(ekranlabel.Text);
        }

        private void Temizlebutton_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "0";
        }
    }
}
