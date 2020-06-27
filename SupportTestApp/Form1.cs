using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Dataviz.WinForms;

namespace SupportTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var r = new Random();
            var canvas = new BunifuDatavizAdvanced.Canvas();
            var datapoint = new BunifuDatavizAdvanced.DataPoint(Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced._type.Bunifu_line);
            
            datapoint.addLabely("SUN", r.Next(0, 100).ToString());
            datapoint.addLabely("MON", r.Next(0, 100).ToString());
            datapoint.addLabely("TUE", r.Next(0, 100).ToString());
            datapoint.addLabely("WED", r.Next(0, 100).ToString());
            datapoint.addLabely("THU", r.Next(0, 100).ToString());
            datapoint.addLabely("FRI", r.Next(0, 100).ToString());
            datapoint.addLabely("SAT", r.Next(0, 100).ToString());

            // Add data sets to canvas   
            canvas.addData(datapoint);
            //render canvas   
            //bunifuDatavizAdvanced1.Render(canvas);
        }

        private void bunifuDatavizAdvanced1_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
