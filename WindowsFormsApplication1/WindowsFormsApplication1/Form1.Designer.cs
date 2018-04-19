namespace WindowsFormsApplication1
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
            this._Exp = new System.Windows.Forms.Button();
            this._Seven = new System.Windows.Forms.Button();
            this._Mult = new System.Windows.Forms.Button();
            this._Eight = new System.Windows.Forms.Button();
            this._Five = new System.Windows.Forms.Button();
            this._Div = new System.Windows.Forms.Button();
            this._Four = new System.Windows.Forms.Button();
            this._One = new System.Windows.Forms.Button();
            this._Two = new System.Windows.Forms.Button();
            this._Sqr = new System.Windows.Forms.Button();
            this._Pow = new System.Windows.Forms.Button();
            this._Sin = new System.Windows.Forms.Button();
            this._Cos = new System.Windows.Forms.Button();
            this._Tan = new System.Windows.Forms.Button();
            this._Sqrt = new System.Windows.Forms.Button();
            this._Ln = new System.Windows.Forms.Button();
            this._Add = new System.Windows.Forms.Button();
            this._Sub = new System.Windows.Forms.Button();
            this._Calculate = new System.Windows.Forms.Button();
            this._CE = new System.Windows.Forms.Button();
            this._Clear = new System.Windows.Forms.Button();
            this._BS = new System.Windows.Forms.Button();
            this._Nine = new System.Windows.Forms.Button();
            this._Fact = new System.Windows.Forms.Button();
            this._Six = new System.Windows.Forms.Button();
            this._Three = new System.Windows.Forms.Button();
            this._Point = new System.Windows.Forms.Button();
            this._Zero = new System.Windows.Forms.Button();
            this._Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(7, 6);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(271, 20);
            this.Input.TabIndex = 0;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // _Exp
            // 
            this._Exp.BackColor = System.Drawing.Color.Yellow;
            this._Exp.Location = new System.Drawing.Point(53, 128);
            this._Exp.Name = "_Exp";
            this._Exp.Size = new System.Drawing.Size(40, 40);
            this._Exp.TabIndex = 1;
            this._Exp.Text = "Exp";
            this._Exp.UseVisualStyleBackColor = false;
            this._Exp.Click += new System.EventHandler(this._Exp_Click);
            // 
            // _Seven
            // 
            this._Seven.BackColor = System.Drawing.Color.Cyan;
            this._Seven.Location = new System.Drawing.Point(100, 82);
            this._Seven.Name = "_Seven";
            this._Seven.Size = new System.Drawing.Size(40, 40);
            this._Seven.TabIndex = 2;
            this._Seven.Text = "7";
            this._Seven.UseVisualStyleBackColor = false;
            this._Seven.Click += new System.EventHandler(this._Seven_Click);
            // 
            // _Mult
            // 
            this._Mult.BackColor = System.Drawing.Color.Red;
            this._Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Mult.Location = new System.Drawing.Point(238, 82);
            this._Mult.Name = "_Mult";
            this._Mult.Size = new System.Drawing.Size(40, 40);
            this._Mult.TabIndex = 3;
            this._Mult.Text = "*";
            this._Mult.UseVisualStyleBackColor = false;
            this._Mult.Click += new System.EventHandler(this._Mult_Click);
            // 
            // _Eight
            // 
            this._Eight.BackColor = System.Drawing.Color.Blue;
            this._Eight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._Eight.Location = new System.Drawing.Point(146, 82);
            this._Eight.Name = "_Eight";
            this._Eight.Size = new System.Drawing.Size(40, 40);
            this._Eight.TabIndex = 4;
            this._Eight.Text = "8";
            this._Eight.UseVisualStyleBackColor = false;
            this._Eight.Click += new System.EventHandler(this._Eight_Click);
            // 
            // _Five
            // 
            this._Five.BackColor = System.Drawing.Color.Cyan;
            this._Five.Location = new System.Drawing.Point(146, 128);
            this._Five.Name = "_Five";
            this._Five.Size = new System.Drawing.Size(40, 40);
            this._Five.TabIndex = 5;
            this._Five.Text = "5";
            this._Five.UseVisualStyleBackColor = false;
            this._Five.Click += new System.EventHandler(this._Five_Click);
            // 
            // _Div
            // 
            this._Div.BackColor = System.Drawing.Color.Purple;
            this._Div.Location = new System.Drawing.Point(238, 36);
            this._Div.Name = "_Div";
            this._Div.Size = new System.Drawing.Size(40, 40);
            this._Div.TabIndex = 6;
            this._Div.Text = "/";
            this._Div.UseVisualStyleBackColor = false;
            this._Div.Click += new System.EventHandler(this._Div_Click);
            // 
            // _Four
            // 
            this._Four.BackColor = System.Drawing.Color.Lime;
            this._Four.Location = new System.Drawing.Point(100, 128);
            this._Four.Name = "_Four";
            this._Four.Size = new System.Drawing.Size(40, 40);
            this._Four.TabIndex = 7;
            this._Four.Text = "4";
            this._Four.UseVisualStyleBackColor = false;
            this._Four.Click += new System.EventHandler(this._Four_Click);
            // 
            // _One
            // 
            this._One.BackColor = System.Drawing.Color.Yellow;
            this._One.Location = new System.Drawing.Point(100, 174);
            this._One.Name = "_One";
            this._One.Size = new System.Drawing.Size(40, 40);
            this._One.TabIndex = 8;
            this._One.Text = "1";
            this._One.UseVisualStyleBackColor = false;
            this._One.Click += new System.EventHandler(this._One_Click);
            // 
            // _Two
            // 
            this._Two.BackColor = System.Drawing.Color.Lime;
            this._Two.Location = new System.Drawing.Point(146, 174);
            this._Two.Name = "_Two";
            this._Two.Size = new System.Drawing.Size(40, 40);
            this._Two.TabIndex = 9;
            this._Two.Text = "2";
            this._Two.UseVisualStyleBackColor = false;
            this._Two.Click += new System.EventHandler(this._Two_Click);
            // 
            // _Sqr
            // 
            this._Sqr.BackColor = System.Drawing.Color.Lime;
            this._Sqr.Location = new System.Drawing.Point(7, 36);
            this._Sqr.Name = "_Sqr";
            this._Sqr.Size = new System.Drawing.Size(40, 40);
            this._Sqr.TabIndex = 11;
            this._Sqr.Text = "x^2";
            this._Sqr.UseVisualStyleBackColor = false;
            this._Sqr.Click += new System.EventHandler(this._Sqr_Click);
            // 
            // _Pow
            // 
            this._Pow.BackColor = System.Drawing.Color.Cyan;
            this._Pow.Location = new System.Drawing.Point(54, 36);
            this._Pow.Name = "_Pow";
            this._Pow.Size = new System.Drawing.Size(40, 40);
            this._Pow.TabIndex = 12;
            this._Pow.Text = "x^3";
            this._Pow.UseVisualStyleBackColor = false;
            this._Pow.Click += new System.EventHandler(this._Pow_Click);
            // 
            // _Sin
            // 
            this._Sin.BackColor = System.Drawing.Color.Blue;
            this._Sin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._Sin.Location = new System.Drawing.Point(100, 36);
            this._Sin.Name = "_Sin";
            this._Sin.Size = new System.Drawing.Size(40, 40);
            this._Sin.TabIndex = 13;
            this._Sin.Text = "Sin";
            this._Sin.UseVisualStyleBackColor = false;
            this._Sin.Click += new System.EventHandler(this._Sin_Click);
            // 
            // _Cos
            // 
            this._Cos.BackColor = System.Drawing.Color.Fuchsia;
            this._Cos.Location = new System.Drawing.Point(146, 36);
            this._Cos.Name = "_Cos";
            this._Cos.Size = new System.Drawing.Size(40, 40);
            this._Cos.TabIndex = 14;
            this._Cos.Text = "Cos";
            this._Cos.UseVisualStyleBackColor = false;
            this._Cos.Click += new System.EventHandler(this._Cos_Click);
            // 
            // _Tan
            // 
            this._Tan.BackColor = System.Drawing.Color.Red;
            this._Tan.Location = new System.Drawing.Point(192, 36);
            this._Tan.Name = "_Tan";
            this._Tan.Size = new System.Drawing.Size(40, 40);
            this._Tan.TabIndex = 15;
            this._Tan.Text = "Tan";
            this._Tan.UseVisualStyleBackColor = false;
            this._Tan.Click += new System.EventHandler(this._Tan_Click);
            // 
            // _Sqrt
            // 
            this._Sqrt.BackColor = System.Drawing.Color.Yellow;
            this._Sqrt.Location = new System.Drawing.Point(7, 82);
            this._Sqrt.Name = "_Sqrt";
            this._Sqrt.Size = new System.Drawing.Size(40, 40);
            this._Sqrt.TabIndex = 16;
            this._Sqrt.Text = "Sqrt";
            this._Sqrt.UseVisualStyleBackColor = false;
            this._Sqrt.Click += new System.EventHandler(this._Sqrt_Click);
            // 
            // _Ln
            // 
            this._Ln.BackColor = System.Drawing.Color.Lime;
            this._Ln.Location = new System.Drawing.Point(53, 82);
            this._Ln.Name = "_Ln";
            this._Ln.Size = new System.Drawing.Size(40, 40);
            this._Ln.TabIndex = 17;
            this._Ln.Text = "Ln";
            this._Ln.UseVisualStyleBackColor = false;
            this._Ln.Click += new System.EventHandler(this._Ln_Click);
            // 
            // _Add
            // 
            this._Add.BackColor = System.Drawing.Color.Blue;
            this._Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._Add.Location = new System.Drawing.Point(238, 174);
            this._Add.Name = "_Add";
            this._Add.Size = new System.Drawing.Size(40, 40);
            this._Add.TabIndex = 18;
            this._Add.Text = "+";
            this._Add.UseVisualStyleBackColor = false;
            this._Add.Click += new System.EventHandler(this._Add_Click);
            // 
            // _Sub
            // 
            this._Sub.BackColor = System.Drawing.Color.Fuchsia;
            this._Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Sub.Location = new System.Drawing.Point(238, 127);
            this._Sub.Name = "_Sub";
            this._Sub.Size = new System.Drawing.Size(40, 40);
            this._Sub.TabIndex = 19;
            this._Sub.Text = "-";
            this._Sub.UseVisualStyleBackColor = false;
            this._Sub.Click += new System.EventHandler(this._Sub_Click);
            // 
            // _Calculate
            // 
            this._Calculate.BackColor = System.Drawing.Color.OrangeRed;
            this._Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Calculate.Location = new System.Drawing.Point(100, 218);
            this._Calculate.Name = "_Calculate";
            this._Calculate.Size = new System.Drawing.Size(86, 40);
            this._Calculate.TabIndex = 20;
            this._Calculate.Text = "=";
            this._Calculate.UseVisualStyleBackColor = false;
            this._Calculate.Click += new System.EventHandler(this._Calculate_Click);
            // 
            // _CE
            // 
            this._CE.BackColor = System.Drawing.Color.OrangeRed;
            this._CE.Location = new System.Drawing.Point(7, 128);
            this._CE.Name = "_CE";
            this._CE.Size = new System.Drawing.Size(40, 40);
            this._CE.TabIndex = 21;
            this._CE.Text = "CE";
            this._CE.UseVisualStyleBackColor = false;
            this._CE.Click += new System.EventHandler(this._CE_Click);
            // 
            // _Clear
            // 
            this._Clear.BackColor = System.Drawing.Color.Red;
            this._Clear.Location = new System.Drawing.Point(7, 174);
            this._Clear.Name = "_Clear";
            this._Clear.Size = new System.Drawing.Size(40, 40);
            this._Clear.TabIndex = 22;
            this._Clear.Text = "C";
            this._Clear.UseVisualStyleBackColor = false;
            this._Clear.Click += new System.EventHandler(this._Clear_Click);
            // 
            // _BS
            // 
            this._BS.BackColor = System.Drawing.Color.Red;
            this._BS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._BS.Location = new System.Drawing.Point(53, 218);
            this._BS.Name = "_BS";
            this._BS.Size = new System.Drawing.Size(40, 40);
            this._BS.TabIndex = 23;
            this._BS.Text = "<-";
            this._BS.UseVisualStyleBackColor = false;
            this._BS.Click += new System.EventHandler(this._BS_Click);
            // 
            // _Nine
            // 
            this._Nine.BackColor = System.Drawing.Color.Fuchsia;
            this._Nine.Location = new System.Drawing.Point(192, 82);
            this._Nine.Name = "_Nine";
            this._Nine.Size = new System.Drawing.Size(40, 40);
            this._Nine.TabIndex = 24;
            this._Nine.Text = "9";
            this._Nine.UseVisualStyleBackColor = false;
            this._Nine.Click += new System.EventHandler(this._Nine_Click);
            // 
            // _Fact
            // 
            this._Fact.BackColor = System.Drawing.Color.OrangeRed;
            this._Fact.Location = new System.Drawing.Point(53, 174);
            this._Fact.Name = "_Fact";
            this._Fact.Size = new System.Drawing.Size(40, 40);
            this._Fact.TabIndex = 25;
            this._Fact.Text = "n!";
            this._Fact.UseVisualStyleBackColor = false;
            this._Fact.Click += new System.EventHandler(this._Fact_Click);
            // 
            // _Six
            // 
            this._Six.BackColor = System.Drawing.Color.Blue;
            this._Six.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._Six.Location = new System.Drawing.Point(192, 128);
            this._Six.Name = "_Six";
            this._Six.Size = new System.Drawing.Size(40, 40);
            this._Six.TabIndex = 26;
            this._Six.Text = "6";
            this._Six.UseVisualStyleBackColor = false;
            this._Six.Click += new System.EventHandler(this._Six_Click);
            // 
            // _Three
            // 
            this._Three.BackColor = System.Drawing.Color.Cyan;
            this._Three.Location = new System.Drawing.Point(192, 174);
            this._Three.Name = "_Three";
            this._Three.Size = new System.Drawing.Size(40, 40);
            this._Three.TabIndex = 27;
            this._Three.Text = "3";
            this._Three.UseVisualStyleBackColor = false;
            this._Three.Click += new System.EventHandler(this._Three_Click);
            // 
            // _Point
            // 
            this._Point.BackColor = System.Drawing.Color.Cyan;
            this._Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Point.Location = new System.Drawing.Point(238, 219);
            this._Point.Name = "_Point";
            this._Point.Size = new System.Drawing.Size(40, 39);
            this._Point.TabIndex = 28;
            this._Point.TabStop = false;
            this._Point.Text = ",";
            this._Point.UseVisualStyleBackColor = false;
            this._Point.Click += new System.EventHandler(this._Point_Click);
            // 
            // _Zero
            // 
            this._Zero.BackColor = System.Drawing.Color.Lime;
            this._Zero.Location = new System.Drawing.Point(192, 219);
            this._Zero.Name = "_Zero";
            this._Zero.Size = new System.Drawing.Size(40, 39);
            this._Zero.TabIndex = 29;
            this._Zero.Text = "0";
            this._Zero.UseVisualStyleBackColor = false;
            this._Zero.Click += new System.EventHandler(this._Zero_Click);
            // 
            // _Exit
            // 
            this._Exit.BackColor = System.Drawing.Color.Red;
            this._Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Exit.Location = new System.Drawing.Point(7, 218);
            this._Exit.Name = "_Exit";
            this._Exit.Size = new System.Drawing.Size(40, 40);
            this._Exit.TabIndex = 30;
            this._Exit.Text = "Exit";
            this._Exit.UseVisualStyleBackColor = false;
            this._Exit.Click += new System.EventHandler(this._Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(285, 267);
            this.Controls.Add(this._Exit);
            this.Controls.Add(this._Zero);
            this.Controls.Add(this._Point);
            this.Controls.Add(this._Three);
            this.Controls.Add(this._Six);
            this.Controls.Add(this._Fact);
            this.Controls.Add(this._Nine);
            this.Controls.Add(this._BS);
            this.Controls.Add(this._Clear);
            this.Controls.Add(this._CE);
            this.Controls.Add(this._Calculate);
            this.Controls.Add(this._Sub);
            this.Controls.Add(this._Add);
            this.Controls.Add(this._Ln);
            this.Controls.Add(this._Sqrt);
            this.Controls.Add(this._Tan);
            this.Controls.Add(this._Cos);
            this.Controls.Add(this._Sin);
            this.Controls.Add(this._Pow);
            this.Controls.Add(this._Sqr);
            this.Controls.Add(this._Two);
            this.Controls.Add(this._One);
            this.Controls.Add(this._Four);
            this.Controls.Add(this._Div);
            this.Controls.Add(this._Five);
            this.Controls.Add(this._Eight);
            this.Controls.Add(this._Mult);
            this.Controls.Add(this._Seven);
            this.Controls.Add(this._Exp);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button _Exp;
        private System.Windows.Forms.Button _Seven;
        private System.Windows.Forms.Button _Mult;
        private System.Windows.Forms.Button _Eight;
        private System.Windows.Forms.Button _Five;
        private System.Windows.Forms.Button _Div;
        private System.Windows.Forms.Button _Four;
        private System.Windows.Forms.Button _One;
        private System.Windows.Forms.Button _Two;
        private System.Windows.Forms.Button _Sqr;
        private System.Windows.Forms.Button _Pow;
        private System.Windows.Forms.Button _Sin;
        private System.Windows.Forms.Button _Cos;
        private System.Windows.Forms.Button _Tan;
        private System.Windows.Forms.Button _Sqrt;
        private System.Windows.Forms.Button _Ln;
        private System.Windows.Forms.Button _Add;
        private System.Windows.Forms.Button _Sub;
        private System.Windows.Forms.Button _Calculate;
        private System.Windows.Forms.Button _CE;
        private System.Windows.Forms.Button _Clear;
        private System.Windows.Forms.Button _BS;
        private System.Windows.Forms.Button _Nine;
        private System.Windows.Forms.Button _Fact;
        private System.Windows.Forms.Button _Six;
        private System.Windows.Forms.Button _Three;
        private System.Windows.Forms.Button _Point;
        private System.Windows.Forms.Button _Zero;
        private System.Windows.Forms.Button _Exit;
    }
}

