using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataVizFromScratch
{
    public partial class View_Map : Form
    {
        public View_Map()
        {
            InitializeComponent();
        }

        private void View_Map_Load(object sender, EventArgs e)
        {
            //---Load a map in the Web Browser Control
            LoadMap();
            
        }

        private void LoadMap()
        {
            string sMapURL = "http://localhost:8000/map.html?3";
            mctlWB.Url = new Uri(sMapURL);
        }

        private void openDelimiterSeparatedFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //---Prompt user to select file


            //---get delimiter for file


            //---load file to DataTable
        }
    }
}
