namespace WhatIsReflection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxMembers = new ListBox();
            buttonGetMembers = new Button();
            SuspendLayout();
            // 
            // listBoxMembers
            // 
            listBoxMembers.FormattingEnabled = true;
            listBoxMembers.ItemHeight = 15;
            listBoxMembers.Location = new Point(277, 102);
            listBoxMembers.Name = "listBoxMembers";
            listBoxMembers.Size = new Size(190, 229);
            listBoxMembers.TabIndex = 0;
            // 
            // buttonGetMembers
            // 
            buttonGetMembers.Location = new Point(276, 74);
            buttonGetMembers.Name = "buttonGetMembers";
            buttonGetMembers.Size = new Size(191, 23);
            buttonGetMembers.TabIndex = 1;
            buttonGetMembers.Text = "Üyeleri Getir";
            buttonGetMembers.UseVisualStyleBackColor = true;
            buttonGetMembers.Click += buttonGetMembers_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 501);
            Controls.Add(buttonGetMembers);
            Controls.Add(listBoxMembers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxMembers;
        private Button buttonGetMembers;
    }
}