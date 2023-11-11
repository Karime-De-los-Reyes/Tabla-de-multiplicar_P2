namespace Tabla_de_multiplicar_2
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
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SG Alternative High-Alt", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(206, 9);
            label1.Name = "label1";
            label1.Size = new Size(231, 28);
            label1.TabIndex = 0;
            label1.Text = "Tabla de multiplicar ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SG Alternative High-Alt", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(233, 19);
            label2.TabIndex = 1;
            label2.Text = "Valor de la tabla de multiplicar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SG Alternative High-Alt", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(371, 54);
            label3.Name = "label3";
            label3.Size = new Size(302, 19);
            label3.TabIndex = 2;
            label3.Text = "Limite máximo de la tabla de multiplicar";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(252, 85);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 154);
            listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("SG Alternative High-Alt", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(77, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("SG Alternative High-Alt", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(483, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 27);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("SG Alternative High-Alt", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(275, 245);
            button1.Name = "button1";
            button1.Size = new Size(80, 26);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}