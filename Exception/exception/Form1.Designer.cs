namespace exception
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Input = new System.Windows.Forms.TextBox();
            this._Calculate = new System.Windows.Forms.Button();
            this._Exit = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Height = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this._Zero = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.RightBracket = new System.Windows.Forms.Button();
            this.LeftBracket = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this._BS = new System.Windows.Forms.Button();
            this._Point = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Input.Location = new System.Drawing.Point(11, 24);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(386, 20);
            this.Input.TabIndex = 1;
            this.Input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // _Calculate
            // 
            this._Calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._Calculate.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Calculate.Location = new System.Drawing.Point(11, 289);
            this._Calculate.Name = "_Calculate";
            this._Calculate.Size = new System.Drawing.Size(218, 36);
            this._Calculate.TabIndex = 2;
            this._Calculate.Text = "=";
            this._Calculate.UseVisualStyleBackColor = false;
            this._Calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // _Exit
            // 
            this._Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._Exit.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Exit.Location = new System.Drawing.Point(236, 289);
            this._Exit.Name = "_Exit";
            this._Exit.Size = new System.Drawing.Size(162, 36);
            this._Exit.TabIndex = 8;
            this._Exit.Text = "Exit";
            this._Exit.UseVisualStyleBackColor = false;
            this._Exit.Click += new System.EventHandler(this.button4_Click);
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.Color.Purple;
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Seven.Location = new System.Drawing.Point(12, 178);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(50, 50);
            this.Seven.TabIndex = 10;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Height
            // 
            this.Height.BackColor = System.Drawing.Color.Purple;
            this.Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Height.Location = new System.Drawing.Point(68, 178);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(50, 50);
            this.Height.TabIndex = 11;
            this.Height.Text = "8";
            this.Height.UseVisualStyleBackColor = false;
            this.Height.Click += new System.EventHandler(this.Height_Click);
            // 
            // Nine
            // 
            this.Nine.BackColor = System.Drawing.Color.Purple;
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nine.Location = new System.Drawing.Point(124, 178);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(50, 50);
            this.Nine.TabIndex = 12;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.Color.Purple;
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Four.Location = new System.Drawing.Point(12, 122);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(50, 50);
            this.Four.TabIndex = 13;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.Color.Purple;
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Five.Location = new System.Drawing.Point(68, 122);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(50, 50);
            this.Five.TabIndex = 14;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.Color.Purple;
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Six.Location = new System.Drawing.Point(124, 122);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(50, 50);
            this.Six.TabIndex = 15;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // One
            // 
            this.One.BackColor = System.Drawing.Color.Purple;
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.One.Location = new System.Drawing.Point(12, 66);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(50, 50);
            this.One.TabIndex = 16;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.BackColor = System.Drawing.Color.Purple;
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Two.Location = new System.Drawing.Point(68, 66);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(50, 50);
            this.Two.TabIndex = 17;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.Color.Purple;
            this.Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Three.Location = new System.Drawing.Point(124, 66);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(50, 50);
            this.Three.TabIndex = 18;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // _Zero
            // 
            this._Zero.BackColor = System.Drawing.Color.Purple;
            this._Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Zero.Location = new System.Drawing.Point(12, 234);
            this._Zero.Name = "_Zero";
            this._Zero.Size = new System.Drawing.Size(50, 50);
            this._Zero.TabIndex = 19;
            this._Zero.Text = "0";
            this._Zero.UseVisualStyleBackColor = false;
            this._Zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.Color.Blue;
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Multiply.Location = new System.Drawing.Point(180, 178);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(50, 50);
            this.Multiply.TabIndex = 20;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.Color.Blue;
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Divide.Location = new System.Drawing.Point(180, 234);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(50, 50);
            this.Divide.TabIndex = 21;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Sum
            // 
            this.Sum.BackColor = System.Drawing.Color.Blue;
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sum.Location = new System.Drawing.Point(180, 66);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(50, 50);
            this.Sum.TabIndex = 22;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = false;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Subtract
            // 
            this.Subtract.BackColor = System.Drawing.Color.Blue;
            this.Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Subtract.Location = new System.Drawing.Point(180, 122);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(50, 50);
            this.Subtract.TabIndex = 23;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = false;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Red;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(124, 234);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(50, 50);
            this.Clear.TabIndex = 24;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // RightBracket
            // 
            this.RightBracket.BackColor = System.Drawing.Color.Yellow;
            this.RightBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightBracket.Location = new System.Drawing.Point(348, 234);
            this.RightBracket.Name = "RightBracket";
            this.RightBracket.Size = new System.Drawing.Size(50, 50);
            this.RightBracket.TabIndex = 26;
            this.RightBracket.Text = ")";
            this.RightBracket.UseVisualStyleBackColor = false;
            this.RightBracket.Click += new System.EventHandler(this.RightBracket_Click);
            // 
            // LeftBracket
            // 
            this.LeftBracket.BackColor = System.Drawing.Color.Yellow;
            this.LeftBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftBracket.Location = new System.Drawing.Point(292, 234);
            this.LeftBracket.Name = "LeftBracket";
            this.LeftBracket.Size = new System.Drawing.Size(50, 50);
            this.LeftBracket.TabIndex = 27;
            this.LeftBracket.Text = "(";
            this.LeftBracket.UseVisualStyleBackColor = false;
            this.LeftBracket.Click += new System.EventHandler(this.LeftBracket_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(236, 66);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.result.Size = new System.Drawing.Size(161, 161);
            this.result.TabIndex = 28;
            // 
            // _BS
            // 
            this._BS.BackColor = System.Drawing.Color.Red;
            this._BS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._BS.Location = new System.Drawing.Point(68, 234);
            this._BS.Name = "_BS";
            this._BS.Size = new System.Drawing.Size(50, 50);
            this._BS.TabIndex = 29;
            this._BS.Text = "<-";
            this._BS.UseVisualStyleBackColor = false;
            this._BS.Click += new System.EventHandler(this._BS_Click);
            // 
            // _Point
            // 
            this._Point.BackColor = System.Drawing.Color.Yellow;
            this._Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Point.ForeColor = System.Drawing.Color.Black;
            this._Point.Location = new System.Drawing.Point(236, 234);
            this._Point.Name = "_Point";
            this._Point.Size = new System.Drawing.Size(50, 50);
            this._Point.TabIndex = 31;
            this._Point.Text = ",";
            this._Point.UseVisualStyleBackColor = false;
            this._Point.Click += new System.EventHandler(this._Point_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(409, 338);
            this.Controls.Add(this._Point);
            this.Controls.Add(this._BS);
            this.Controls.Add(this.result);
            this.Controls.Add(this.LeftBracket);
            this.Controls.Add(this.RightBracket);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this._Zero);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this._Exit);
            this.Controls.Add(this._Calculate);
            this.Controls.Add(this.Input);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button _Calculate;
        private System.Windows.Forms.Button _Exit;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Height;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button _Zero;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button RightBracket;
        private System.Windows.Forms.Button LeftBracket;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button _BS;
        private System.Windows.Forms.Button _Point;
    }
}

