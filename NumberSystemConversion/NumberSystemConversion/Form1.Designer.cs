namespace NumberSystemConversion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputBase = new System.Windows.Forms.ComboBox();
            this.outputBase = new System.Windows.Forms.ComboBox();
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn07 = new System.Windows.Forms.Button();
            this.btn08 = new System.Windows.Forms.Button();
            this.btn09 = new System.Windows.Forms.Button();
            this.btn06 = new System.Windows.Forms.Button();
            this.btn05 = new System.Windows.Forms.Button();
            this.btn04 = new System.Windows.Forms.Button();
            this.btn03 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputBase
            // 
            this.inputBase.FormattingEnabled = true;
            this.inputBase.Location = new System.Drawing.Point(165, 95);
            this.inputBase.Name = "inputBase";
            this.inputBase.Size = new System.Drawing.Size(121, 24);
            this.inputBase.TabIndex = 0;
            this.inputBase.SelectedIndexChanged += new System.EventHandler(this.inputBase_SelectedIndexChanged);
            // 
            // outputBase
            // 
            this.outputBase.FormattingEnabled = true;
            this.outputBase.Location = new System.Drawing.Point(609, 99);
            this.outputBase.Name = "outputBase";
            this.outputBase.Size = new System.Drawing.Size(121, 24);
            this.outputBase.TabIndex = 1;
            this.outputBase.SelectedIndexChanged += new System.EventHandler(this.outputBase_SelectedIndexChanged);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(35, 27);
            this.inputBox.Name = "inputBox";
            this.inputBox.ReadOnly = true;
            this.inputBox.Size = new System.Drawing.Size(353, 56);
            this.inputBox.TabIndex = 2;
            this.inputBox.Text = "0";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(448, 27);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(305, 56);
            this.resultBox.TabIndex = 3;
            this.resultBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input Base:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result Base:";
            // 
            // btn07
            // 
            this.btn07.Location = new System.Drawing.Point(35, 159);
            this.btn07.Name = "btn07";
            this.btn07.Size = new System.Drawing.Size(49, 49);
            this.btn07.TabIndex = 6;
            this.btn07.Text = "7";
            this.btn07.UseVisualStyleBackColor = true;
            this.btn07.Click += new System.EventHandler(this.btn07_Click);
            // 
            // btn08
            // 
            this.btn08.Location = new System.Drawing.Point(111, 159);
            this.btn08.Name = "btn08";
            this.btn08.Size = new System.Drawing.Size(49, 49);
            this.btn08.TabIndex = 7;
            this.btn08.Text = "8";
            this.btn08.UseVisualStyleBackColor = true;
            this.btn08.Click += new System.EventHandler(this.btn08_Click);
            // 
            // btn09
            // 
            this.btn09.Location = new System.Drawing.Point(186, 159);
            this.btn09.Name = "btn09";
            this.btn09.Size = new System.Drawing.Size(49, 49);
            this.btn09.TabIndex = 8;
            this.btn09.Text = "9";
            this.btn09.UseVisualStyleBackColor = true;
            this.btn09.Click += new System.EventHandler(this.btn09_Click);
            // 
            // btn06
            // 
            this.btn06.Location = new System.Drawing.Point(186, 234);
            this.btn06.Name = "btn06";
            this.btn06.Size = new System.Drawing.Size(49, 49);
            this.btn06.TabIndex = 11;
            this.btn06.Text = "6";
            this.btn06.UseVisualStyleBackColor = true;
            this.btn06.Click += new System.EventHandler(this.btn06_Click);
            // 
            // btn05
            // 
            this.btn05.Location = new System.Drawing.Point(111, 234);
            this.btn05.Name = "btn05";
            this.btn05.Size = new System.Drawing.Size(49, 49);
            this.btn05.TabIndex = 10;
            this.btn05.Text = "5";
            this.btn05.UseVisualStyleBackColor = true;
            this.btn05.Click += new System.EventHandler(this.btn05_Click);
            // 
            // btn04
            // 
            this.btn04.Location = new System.Drawing.Point(35, 234);
            this.btn04.Name = "btn04";
            this.btn04.Size = new System.Drawing.Size(49, 49);
            this.btn04.TabIndex = 9;
            this.btn04.Text = "4";
            this.btn04.UseVisualStyleBackColor = true;
            this.btn04.Click += new System.EventHandler(this.btn04_Click);
            // 
            // btn03
            // 
            this.btn03.Location = new System.Drawing.Point(186, 310);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(49, 49);
            this.btn03.TabIndex = 14;
            this.btn03.Text = "3";
            this.btn03.UseVisualStyleBackColor = true;
            this.btn03.Click += new System.EventHandler(this.btn03_Click);
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(111, 310);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(49, 49);
            this.btn02.TabIndex = 13;
            this.btn02.Text = "2";
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.btn02_Click);
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(35, 310);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(49, 49);
            this.btn01.TabIndex = 12;
            this.btn01.Text = "1";
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.btn01_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(186, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(49, 49);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "C";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(111, 389);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(49, 49);
            this.btn00.TabIndex = 16;
            this.btn00.Text = "0";
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.btn00_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(35, 389);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(49, 49);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(461, 245);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(49, 49);
            this.btnC.TabIndex = 20;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(386, 245);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(49, 49);
            this.btnB.TabIndex = 19;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(310, 245);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(49, 49);
            this.btnA.TabIndex = 18;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(618, 245);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(49, 49);
            this.btnE.TabIndex = 22;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(543, 245);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(49, 49);
            this.btnD.TabIndex = 21;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(691, 245);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(49, 49);
            this.btnF.TabIndex = 23;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btn00);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn03);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn06);
            this.Controls.Add(this.btn05);
            this.Controls.Add(this.btn04);
            this.Controls.Add(this.btn09);
            this.Controls.Add(this.btn08);
            this.Controls.Add(this.btn07);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.outputBase);
            this.Controls.Add(this.inputBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox inputBase;
        private System.Windows.Forms.ComboBox outputBase;
        private System.Windows.Forms.RichTextBox inputBox;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn07;
        private System.Windows.Forms.Button btn08;
        private System.Windows.Forms.Button btn09;
        private System.Windows.Forms.Button btn06;
        private System.Windows.Forms.Button btn05;
        private System.Windows.Forms.Button btn04;
        private System.Windows.Forms.Button btn03;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnF;
    }
}

