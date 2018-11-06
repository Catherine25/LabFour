using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Controller c = new Controller();

            c.FileExists("SA.txt");
            c.FileExists("SB.txt");
            c.FileExists("SC.txt");

            c.GetFromFile("SA.txt");
            c.GetFromFile("SB.txt");
            c.GetFromFile("SC.txt");

            c.ToSD();

            c.SaveResult();
        }
    }
}
