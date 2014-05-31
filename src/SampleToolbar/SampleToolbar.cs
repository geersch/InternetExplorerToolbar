using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BandObjectLib;

namespace SampleToolbar
{        
    [Guid("88272A6E-9989-4c15-8536-D4F7C4E2D891")]
    [Description("Sample Toolbar")]
    [BandObject("Sample Toolbar", BandObjectStyle.ExplorerToolbar | 
        BandObjectStyle.Horizontal, HelpText = "A sample toolbar with a single button")]      
    public partial class SampleToolbar : BandObject
    {
        public SampleToolbar()
        {
            InitializeComponent();            

            this.toolStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            this.toolStrip.Renderer = new NoBorderToolStripRenderer();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!");
        }
    }

    ///
    /// ToolStripSystemRenderer that overrides OnRenderToolStripBorder to avoid painting the borders.
    ///
    internal class NoBorderToolStripRenderer : ToolStripSystemRenderer
    {
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) { }
    } 
}
