namespace ejercicio4
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
            textBox = new TextBox();
            label1 = new Label();
            textLabel = new Label();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(183, 148);
            textBox.Name = "textBox";
            textBox.Size = new Size(481, 27);
            textBox.TabIndex = 1;
            textBox.TextChanged += textBox_TextChanged;
            textBox.KeyPress += textBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(362, 64);
            label1.Name = "label1";
            label1.Size = new Size(121, 31);
            label1.TabIndex = 2;
            label1.Text = "Ejercicio 4";
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new Point(185, 196);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(0, 20);
            textLabel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textLabel);
            Controls.Add(label1);
            Controls.Add(textBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox;
        private Label label1;
        private Label textLabel;
    }
}
