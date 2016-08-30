namespace WebBrowser
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.browser = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.prev = new System.Windows.Forms.ToolStripButton();
            this.next = new System.Windows.Forms.ToolStripButton();
            this.refr = new System.Windows.Forms.ToolStripButton();
            this.home = new System.Windows.Forms.ToolStripButton();
            this.adress = new System.Windows.Forms.ToolStripTextBox();
            this.go = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browser.Location = new System.Drawing.Point(0, 34);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(780, 323);
            this.browser.TabIndex = 0;
            this.browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browser_DocumentCompleted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prev,
            this.next,
            this.refr,
            this.home,
            this.adress,
            this.go});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(781, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // prev
            // 
            this.prev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prev.Image = ((System.Drawing.Image)(resources.GetObject("prev.Image")));
            this.prev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(23, 22);
            this.prev.Text = "toolStripButton1";
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.next.Image = ((System.Drawing.Image)(resources.GetObject("next.Image")));
            this.next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(23, 22);
            this.next.Text = "toolStripButton2";
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // refr
            // 
            this.refr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refr.Image = ((System.Drawing.Image)(resources.GetObject("refr.Image")));
            this.refr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refr.Name = "refr";
            this.refr.Size = new System.Drawing.Size(23, 22);
            this.refr.Text = "toolStripButton3";
            this.refr.Click += new System.EventHandler(this.refr_Click);
            // 
            // home
            // 
            this.home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(23, 22);
            this.home.Text = "toolStripButton4";
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // adress
            // 
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(600, 25);
            this.adress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adress_KeyDown);
            // 
            // go
            // 
            this.go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.go.Image = ((System.Drawing.Image)(resources.GetObject("go.Image")));
            this.go.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(23, 22);
            this.go.Text = "toolStripButton5";
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 356);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.browser);
            this.Name = "Form1";
            this.Text = "MyWebBrowser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton prev;
        private System.Windows.Forms.ToolStripButton next;
        private System.Windows.Forms.ToolStripButton refr;
        private System.Windows.Forms.ToolStripButton home;
        private System.Windows.Forms.ToolStripTextBox adress;
        private System.Windows.Forms.ToolStripButton go;
    }
}

