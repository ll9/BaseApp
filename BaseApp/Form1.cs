using ClassApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var lp = new Lichtpunkt();
            var mast = new Mast();
            var s = new SecondaryApp.SecondForm();
            s.ShowDialog();
        }
    }
}
