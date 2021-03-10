
namespace lab1
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
            this.and_btn = new System.Windows.Forms.Button();
            this.to2_btn = new System.Windows.Forms.Button();
            this.or_btn = new System.Windows.Forms.Button();
            this.to10_btn = new System.Windows.Forms.Button();
            this.change_base_btn = new System.Windows.Forms.Button();
            this.not_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.xor_btn = new System.Windows.Forms.Button();
            this.to16_btn = new System.Windows.Forms.Button();
            this.to8_btn = new System.Windows.Forms.Button();
            this.zero_btn = new System.Windows.Forms.Button();
            this.one_btn = new System.Windows.Forms.Button();
            this.output_field = new System.Windows.Forms.RichTextBox();
            this.base_label = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // and_btn
            // 
            this.and_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.and_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.and_btn.Location = new System.Drawing.Point(37, 271);
            this.and_btn.Name = "and_btn";
            this.and_btn.Size = new System.Drawing.Size(109, 64);
            this.and_btn.TabIndex = 3;
            this.and_btn.Text = "AND";
            this.and_btn.UseVisualStyleBackColor = true;
            this.and_btn.Click += new System.EventHandler(this.and_btn_Click);
            // 
            // to2_btn
            // 
            this.to2_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.to2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.to2_btn.Location = new System.Drawing.Point(37, 201);
            this.to2_btn.Name = "to2_btn";
            this.to2_btn.Size = new System.Drawing.Size(109, 64);
            this.to2_btn.TabIndex = 4;
            this.to2_btn.Text = "2 base";
            this.to2_btn.UseVisualStyleBackColor = true;
            this.to2_btn.Click += new System.EventHandler(this.to2_btn_Click);
            // 
            // or_btn
            // 
            this.or_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.or_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.or_btn.Location = new System.Drawing.Point(152, 271);
            this.or_btn.Name = "or_btn";
            this.or_btn.Size = new System.Drawing.Size(109, 64);
            this.or_btn.TabIndex = 5;
            this.or_btn.Text = "OR";
            this.or_btn.UseVisualStyleBackColor = true;
            this.or_btn.Click += new System.EventHandler(this.or_btn_Click);
            // 
            // to10_btn
            // 
            this.to10_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.to10_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.to10_btn.Location = new System.Drawing.Point(152, 201);
            this.to10_btn.Name = "to10_btn";
            this.to10_btn.Size = new System.Drawing.Size(109, 64);
            this.to10_btn.TabIndex = 6;
            this.to10_btn.Text = "10 base";
            this.to10_btn.UseVisualStyleBackColor = true;
            this.to10_btn.Click += new System.EventHandler(this.to10_btn_Click);
            // 
            // change_base_btn
            // 
            this.change_base_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.change_base_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.change_base_btn.Location = new System.Drawing.Point(382, 131);
            this.change_base_btn.Name = "change_base_btn";
            this.change_base_btn.Size = new System.Drawing.Size(109, 64);
            this.change_base_btn.TabIndex = 7;
            this.change_base_btn.Text = "Change base";
            this.change_base_btn.UseVisualStyleBackColor = true;
            this.change_base_btn.Click += new System.EventHandler(this.change_base_btn_Click);
            // 
            // not_btn
            // 
            this.not_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.not_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.not_btn.Location = new System.Drawing.Point(382, 271);
            this.not_btn.Name = "not_btn";
            this.not_btn.Size = new System.Drawing.Size(109, 64);
            this.not_btn.TabIndex = 8;
            this.not_btn.Text = "NOT";
            this.not_btn.UseVisualStyleBackColor = true;
            this.not_btn.Click += new System.EventHandler(this.not_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clear_btn.Location = new System.Drawing.Point(267, 131);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(109, 64);
            this.clear_btn.TabIndex = 9;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // xor_btn
            // 
            this.xor_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xor_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.xor_btn.Location = new System.Drawing.Point(267, 271);
            this.xor_btn.Name = "xor_btn";
            this.xor_btn.Size = new System.Drawing.Size(109, 64);
            this.xor_btn.TabIndex = 10;
            this.xor_btn.Text = "XOR";
            this.xor_btn.UseVisualStyleBackColor = true;
            this.xor_btn.Click += new System.EventHandler(this.xor_btn_Click);
            // 
            // to16_btn
            // 
            this.to16_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.to16_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.to16_btn.Location = new System.Drawing.Point(382, 201);
            this.to16_btn.Name = "to16_btn";
            this.to16_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.to16_btn.Size = new System.Drawing.Size(109, 64);
            this.to16_btn.TabIndex = 11;
            this.to16_btn.Text = "16 base";
            this.to16_btn.UseVisualStyleBackColor = true;
            this.to16_btn.Click += new System.EventHandler(this.to16_btn_Click);
            // 
            // to8_btn
            // 
            this.to8_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.to8_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.to8_btn.Location = new System.Drawing.Point(267, 201);
            this.to8_btn.Name = "to8_btn";
            this.to8_btn.Size = new System.Drawing.Size(109, 64);
            this.to8_btn.TabIndex = 12;
            this.to8_btn.Text = "8 base";
            this.to8_btn.UseVisualStyleBackColor = true;
            this.to8_btn.Click += new System.EventHandler(this.to8_btn_Click);
            // 
            // zero_btn
            // 
            this.zero_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zero_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.zero_btn.Location = new System.Drawing.Point(152, 131);
            this.zero_btn.Name = "zero_btn";
            this.zero_btn.Size = new System.Drawing.Size(109, 64);
            this.zero_btn.TabIndex = 13;
            this.zero_btn.Text = "0";
            this.zero_btn.UseVisualStyleBackColor = true;
            this.zero_btn.Click += new System.EventHandler(this.zero_btn_Click_1);
            // 
            // one_btn
            // 
            this.one_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.one_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.one_btn.Location = new System.Drawing.Point(37, 131);
            this.one_btn.Name = "one_btn";
            this.one_btn.Size = new System.Drawing.Size(109, 64);
            this.one_btn.TabIndex = 14;
            this.one_btn.Text = "1";
            this.one_btn.UseVisualStyleBackColor = true;
            this.one_btn.Click += new System.EventHandler(this.one_btn_Click);
            // 
            // output_field
            // 
            this.output_field.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.output_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.output_field.Location = new System.Drawing.Point(37, 29);
            this.output_field.Name = "output_field";
            this.output_field.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.output_field.Size = new System.Drawing.Size(454, 96);
            this.output_field.TabIndex = 2;
            this.output_field.Text = "";
            this.output_field.TextChanged += new System.EventHandler(this.output_field_TextChanged);
            // 
            // base_label
            // 
            this.base_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.base_label.AutoSize = true;
            this.base_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.base_label.Location = new System.Drawing.Point(33, 6);
            this.base_label.Name = "base_label";
            this.base_label.Size = new System.Drawing.Size(118, 20);
            this.base_label.TabIndex = 15;
            this.base_label.Text = "Current base: 2";
            this.base_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // error_label
            // 
            this.error_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.error_label.Location = new System.Drawing.Point(379, 6);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(112, 20);
            this.error_label.TabIndex = 15;
            this.error_label.Text = "Invalid number";
            this.error_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.error_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 349);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.base_label);
            this.Controls.Add(this.and_btn);
            this.Controls.Add(this.to2_btn);
            this.Controls.Add(this.or_btn);
            this.Controls.Add(this.to10_btn);
            this.Controls.Add(this.change_base_btn);
            this.Controls.Add(this.not_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.xor_btn);
            this.Controls.Add(this.to16_btn);
            this.Controls.Add(this.to8_btn);
            this.Controls.Add(this.zero_btn);
            this.Controls.Add(this.one_btn);
            this.Controls.Add(this.output_field);
            this.Name = "Form1";
            this.Text = "Mega Ultra Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button and_btn;
        private System.Windows.Forms.Button to2_btn;
        private System.Windows.Forms.Button or_btn;
        private System.Windows.Forms.Button to10_btn;
        private System.Windows.Forms.Button change_base_btn;
        private System.Windows.Forms.Button not_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button xor_btn;
        private System.Windows.Forms.Button to16_btn;
        private System.Windows.Forms.Button to8_btn;
        private System.Windows.Forms.Button zero_btn;
        private System.Windows.Forms.Button one_btn;
        private System.Windows.Forms.RichTextBox output_field;
        private System.Windows.Forms.Label base_label;
        private System.Windows.Forms.Label error_label;
    }
}

