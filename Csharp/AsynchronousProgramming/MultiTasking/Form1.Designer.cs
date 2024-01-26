namespace MultiTasking
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
            progressBar1 = new ProgressBar();
            labelCounter = new Label();
            buttonMesaj = new Button();
            buttonCounter = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(303, 279);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(133, 23);
            progressBar1.TabIndex = 7;
            // 
            // labelCounter
            // 
            labelCounter.AutoSize = true;
            labelCounter.Location = new Point(357, 245);
            labelCounter.Name = "labelCounter";
            labelCounter.Size = new Size(25, 15);
            labelCounter.TabIndex = 6;
            labelCounter.Text = "......";
            // 
            // buttonMesaj
            // 
            buttonMesaj.Location = new Point(681, 19);
            buttonMesaj.Name = "buttonMesaj";
            buttonMesaj.Size = new Size(75, 23);
            buttonMesaj.TabIndex = 5;
            buttonMesaj.Text = "Mesaj";
            buttonMesaj.UseVisualStyleBackColor = true;
            buttonMesaj.Click += buttonMesaj_Click;
            // 
            // buttonCounter
            // 
            buttonCounter.Location = new Point(303, 165);
            buttonCounter.Name = "buttonCounter";
            buttonCounter.Size = new Size(133, 55);
            buttonCounter.TabIndex = 4;
            buttonCounter.Text = "Sayaç";
            buttonCounter.UseVisualStyleBackColor = true;
            buttonCounter.Click += buttonCounter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(labelCounter);
            Controls.Add(buttonMesaj);
            Controls.Add(buttonCounter);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label labelCounter;
        private Button buttonMesaj;
        private Button buttonCounter;
    }
}