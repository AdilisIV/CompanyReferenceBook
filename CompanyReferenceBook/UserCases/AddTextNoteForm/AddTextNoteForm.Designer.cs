namespace CompanyReferenceBook.UserCases.AddTextNoteForm
{
    partial class AddTextNoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTextNoteForm));
            this.emojiComboBox = new System.Windows.Forms.ComboBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.savePageButton = new System.Windows.Forms.Button();
            this.txtPageTitle = new System.Windows.Forms.TextBox();
            this.noteIconButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emojiComboBox
            // 
            this.emojiComboBox.FormattingEnabled = true;
            this.emojiComboBox.Location = new System.Drawing.Point(12, 57);
            this.emojiComboBox.Name = "emojiComboBox";
            this.emojiComboBox.Size = new System.Drawing.Size(121, 33);
            this.emojiComboBox.TabIndex = 15;
            this.emojiComboBox.SelectedValueChanged += new System.EventHandler(this.emojiComboBox_SelectedIndexChanged);
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox.Location = new System.Drawing.Point(12, 96);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(1658, 881);
            this.richTextBox.TabIndex = 14;
            this.richTextBox.Text = " Type something...";
            this.richTextBox.MouseEnter += new System.EventHandler(this.Mouse_MoveOut_FromComboBox_With);
            // 
            // savePageButton
            // 
            this.savePageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.savePageButton.FlatAppearance.BorderSize = 0;
            this.savePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savePageButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.savePageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savePageButton.Location = new System.Drawing.Point(1226, 13);
            this.savePageButton.Margin = new System.Windows.Forms.Padding(4);
            this.savePageButton.Name = "savePageButton";
            this.savePageButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.savePageButton.Size = new System.Drawing.Size(357, 55);
            this.savePageButton.TabIndex = 13;
            this.savePageButton.Text = "Создать страницу";
            this.savePageButton.UseVisualStyleBackColor = false;
            this.savePageButton.Click += new System.EventHandler(this.savePageButton_Click);
            this.savePageButton.MouseEnter += new System.EventHandler(this.Mouse_MoveOut_FromComboBox_With);
            // 
            // txtPageTitle
            // 
            this.txtPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPageTitle.Location = new System.Drawing.Point(136, 13);
            this.txtPageTitle.Margin = new System.Windows.Forms.Padding(6);
            this.txtPageTitle.Multiline = true;
            this.txtPageTitle.Name = "txtPageTitle";
            this.txtPageTitle.Size = new System.Drawing.Size(1053, 55);
            this.txtPageTitle.TabIndex = 12;
            this.txtPageTitle.Text = "Заголовок страницы...";
            this.txtPageTitle.MouseEnter += new System.EventHandler(this.Mouse_MoveOut_FromComboBox_With);
            // 
            // noteIconButton
            // 
            this.noteIconButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.noteIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noteIconButton.Image = global::CompanyReferenceBook.Properties.Resources.sidemenu_icon_insights_2x;
            this.noteIconButton.Location = new System.Drawing.Point(38, 13);
            this.noteIconButton.Name = "noteIconButton";
            this.noteIconButton.Size = new System.Drawing.Size(70, 55);
            this.noteIconButton.TabIndex = 11;
            this.noteIconButton.UseVisualStyleBackColor = false;
            this.noteIconButton.Click += new System.EventHandler(this.noteIconButton_Click);
            this.noteIconButton.MouseEnter += new System.EventHandler(this.Mouse_MoveOut_FromComboBox_With);
            // 
            // AddTextNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1682, 994);
            this.Controls.Add(this.emojiComboBox);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.savePageButton);
            this.Controls.Add(this.txtPageTitle);
            this.Controls.Add(this.noteIconButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTextNoteForm";
            this.Text = "Добавление страницы";
            this.Load += new System.EventHandler(this.TextNoteForm_Load);
            this.MouseEnter += new System.EventHandler(this.Mouse_MoveOut_FromComboBox_With);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox emojiComboBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button savePageButton;
        private System.Windows.Forms.TextBox txtPageTitle;
        private System.Windows.Forms.Button noteIconButton;
    }
}