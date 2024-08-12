namespace Ejercicio1
{
    partial class ejercicio1
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
            resultLabel = new Label();
            areAnagram = new Button();
            titleLabel = new Label();
            secondTextBox = new TextBox();
            secondTextLabel = new Label();
            firsTextBox = new TextBox();
            firsTextLabel = new Label();
            SuspendLayout();
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLabel.Location = new Point(500, 148);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 31);
            resultLabel.TabIndex = 13;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // areAnagram
            // 
            areAnagram.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            areAnagram.Location = new Point(71, 340);
            areAnagram.Name = "areAnagram";
            areAnagram.Size = new Size(149, 50);
            areAnagram.TabIndex = 12;
            areAnagram.Text = "Comprobar";
            areAnagram.UseVisualStyleBackColor = true;
            areAnagram.Click += AreAnagram_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(213, 36);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(419, 41);
            titleLabel.TabIndex = 11;
            titleLabel.Text = "Comprobador de anagramas";
            // 
            // secondTextBox
            // 
            secondTextBox.Location = new Point(41, 243);
            secondTextBox.Name = "secondTextBox";
            secondTextBox.Size = new Size(272, 27);
            secondTextBox.TabIndex = 10;
            // 
            // secondTextLabel
            // 
            secondTextLabel.AutoSize = true;
            secondTextLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            secondTextLabel.Location = new Point(41, 209);
            secondTextLabel.Name = "secondTextLabel";
            secondTextLabel.Size = new Size(172, 31);
            secondTextLabel.TabIndex = 9;
            secondTextLabel.Text = "Segundo texto";
            // 
            // firsTextBox
            // 
            firsTextBox.Location = new Point(41, 148);
            firsTextBox.Name = "firsTextBox";
            firsTextBox.Size = new Size(272, 27);
            firsTextBox.TabIndex = 8;
            // 
            // firsTextLabel
            // 
            firsTextLabel.AutoSize = true;
            firsTextLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firsTextLabel.Location = new Point(41, 114);
            firsTextLabel.Name = "firsTextLabel";
            firsTextLabel.Size = new Size(149, 31);
            firsTextLabel.TabIndex = 7;
            firsTextLabel.Text = "Primer texto";
            // 
            // ejercicio1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(areAnagram);
            Controls.Add(titleLabel);
            Controls.Add(secondTextBox);
            Controls.Add(secondTextLabel);
            Controls.Add(firsTextBox);
            Controls.Add(firsTextLabel);
            Name = "ejercicio1";
            Text = "Ejercicio 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultLabel;
        private Button areAnagram;
        private Label titleLabel;
        private TextBox secondTextBox;
        private Label secondTextLabel;
        private TextBox firsTextBox;
        private Label firsTextLabel;
    }
}
