using ClassApp.Models;
using SecondaryApp;
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
            var s = new SecondForm();
            s.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = "Excel-Dateien (*.xlsx) | *.xlsx"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var table = ExcelConverter.ImportExceltoDatatable(dialog.FileName);
                dataGridView1.DataSource = table;
            }
        }
    }
}
