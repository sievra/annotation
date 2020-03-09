namespace annotation
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
            this.numUDPercent = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.gBPercent = new System.Windows.Forms.GroupBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnIntroduction = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPercent)).BeginInit();
            this.gBPercent.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // numUDPercent
            // 
            this.numUDPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUDPercent.Location = new System.Drawing.Point(7, 40);
            this.numUDPercent.Name = "numUDPercent";
            this.numUDPercent.Size = new System.Drawing.Size(131, 26);
            this.numUDPercent.TabIndex = 0;
            this.numUDPercent.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Процент сжатия";
            // 
            // gBPercent
            // 
            this.gBPercent.Controls.Add(this.label1);
            this.gBPercent.Controls.Add(this.numUDPercent);
            this.gBPercent.Location = new System.Drawing.Point(12, 12);
            this.gBPercent.Name = "gBPercent";
            this.gBPercent.Size = new System.Drawing.Size(147, 80);
            this.gBPercent.TabIndex = 2;
            this.gBPercent.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(828, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Исходный текст";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(12, 98);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 307);
            this.tabControl1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(-1, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(832, 283);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(828, 281);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Предложения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(-1, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(832, 283);
            this.textBox2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(828, 281);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Токенизация";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(-1, 0);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(832, 283);
            this.textBox3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(828, 281);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Удаление стоп-слов";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(-1, 0);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(832, 283);
            this.textBox4.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBox5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(828, 281);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Ранжирование токенов";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(-1, 0);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(832, 283);
            this.textBox5.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.textBox6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(828, 281);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Ключевые слова";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(-1, 0);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox6.Size = new System.Drawing.Size(832, 283);
            this.textBox6.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.textBox7);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(828, 281);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Взвешивание предложений";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(-1, 0);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox7.Size = new System.Drawing.Size(832, 283);
            this.textBox7.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.textBox8);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(828, 281);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Сжатый текст";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(-1, 0);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox8.Size = new System.Drawing.Size(832, 283);
            this.textBox8.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerate.Location = new System.Drawing.Point(165, 18);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(120, 74);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Генерация";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnRed
            // 
            this.btnRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRed.Location = new System.Drawing.Point(336, 18);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(120, 74);
            this.btnRed.TabIndex = 5;
            this.btnRed.Text = "Красная шапочка";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnIntroduction
            // 
            this.btnIntroduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIntroduction.Location = new System.Drawing.Point(479, 18);
            this.btnIntroduction.Name = "btnIntroduction";
            this.btnIntroduction.Size = new System.Drawing.Size(120, 74);
            this.btnIntroduction.TabIndex = 6;
            this.btnIntroduction.Text = "Введение";
            this.btnIntroduction.UseVisualStyleBackColor = true;
            this.btnIntroduction.Click += new System.EventHandler(this.btnIntroduction_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 409);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(835, 23);
            this.progressBar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 439);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnIntroduction);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gBPercent);
            this.Name = "Form1";
            this.Text = "Создание аннотации";
            ((System.ComponentModel.ISupportInitialize)(this.numUDPercent)).EndInit();
            this.gBPercent.ResumeLayout(false);
            this.gBPercent.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUDPercent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBPercent;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnIntroduction;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

