namespace BrowserApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchBoxTxt = new System.Windows.Forms.TextBox();
            this.goToBtn = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.addToFavBtn = new System.Windows.Forms.Button();
            this.favouriteCB = new System.Windows.Forms.ComboBox();
            this.reload = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBoxTxt
            // 
            this.searchBoxTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBoxTxt.Location = new System.Drawing.Point(12, 29);
            this.searchBoxTxt.Name = "searchBoxTxt";
            this.searchBoxTxt.Size = new System.Drawing.Size(583, 20);
            this.searchBoxTxt.TabIndex = 0;
            this.searchBoxTxt.TextChanged += new System.EventHandler(this.searchBoxTxt_TextChanged);
            // 
            // goToBtn
            // 
            this.goToBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goToBtn.Location = new System.Drawing.Point(601, 28);
            this.goToBtn.Name = "goToBtn";
            this.goToBtn.Size = new System.Drawing.Size(108, 21);
            this.goToBtn.TabIndex = 1;
            this.goToBtn.Text = "GoTo";
            this.goToBtn.UseVisualStyleBackColor = true;
            this.goToBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 66);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(697, 394);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextToolStripMenuItem,
            this.previousToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.previousToolStripMenuItem.Text = "Previous";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.previousToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // addToFavBtn
            // 
            this.addToFavBtn.Location = new System.Drawing.Point(658, -1);
            this.addToFavBtn.Name = "addToFavBtn";
            this.addToFavBtn.Size = new System.Drawing.Size(51, 23);
            this.addToFavBtn.TabIndex = 4;
            this.addToFavBtn.Text = "AddTo";
            this.addToFavBtn.UseVisualStyleBackColor = true;
            this.addToFavBtn.Click += new System.EventHandler(this.addToFavBtn_Click);
            // 
            // favouriteCB
            // 
            this.favouriteCB.FormattingEnabled = true;
            this.favouriteCB.Location = new System.Drawing.Point(253, 2);
            this.favouriteCB.Name = "favouriteCB";
            this.favouriteCB.Size = new System.Drawing.Size(121, 21);
            this.favouriteCB.TabIndex = 5;
            this.favouriteCB.SelectedIndexChanged += new System.EventHandler(this.favouriteCB_SelectedIndexChanged);
            // 
            // reload
            // 
            this.reload.Location = new System.Drawing.Point(520, 1);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(75, 23);
            this.reload.TabIndex = 6;
            this.reload.Text = "reload";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.DockChanged += new System.EventHandler(this.reload_DockChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 472);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.favouriteCB);
            this.Controls.Add(this.addToFavBtn);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.goToBtn);
            this.Controls.Add(this.searchBoxTxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBoxTxt;
        private System.Windows.Forms.Button goToBtn;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Button addToFavBtn;
        private System.Windows.Forms.ComboBox favouriteCB;
        private System.Windows.Forms.Button reload;
    }
}

