namespace WinFormsApp6
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
            this.btnclear = new System.Windows.Forms.Button();
            this.txtstore = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btndevide = new System.Windows.Forms.Button();
            this.btnrd = new System.Windows.Forms.Button();
            this.btnclear2 = new System.Windows.Forms.Button();
            this.txtresualt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnclear.Location = new System.Drawing.Point(12, 143);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 70);
            this.btnclear.TabIndex = 0;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtstore
            // 
            this.txtstore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtstore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtstore.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtstore.Location = new System.Drawing.Point(12, 70);
            this.txtstore.Name = "txtstore";
            this.txtstore.Size = new System.Drawing.Size(318, 64);
            this.txtstore.TabIndex = 1;
            this.txtstore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtstore.TextChanged += new System.EventHandler(this.txtstore_TextChanged);
            // 
            // btn7
            // 
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(12, 219);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 70);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(12, 371);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 70);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(12, 295);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 70);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn0
            // 
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(12, 447);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 70);
            this.btn0.TabIndex = 5;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btndot
            // 
            this.btndot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btndot.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btndot.Location = new System.Drawing.Point(93, 447);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(75, 70);
            this.btndot.TabIndex = 9;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            this.btndot.Click += new System.EventHandler(this.btndot_Click);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(93, 371);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 70);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(93, 295);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 70);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(93, 219);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 70);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btnequal
            // 
            this.btnequal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnequal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnequal.Location = new System.Drawing.Point(174, 447);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(156, 70);
            this.btnequal.TabIndex = 13;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(174, 371);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 70);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(174, 295);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 70);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn9
            // 
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(174, 219);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 70);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnplus
            // 
            this.btnplus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnplus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnplus.Location = new System.Drawing.Point(255, 371);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(75, 70);
            this.btnplus.TabIndex = 17;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnmin
            // 
            this.btnmin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnmin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmin.Location = new System.Drawing.Point(255, 295);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(75, 70);
            this.btnmin.TabIndex = 16;
            this.btnmin.Text = "-";
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnmulti.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmulti.Location = new System.Drawing.Point(255, 219);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(75, 70);
            this.btnmulti.TabIndex = 15;
            this.btnmulti.Text = "X";
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btndevide
            // 
            this.btndevide.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btndevide.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btndevide.Location = new System.Drawing.Point(255, 143);
            this.btndevide.Name = "btndevide";
            this.btndevide.Size = new System.Drawing.Size(75, 70);
            this.btndevide.TabIndex = 14;
            this.btndevide.Text = "/";
            this.btndevide.UseVisualStyleBackColor = true;
            this.btndevide.Click += new System.EventHandler(this.btndevide_Click);
            // 
            // btnrd
            // 
            this.btnrd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnrd.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnrd.Location = new System.Drawing.Point(174, 143);
            this.btnrd.Name = "btnrd";
            this.btnrd.Size = new System.Drawing.Size(75, 70);
            this.btnrd.TabIndex = 18;
            this.btnrd.Text = "<--";
            this.btnrd.UseVisualStyleBackColor = true;
            this.btnrd.Click += new System.EventHandler(this.btnrd_Click);
            // 
            // btnclear2
            // 
            this.btnclear2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnclear2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnclear2.Location = new System.Drawing.Point(93, 143);
            this.btnclear2.Name = "btnclear2";
            this.btnclear2.Size = new System.Drawing.Size(75, 70);
            this.btnclear2.TabIndex = 19;
            this.btnclear2.Text = "CE";
            this.btnclear2.UseVisualStyleBackColor = true;
            this.btnclear2.Click += new System.EventHandler(this.btnclear2_Click);
            // 
            // txtresualt
            // 
            this.txtresualt.BackColor = System.Drawing.SystemColors.Info;
            this.txtresualt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtresualt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtresualt.ForeColor = System.Drawing.Color.Gray;
            this.txtresualt.Location = new System.Drawing.Point(12, 45);
            this.txtresualt.Name = "txtresualt";
            this.txtresualt.Size = new System.Drawing.Size(318, 25);
            this.txtresualt.TabIndex = 20;
            this.txtresualt.Text = "0";
            this.txtresualt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtresualt.TextChanged += new System.EventHandler(this.txtresualt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 45);
            this.label1.TabIndex = 21;
            this.label1.Text = "เครื่องคิดเลข";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(345, 531);
            this.Controls.Add(this.txtresualt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclear2);
            this.Controls.Add(this.btnrd);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btndevide);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btndot);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtstore);
            this.Controls.Add(this.btnclear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnclear;
        private TextBox txtstore;
        private Button btn7;
        private Button btn1;
        private Button btn4;
        private Button btn0;
        private Button btndot;
        private Button btn2;
        private Button btn5;
        private Button btn8;
        private Button btnequal;
        private Button btn3;
        private Button btn6;
        private Button btn9;
        private Button btnplus;
        private Button btnmin;
        private Button btnmulti;
        private Button btndevide;
        private Button btnrd;
        private Button btnclear2;
        private TextBox txtresualt;
        private Label label1;
    }
}