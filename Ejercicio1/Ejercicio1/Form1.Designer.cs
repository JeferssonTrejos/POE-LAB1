namespace Ejercicio1
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
            label1 = new Label();
            firsTextLabel = new Label();
            secondTextLabel = new Label();
            firsTextBox = new TextBox();
            secondTextBox = new TextBox();
            AnagramChecker = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 27);
            label1.Name = "label1";
            label1.Size = new Size(317, 31);
            label1.TabIndex = 0;
            label1.Text = "Comprobador de anagramas";
            // 
            // firsTextLabel
            // 
            firsTextLabel.AutoSize = true;
            firsTextLabel.Location = new Point(109, 100);
            firsTextLabel.Name = "firsTextLabel";
            firsTextLabel.Size = new Size(149, 31);
            firsTextLabel.TabIndex = 1;
            firsTextLabel.Text = "Primer texto";
            // 
            // secondTextLabel
            // 
            secondTextLabel.AutoSize = true;
            secondTextLabel.Location = new Point(109, 207);
            secondTextLabel.Name = "secondTextLabel";
            secondTextLabel.Size = new Size(172, 31);
            secondTextLabel.TabIndex = 2;
            secondTextLabel.Text = "Segundo texto";
            // 
            // firsTextBox
            // 
            firsTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firsTextBox.Location = new Point(109, 134);
            firsTextBox.Name = "firsTextBox";
            firsTextBox.Size = new Size(231, 38);
            firsTextBox.TabIndex = 3;
            // 
            // secondTextBox
            // 
            secondTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondTextBox.Location = new Point(109, 241);
            secondTextBox.Name = "secondTextBox";
            secondTextBox.Size = new Size(231, 38);
            secondTextBox.TabIndex = 4;
            // 
            // AnagramChecker
            // 
            AnagramChecker.Location = new Point(132, 341);
            AnagramChecker.Name = "AnagramChecker";
            AnagramChecker.Size = new Size(166, 47);
            AnagramChecker.TabIndex = 5;
            AnagramChecker.Text = "Comprobar";
            AnagramChecker.UseVisualStyleBackColor = true;
            AnagramChecker.Click += AnagramChecker_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLabel.Location = new Point(561, 160);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 31);
            resultLabel.TabIndex = 6;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 543);
            Controls.Add(resultLabel);
            Controls.Add(AnagramChecker);
            Controls.Add(secondTextBox);
            Controls.Add(firsTextBox);
            Controls.Add(secondTextLabel);
            Controls.Add(firsTextLabel);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label firsTextLabel;
        private Label secondTextLabel;
        private TextBox firsTextBox;
        private TextBox secondTextBox;
        private Button AnagramChecker;
        private Label resultLabel;
    }
}
