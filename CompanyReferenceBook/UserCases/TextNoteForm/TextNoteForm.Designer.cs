namespace CompanyReferenceBook.UserCases.TextNoteForm
{
    partial class TextNoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextNoteForm));
            this.noteIconButton = new System.Windows.Forms.Button();
            this.txtPageTitle = new System.Windows.Forms.TextBox();
            this.savePageButton = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.emojiComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // noteIconButton
            // 
            this.noteIconButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.noteIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noteIconButton.Image = global::CompanyReferenceBook.Properties.Resources.sidemenu_icon_insights_2x;
            this.noteIconButton.Location = new System.Drawing.Point(38, 12);
            this.noteIconButton.Name = "noteIconButton";
            this.noteIconButton.Size = new System.Drawing.Size(70, 55);
            this.noteIconButton.TabIndex = 0;
            this.noteIconButton.UseVisualStyleBackColor = false;
            this.noteIconButton.Click += new System.EventHandler(this.noteIconButton_Click);
            // 
            // txtPageTitle
            // 
            this.txtPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPageTitle.Location = new System.Drawing.Point(136, 12);
            this.txtPageTitle.Margin = new System.Windows.Forms.Padding(6);
            this.txtPageTitle.Multiline = true;
            this.txtPageTitle.Name = "txtPageTitle";
            this.txtPageTitle.Size = new System.Drawing.Size(1053, 55);
            this.txtPageTitle.TabIndex = 2;
            this.txtPageTitle.Text = "Заголовок страницы";
            this.txtPageTitle.MouseEnter += new System.EventHandler(this.Mouse_MoveOut_FromComboBox_With);
            // 
            // savePageButton
            // 
            this.savePageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.savePageButton.FlatAppearance.BorderSize = 0;
            this.savePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savePageButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.savePageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savePageButton.Location = new System.Drawing.Point(1226, 12);
            this.savePageButton.Margin = new System.Windows.Forms.Padding(4);
            this.savePageButton.Name = "savePageButton";
            this.savePageButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.savePageButton.Size = new System.Drawing.Size(357, 55);
            this.savePageButton.TabIndex = 7;
            this.savePageButton.Text = "Сохранить страницу";
            this.savePageButton.UseVisualStyleBackColor = false;
            this.savePageButton.Click += new System.EventHandler(this.savePageButton_Click);
            this.savePageButton.MouseEnter += new System.EventHandler(this.Mouse_MoveOut_FromComboBox_With);
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox.Location = new System.Drawing.Point(12, 95);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(1658, 881);
            this.richTextBox.TabIndex = 8;
            this.richTextBox.Text = " Type something...";
            this.richTextBox.MouseEnter += new System.EventHandler(this.Mouse_MoveOut_FromComboBox_With);
            // 
            // emojiComboBox
            // 
            this.emojiComboBox.FormattingEnabled = true;
            this.emojiComboBox.Location = new System.Drawing.Point(12, 56);
            this.emojiComboBox.Name = "emojiComboBox";
            this.emojiComboBox.Size = new System.Drawing.Size(121, 33);
            this.emojiComboBox.TabIndex = 10;
            this.emojiComboBox.SelectedIndexChanged += new System.EventHandler(this.emojiComboBox_SelectedIndexChanged);
            // 
            // TextNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1682, 988);
            this.Controls.Add(this.emojiComboBox);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.savePageButton);
            this.Controls.Add(this.txtPageTitle);
            this.Controls.Add(this.noteIconButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextNoteForm";
            this.Text = "Страница";
            this.Load += new System.EventHandler(this.TextNoteForm_Load);
            this.MouseEnter += new System.EventHandler(this.Mouse_MoveOut_FromComboBox_With);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button noteIconButton;
        private System.Windows.Forms.TextBox txtPageTitle;
        private System.Windows.Forms.Button savePageButton;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ComboBox emojiComboBox;
    }
}