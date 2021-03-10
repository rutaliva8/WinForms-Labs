
namespace lab1Redux
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.operation_label = new System.Windows.Forms.Label();
            this.base_label = new System.Windows.Forms.Label();
            this.and_btn = new System.Windows.Forms.Button();
            this.or_btn = new System.Windows.Forms.Button();
            this.xor_btn = new System.Windows.Forms.Button();
            this.not_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.base_btn = new System.Windows.Forms.Button();
            this.to2_btn = new System.Windows.Forms.Button();
            this.to10_btn = new System.Windows.Forms.Button();
            this.to8_btn = new System.Windows.Forms.Button();
            this.to16_btn = new System.Windows.Forms.Button();
            this.equals_btn = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.TextBox();
            this.output_field = new System.Windows.Forms.TextBox();
            this.invalid2 = new System.Windows.Forms.Label();
            this.invalid1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // operation_label
            // 
            this.operation_label.AutoSize = true;
            this.operation_label.Font = new System.Drawing.Font("Arial", 14F);
            this.operation_label.Location = new System.Drawing.Point(149, 11);
            this.operation_label.Name = "operation_label";
            this.operation_label.Size = new System.Drawing.Size(17, 22);
            this.operation_label.TabIndex = 1;
            this.operation_label.Text = "*";
            this.operation_label.Click += new System.EventHandler(this.operation_label_Click);
            // 
            // base_label
            // 
            this.base_label.AutoSize = true;
            this.base_label.Location = new System.Drawing.Point(319, 36);
            this.base_label.Name = "base_label";
            this.base_label.Size = new System.Drawing.Size(79, 13);
            this.base_label.TabIndex = 3;
            this.base_label.Text = "Current base: 2";
            // 
            // and_btn
            // 
            this.and_btn.Location = new System.Drawing.Point(23, 78);
            this.and_btn.Name = "and_btn";
            this.and_btn.Size = new System.Drawing.Size(75, 23);
            this.and_btn.TabIndex = 4;
            this.and_btn.Text = "AND";
            this.and_btn.UseMnemonic = false;
            this.and_btn.UseVisualStyleBackColor = true;
            this.and_btn.Click += new System.EventHandler(this.and_btn_Click);
            // 
            // or_btn
            // 
            this.or_btn.Location = new System.Drawing.Point(104, 78);
            this.or_btn.Name = "or_btn";
            this.or_btn.Size = new System.Drawing.Size(75, 23);
            this.or_btn.TabIndex = 4;
            this.or_btn.Text = "OR";
            this.or_btn.UseVisualStyleBackColor = true;
            this.or_btn.Click += new System.EventHandler(this.or_btn_Click);
            // 
            // xor_btn
            // 
            this.xor_btn.Location = new System.Drawing.Point(185, 78);
            this.xor_btn.Name = "xor_btn";
            this.xor_btn.Size = new System.Drawing.Size(75, 23);
            this.xor_btn.TabIndex = 4;
            this.xor_btn.Text = "XOR";
            this.xor_btn.UseVisualStyleBackColor = true;
            this.xor_btn.Click += new System.EventHandler(this.xor_btn_Click);
            // 
            // not_btn
            // 
            this.not_btn.Location = new System.Drawing.Point(266, 78);
            this.not_btn.Name = "not_btn";
            this.not_btn.Size = new System.Drawing.Size(75, 23);
            this.not_btn.TabIndex = 4;
            this.not_btn.Text = "NOT";
            this.not_btn.UseVisualStyleBackColor = true;
            this.not_btn.Click += new System.EventHandler(this.not_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(352, 78);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 4;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // base_btn
            // 
            this.base_btn.Location = new System.Drawing.Point(23, 107);
            this.base_btn.Name = "base_btn";
            this.base_btn.Size = new System.Drawing.Size(75, 23);
            this.base_btn.TabIndex = 4;
            this.base_btn.Text = "Change base";
            this.base_btn.UseVisualStyleBackColor = true;
            this.base_btn.Click += new System.EventHandler(this.base_btn_Click);
            // 
            // to2_btn
            // 
            this.to2_btn.Location = new System.Drawing.Point(104, 107);
            this.to2_btn.Name = "to2_btn";
            this.to2_btn.Size = new System.Drawing.Size(75, 23);
            this.to2_btn.TabIndex = 4;
            this.to2_btn.Text = "to 2 base";
            this.to2_btn.UseVisualStyleBackColor = true;
            this.to2_btn.Click += new System.EventHandler(this.to2_btn_Click);
            // 
            // to10_btn
            // 
            this.to10_btn.Location = new System.Drawing.Point(185, 107);
            this.to10_btn.Name = "to10_btn";
            this.to10_btn.Size = new System.Drawing.Size(75, 23);
            this.to10_btn.TabIndex = 4;
            this.to10_btn.Text = "to 10 base";
            this.to10_btn.UseVisualStyleBackColor = true;
            this.to10_btn.Click += new System.EventHandler(this.to10_btn_Click);
            // 
            // to8_btn
            // 
            this.to8_btn.Location = new System.Drawing.Point(266, 107);
            this.to8_btn.Name = "to8_btn";
            this.to8_btn.Size = new System.Drawing.Size(75, 23);
            this.to8_btn.TabIndex = 4;
            this.to8_btn.Text = "to 8 base";
            this.to8_btn.UseVisualStyleBackColor = true;
            this.to8_btn.Click += new System.EventHandler(this.to8_btn_Click);
            // 
            // to16_btn
            // 
            this.to16_btn.Location = new System.Drawing.Point(352, 107);
            this.to16_btn.Name = "to16_btn";
            this.to16_btn.Size = new System.Drawing.Size(75, 23);
            this.to16_btn.TabIndex = 4;
            this.to16_btn.Text = "to 16 base";
            this.to16_btn.UseVisualStyleBackColor = true;
            this.to16_btn.Click += new System.EventHandler(this.to16_btn_Click);
            // 
            // equals_btn
            // 
            this.equals_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equals_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.equals_btn.Location = new System.Drawing.Point(291, 11);
            this.equals_btn.Name = "equals_btn";
            this.equals_btn.Size = new System.Drawing.Size(24, 23);
            this.equals_btn.TabIndex = 4;
            this.equals_btn.Text = "=";
            this.equals_btn.UseVisualStyleBackColor = true;
            this.equals_btn.Click += new System.EventHandler(this.equals_btn_Click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(174, 13);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(111, 20);
            this.num2.TabIndex = 2;
            this.num2.TextChanged += new System.EventHandler(this.num2_TextChanged);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(26, 13);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(117, 20);
            this.num1.TabIndex = 2;
            this.num1.TextChanged += new System.EventHandler(this.num1_TextChanged);
            // 
            // output_field
            // 
            this.output_field.Location = new System.Drawing.Point(322, 13);
            this.output_field.Name = "output_field";
            this.output_field.ReadOnly = true;
            this.output_field.Size = new System.Drawing.Size(111, 20);
            this.output_field.TabIndex = 2;
            // 
            // invalid2
            // 
            this.invalid2.AutoSize = true;
            this.invalid2.BackColor = System.Drawing.Color.Red;
            this.invalid2.Location = new System.Drawing.Point(171, 36);
            this.invalid2.Name = "invalid2";
            this.invalid2.Size = new System.Drawing.Size(76, 13);
            this.invalid2.TabIndex = 5;
            this.invalid2.Text = "Invalid number";
            this.invalid2.Visible = false;
            // 
            // invalid1
            // 
            this.invalid1.AutoSize = true;
            this.invalid1.BackColor = System.Drawing.Color.Red;
            this.invalid1.Location = new System.Drawing.Point(23, 36);
            this.invalid1.Name = "invalid1";
            this.invalid1.Size = new System.Drawing.Size(76, 13);
            this.invalid1.TabIndex = 6;
            this.invalid1.Text = "Invalid number";
            this.invalid1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 174);
            this.Controls.Add(this.invalid1);
            this.Controls.Add(this.invalid2);
            this.Controls.Add(this.to16_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.to8_btn);
            this.Controls.Add(this.equals_btn);
            this.Controls.Add(this.not_btn);
            this.Controls.Add(this.to10_btn);
            this.Controls.Add(this.xor_btn);
            this.Controls.Add(this.to2_btn);
            this.Controls.Add(this.base_btn);
            this.Controls.Add(this.or_btn);
            this.Controls.Add(this.and_btn);
            this.Controls.Add(this.base_label);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.output_field);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.operation_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label operation_label;
        private System.Windows.Forms.Label base_label;
        private System.Windows.Forms.Button and_btn;
        private System.Windows.Forms.Button or_btn;
        private System.Windows.Forms.Button xor_btn;
        private System.Windows.Forms.Button not_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button base_btn;
        private System.Windows.Forms.Button to2_btn;
        private System.Windows.Forms.Button to10_btn;
        private System.Windows.Forms.Button to8_btn;
        private System.Windows.Forms.Button to16_btn;
        private System.Windows.Forms.Button equals_btn;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox output_field;
        private System.Windows.Forms.Label invalid2;
        private System.Windows.Forms.Label invalid1;
    }
}

