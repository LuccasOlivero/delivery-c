namespace WinFormsApp1
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
            secondNumber = new TextBox();
            btnSubmit = new Button();
            label1 = new Label();
            label2 = new Label();
            typeOfOperation = new TextBox();
            label3 = new Label();
            firstNumber = new TextBox();
            SuspendLayout();
            // 
            // secondNumber
            // 
            secondNumber.Location = new Point(334, 272);
            secondNumber.Name = "secondNumber";
            secondNumber.Size = new Size(180, 23);
            secondNumber.TabIndex = 1;
            secondNumber.TextChanged += textBox2_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(429, 312);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(85, 21);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "enviar";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(334, 254);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 3;
            label1.Text = "segundo numero";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(334, 142);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 5;
            label2.Text = "Tipo de operación";
            // 
            // typeOfOperation
            // 
            typeOfOperation.Location = new Point(334, 160);
            typeOfOperation.Name = "typeOfOperation";
            typeOfOperation.Size = new Size(180, 23);
            typeOfOperation.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(334, 209);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 7;
            label3.Text = "primer numero";
            // 
            // firstNumber
            // 
            firstNumber.Location = new Point(334, 227);
            firstNumber.Name = "firstNumber";
            firstNumber.Size = new Size(180, 23);
            firstNumber.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(824, 459);
            Controls.Add(label3);
            Controls.Add(firstNumber);
            Controls.Add(label2);
            Controls.Add(typeOfOperation);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Controls.Add(secondNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox secondNumber;
        private Button btnSubmit;
        private Label label1;
        private Label label2;
        private TextBox typeOfOperation;
        private Label label3;
        private TextBox firstNumber;
    }
}
