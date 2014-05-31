namespace SampleToolbar
{
    partial class SampleToolbar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleToolbar));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnHello = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHello});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(150, 24);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // btnHello
            // 
            this.btnHello.Image = ((System.Drawing.Image)(resources.GetObject("btnHello.Image")));
            this.btnHello.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(73, 21);
            this.btnHello.Text = "Click me";
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // SampleToolbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.toolStrip);
            this.MaxSize = new System.Drawing.Size(150, 24);
            this.MinSize = new System.Drawing.Size(150, 24);
            this.Name = "SampleToolbar";
            this.Size = new System.Drawing.Size(150, 24);
            this.Title = "";
            this.ViewMode = ((BandObjectLib.DBIMF)((BandObjectLib.DBIMF.USECHEVRON | BandObjectLib.DBIMF.TOPALIGN)));
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnHello;

    }
}
