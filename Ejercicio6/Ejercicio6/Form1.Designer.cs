namespace Ejercicio6
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
            velocityLabel = new Label();
            VelocityTextBox = new TextBox();
            timeTextBox = new TextBox();
            timeLabel = new Label();
            label1 = new Label();
            resultLabel = new Label();
            calculateAcceleration = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // velocityLabel
            // 
            velocityLabel.AutoSize = true;
            velocityLabel.Location = new Point(100, 125);
            velocityLabel.Name = "velocityLabel";
            velocityLabel.Size = new Size(100, 28);
            velocityLabel.TabIndex = 0;
            velocityLabel.Text = "Velocidad";
            // 
            // VelocityTextBox
            // 
            VelocityTextBox.BorderStyle = BorderStyle.FixedSingle;
            VelocityTextBox.Location = new Point(100, 156);
            VelocityTextBox.Name = "VelocityTextBox";
            VelocityTextBox.Size = new Size(158, 34);
            VelocityTextBox.TabIndex = 1;
            // 
            // timeTextBox
            // 
            timeTextBox.BorderStyle = BorderStyle.FixedSingle;
            timeTextBox.Location = new Point(100, 253);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.Size = new Size(158, 34);
            timeTextBox.TabIndex = 3;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(100, 222);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(190, 28);
            timeLabel.TabIndex = 2;
            timeLabel.Text = "Tiempo (segundos)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(258, 159);
            label1.Name = "label1";
            label1.Size = new Size(47, 28);
            label1.TabIndex = 4;
            label1.Text = "m/s";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLabel.Location = new Point(669, 183);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(121, 41);
            resultLabel.TabIndex = 5;
            resultLabel.Text = "0.0 m/s";
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // calculateAcceleration
            // 
            calculateAcceleration.Location = new Point(390, 327);
            calculateAcceleration.Name = "calculateAcceleration";
            calculateAcceleration.Size = new Size(110, 54);
            calculateAcceleration.TabIndex = 6;
            calculateAcceleration.Text = "Calcular";
            calculateAcceleration.UseVisualStyleBackColor = true;
            calculateAcceleration.Click += calculateAcceleration_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(256, 34);
            label3.Name = "label3";
            label3.Size = new Size(365, 38);
            label3.TabIndex = 7;
            label3.Text = "Calculadora de aceleracion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(258, 256);
            label4.Name = "label4";
            label4.Size = new Size(21, 28);
            label4.TabIndex = 8;
            label4.Text = "s";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 475);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(calculateAcceleration);
            Controls.Add(resultLabel);
            Controls.Add(label1);
            Controls.Add(timeTextBox);
            Controls.Add(timeLabel);
            Controls.Add(VelocityTextBox);
            Controls.Add(velocityLabel);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label velocityLabel;
        private TextBox VelocityTextBox;
        private TextBox timeTextBox;
        private Label timeLabel;
        private Label label1;
        private Label resultLabel;
        private Button calculateAcceleration;
        private Label label3;
        private Label label4;
    }
}
