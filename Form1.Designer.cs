namespace FIRfilter
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
            this.dfPictureBox = new System.Windows.Forms.PictureBox();
            this.signalButton = new System.Windows.Forms.Button();
            this.irButton = new System.Windows.Forms.Button();
            this.dfButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.irPictureBox = new System.Windows.Forms.PictureBox();
            this.signalPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.readFileButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dfPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.irPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dfPictureBox
            // 
            this.dfPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dfPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.dfPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dfPictureBox.Location = new System.Drawing.Point(2, 355);
            this.dfPictureBox.Name = "dfPictureBox";
            this.dfPictureBox.Size = new System.Drawing.Size(829, 150);
            this.dfPictureBox.TabIndex = 2;
            this.dfPictureBox.TabStop = false;
            // 
            // signalButton
            // 
            this.signalButton.Enabled = false;
            this.signalButton.Location = new System.Drawing.Point(2, 543);
            this.signalButton.Name = "signalButton";
            this.signalButton.Size = new System.Drawing.Size(79, 36);
            this.signalButton.TabIndex = 2;
            this.signalButton.Text = "Исходый сигнал";
            this.signalButton.UseVisualStyleBackColor = true;
            this.signalButton.Click += new System.EventHandler(this.signalButton_Click);
            // 
            // irButton
            // 
            this.irButton.Enabled = false;
            this.irButton.Location = new System.Drawing.Point(87, 543);
            this.irButton.Name = "irButton";
            this.irButton.Size = new System.Drawing.Size(76, 36);
            this.irButton.TabIndex = 3;
            this.irButton.Text = "Характеристика h(i)";
            this.irButton.UseVisualStyleBackColor = true;
            this.irButton.Click += new System.EventHandler(this.irButton_Click);
            // 
            // dfButton
            // 
            this.dfButton.Enabled = false;
            this.dfButton.Location = new System.Drawing.Point(169, 543);
            this.dfButton.Name = "dfButton";
            this.dfButton.Size = new System.Drawing.Size(49, 36);
            this.dfButton.TabIndex = 4;
            this.dfButton.Text = "ЦФ";
            this.dfButton.UseVisualStyleBackColor = true;
            this.dfButton.Click += new System.EventHandler(this.dfButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(224, 511);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 69);
            this.listBox1.TabIndex = 7;
            this.listBox1.TabStop = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(375, 511);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(145, 69);
            this.listBox2.TabIndex = 8;
            this.listBox2.TabStop = false;
            // 
            // irPictureBox
            // 
            this.irPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.irPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.irPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.irPictureBox.Location = new System.Drawing.Point(2, 188);
            this.irPictureBox.Name = "irPictureBox";
            this.irPictureBox.Size = new System.Drawing.Size(829, 150);
            this.irPictureBox.TabIndex = 9;
            this.irPictureBox.TabStop = false;
            // 
            // signalPictureBox
            // 
            this.signalPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.signalPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.signalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.signalPictureBox.Location = new System.Drawing.Point(2, 19);
            this.signalPictureBox.Name = "signalPictureBox";
            this.signalPictureBox.Size = new System.Drawing.Size(829, 150);
            this.signalPictureBox.TabIndex = 10;
            this.signalPictureBox.TabStop = false;
            this.signalPictureBox.VisibleChanged += new System.EventHandler(this.signalPictureBox_VisibleChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходный сигнал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Отсчеты импульсной характеристики h(i). Порядок фильтра M = 65";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Сигнал после ЦФ";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(677, 544);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(154, 36);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Выход";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "dat";
            this.openFileDialog1.Filter = "DAT Files (*.dat)|*.dat|Все файлы (*.*)|*.*";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(526, 511);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(145, 69);
            this.listBox3.TabIndex = 11;
            this.listBox3.TabStop = false;
            // 
            // readFileButton
            // 
            this.readFileButton.Location = new System.Drawing.Point(2, 511);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(216, 26);
            this.readFileButton.TabIndex = 1;
            this.readFileButton.Text = "Чтение файла";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(680, 524);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(711, 524);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(742, 524);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(773, 524);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(804, 524);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 17);
            this.radioButton5.TabIndex = 16;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(677, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Выберите канал";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 583);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.signalPictureBox);
            this.Controls.Add(this.irPictureBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dfButton);
            this.Controls.Add(this.irButton);
            this.Controls.Add(this.signalButton);
            this.Controls.Add(this.dfPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Цифровая фильтрация методом ДПФ";
            ((System.ComponentModel.ISupportInitialize)(this.dfPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.irPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dfPictureBox;
        private System.Windows.Forms.Button signalButton;
        private System.Windows.Forms.Button irButton;
        private System.Windows.Forms.Button dfButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.PictureBox irPictureBox;
        private System.Windows.Forms.PictureBox signalPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label4;
    }
}

