namespace Taschenrechner_winforms
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.one = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.solve = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.window = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(478, 249);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(44, 39);
            this.one.TabIndex = 0;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.button1_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(578, 251);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(44, 39);
            this.three.TabIndex = 1;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.button2_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(528, 249);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(44, 39);
            this.two.TabIndex = 2;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.button3_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(577, 206);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(44, 39);
            this.six.TabIndex = 3;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.button4_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(527, 204);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(44, 39);
            this.five.TabIndex = 4;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.button5_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(478, 204);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(44, 39);
            this.four.TabIndex = 5;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.button6_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(477, 159);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(44, 39);
            this.seven.TabIndex = 6;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.button7_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(527, 159);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(44, 39);
            this.eight.TabIndex = 7;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.button8_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(577, 159);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(44, 39);
            this.nine.TabIndex = 8;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.button9_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(527, 294);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(44, 39);
            this.zero.TabIndex = 9;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.button10_Click);
            // 
            // solve
            // 
            this.solve.Location = new System.Drawing.Point(628, 294);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(44, 39);
            this.solve.TabIndex = 10;
            this.solve.Text = "=";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.button11_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(628, 249);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(44, 39);
            this.minus.TabIndex = 11;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.button12_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(628, 204);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(44, 39);
            this.multiply.TabIndex = 12;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.button13_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(628, 159);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(44, 39);
            this.division.TabIndex = 13;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.button14_Click);
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(577, 294);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(44, 39);
            this.point.TabIndex = 14;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.button15_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(478, 294);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(44, 39);
            this.clear.TabIndex = 15;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button16_Click);
            // 
            // window
            // 
            this.window.Location = new System.Drawing.Point(478, 127);
            this.window.Name = "window";
            this.window.Size = new System.Drawing.Size(244, 26);
            this.window.TabIndex = 16;
            this.window.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(678, 159);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(44, 39);
            this.addition.TabIndex = 18;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.button17_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.window);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.point);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.one);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox window;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addition;
    }
}

