using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GetSABt.Click += GetSABt_Click;
            GetSBBt.Click += GetSBBt_Click;
            GetSCBt.Click += GetSCBt_Click;
            ShowResultBt.Click += ShowResultBt_Click;
        }

        private void GetSCBt_Click(object sender, EventArgs e)
        {
            Controller.FileExists("SC.txt");
            Controller.GetFromFile("SC.txt");
            textBoxSC.Text = Controller.toShow;
        }

        private void GetSBBt_Click(object sender, EventArgs e)
        {
            Controller.FileExists("SB.txt");
            Controller.GetFromFile("SB.txt");
            textBoxSB.Text = Controller.toShow;
        }        

        private void GetSABt_Click(object sender, EventArgs e)
        {
            Controller.FileExists("SA.txt");
            Controller.GetFromFile("SA.txt");
            textBoxSA.Text = Controller.toShow;
        }

        private void ShowResultBt_Click(object sender, EventArgs e)
        {
            if (textBoxSA.Text == "" || textBoxSB.Text == "" || textBoxSC.Text == "")
                MessageBox.Show("You need to fill all fields!");
            else
            {
                Controller.ToSD();
                Controller.SaveResult();
                textBoxSD.Text = Controller.toShow;
            }   
        }
    }
}
