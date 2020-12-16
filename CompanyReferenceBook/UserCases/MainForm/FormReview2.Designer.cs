namespace CompanyReferenceBook
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.pageAddingLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.sideMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1416, 40);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(95, 36);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(96, 36);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.White;
            this.sideMenuPanel.Controls.Add(this.button1);
            this.sideMenuPanel.Controls.Add(this.pageAddingLabel);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 40);
            this.sideMenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(480, 833);
            this.sideMenuPanel.TabIndex = 0;
            // 
            // pageAddingLabel
            // 
            this.pageAddingLabel.AutoSize = true;
            this.pageAddingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageAddingLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pageAddingLabel.Location = new System.Drawing.Point(15, 6);
            this.pageAddingLabel.Name = "pageAddingLabel";
            this.pageAddingLabel.Size = new System.Drawing.Size(159, 33);
            this.pageAddingLabel.TabIndex = 0;
            this.pageAddingLabel.Text = "Страницы";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(416, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CompanyReferenceBook.Properties.Resources.carl_heyerdahl_KE0nC8_58MQ_unsplash3333;
            this.pictureBox1.Location = new System.Drawing.Point(368, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1066, 871);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1416, 873);
            this.Controls.Add(this.sideMenuPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "workspace";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sideMenuPanel.ResumeLayout(false);
            this.sideMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label pageAddingLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
