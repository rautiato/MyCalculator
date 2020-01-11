namespace MyCalculator
{
    partial class Calculator
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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmd7 = new System.Windows.Forms.Button();
            this.cmdDivide = new System.Windows.Forms.Button();
            this.cmd8 = new System.Windows.Forms.Button();
            this.cmd9 = new System.Windows.Forms.Button();
            this.cmdMultiply = new System.Windows.Forms.Button();
            this.cmdSubtract = new System.Windows.Forms.Button();
            this.cmd4 = new System.Windows.Forms.Button();
            this.cmd5 = new System.Windows.Forms.Button();
            this.cmd6 = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmd1 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.cmd3 = new System.Windows.Forms.Button();
            this.cmdEqual = new System.Windows.Forms.Button();
            this.cmd0 = new System.Windows.Forms.Button();
            this.cmdNegPos = new System.Windows.Forms.Button();
            this.cmdPercentage = new System.Windows.Forms.Button();
            this.cmdDot = new System.Windows.Forms.Button();
            this.cmdDel = new System.Windows.Forms.Button();
            this.LblFormular = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.Location = new System.Drawing.Point(14, 40);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(321, 49);
            this.txtBox.TabIndex = 0;
            this.txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // cmdClear
            // 
            this.cmdClear.BackColor = System.Drawing.Color.Gray;
            this.cmdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdClear.Location = new System.Drawing.Point(14, 113);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 43);
            this.cmdClear.TabIndex = 1;
            this.cmdClear.Text = "AC";
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmd7
            // 
            this.cmd7.BackColor = System.Drawing.Color.LightGray;
            this.cmd7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd7.Location = new System.Drawing.Point(14, 175);
            this.cmd7.Name = "cmd7";
            this.cmd7.Size = new System.Drawing.Size(75, 43);
            this.cmd7.TabIndex = 1;
            this.cmd7.Text = "7";
            this.cmd7.UseVisualStyleBackColor = false;
            this.cmd7.Click += new System.EventHandler(this.cmd7_Click);
            // 
            // cmdDivide
            // 
            this.cmdDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDivide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdDivide.Location = new System.Drawing.Point(258, 113);
            this.cmdDivide.Name = "cmdDivide";
            this.cmdDivide.Size = new System.Drawing.Size(75, 43);
            this.cmdDivide.TabIndex = 1;
            this.cmdDivide.Text = "/";
            this.cmdDivide.UseVisualStyleBackColor = false;
            this.cmdDivide.Click += new System.EventHandler(this.cmdDivide_Click);
            // 
            // cmd8
            // 
            this.cmd8.BackColor = System.Drawing.Color.LightGray;
            this.cmd8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd8.Location = new System.Drawing.Point(95, 175);
            this.cmd8.Name = "cmd8";
            this.cmd8.Size = new System.Drawing.Size(75, 43);
            this.cmd8.TabIndex = 1;
            this.cmd8.Text = "8";
            this.cmd8.UseVisualStyleBackColor = false;
            this.cmd8.Click += new System.EventHandler(this.cmd8_Click);
            // 
            // cmd9
            // 
            this.cmd9.BackColor = System.Drawing.Color.LightGray;
            this.cmd9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd9.Location = new System.Drawing.Point(176, 175);
            this.cmd9.Name = "cmd9";
            this.cmd9.Size = new System.Drawing.Size(75, 43);
            this.cmd9.TabIndex = 1;
            this.cmd9.Text = "9";
            this.cmd9.UseVisualStyleBackColor = false;
            this.cmd9.Click += new System.EventHandler(this.cmd9_Click);
            // 
            // cmdMultiply
            // 
            this.cmdMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMultiply.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdMultiply.Location = new System.Drawing.Point(258, 175);
            this.cmdMultiply.Name = "cmdMultiply";
            this.cmdMultiply.Size = new System.Drawing.Size(75, 43);
            this.cmdMultiply.TabIndex = 1;
            this.cmdMultiply.Text = "x";
            this.cmdMultiply.UseVisualStyleBackColor = false;
            this.cmdMultiply.Click += new System.EventHandler(this.cmdMultiply_Click);
            // 
            // cmdSubtract
            // 
            this.cmdSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSubtract.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdSubtract.Location = new System.Drawing.Point(258, 240);
            this.cmdSubtract.Name = "cmdSubtract";
            this.cmdSubtract.Size = new System.Drawing.Size(75, 43);
            this.cmdSubtract.TabIndex = 1;
            this.cmdSubtract.Text = "-";
            this.cmdSubtract.UseVisualStyleBackColor = false;
            this.cmdSubtract.Click += new System.EventHandler(this.cmdSubtract_Click);
            // 
            // cmd4
            // 
            this.cmd4.BackColor = System.Drawing.Color.LightGray;
            this.cmd4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd4.Location = new System.Drawing.Point(14, 240);
            this.cmd4.Name = "cmd4";
            this.cmd4.Size = new System.Drawing.Size(75, 43);
            this.cmd4.TabIndex = 1;
            this.cmd4.Text = "4";
            this.cmd4.UseVisualStyleBackColor = false;
            this.cmd4.Click += new System.EventHandler(this.cmd4_Click);
            // 
            // cmd5
            // 
            this.cmd5.BackColor = System.Drawing.Color.LightGray;
            this.cmd5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd5.Location = new System.Drawing.Point(95, 240);
            this.cmd5.Name = "cmd5";
            this.cmd5.Size = new System.Drawing.Size(75, 43);
            this.cmd5.TabIndex = 1;
            this.cmd5.Text = "5";
            this.cmd5.UseVisualStyleBackColor = false;
            this.cmd5.Click += new System.EventHandler(this.cmd5_Click);
            // 
            // cmd6
            // 
            this.cmd6.BackColor = System.Drawing.Color.LightGray;
            this.cmd6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd6.Location = new System.Drawing.Point(176, 240);
            this.cmd6.Name = "cmd6";
            this.cmd6.Size = new System.Drawing.Size(75, 43);
            this.cmd6.TabIndex = 1;
            this.cmd6.Text = "6";
            this.cmd6.UseVisualStyleBackColor = false;
            this.cmd6.Click += new System.EventHandler(this.cmd6_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdAdd.Location = new System.Drawing.Point(258, 305);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 43);
            this.cmdAdd.TabIndex = 1;
            this.cmdAdd.Text = "+";
            this.cmdAdd.UseVisualStyleBackColor = false;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmd1
            // 
            this.cmd1.BackColor = System.Drawing.Color.LightGray;
            this.cmd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd1.Location = new System.Drawing.Point(14, 305);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(75, 43);
            this.cmd1.TabIndex = 1;
            this.cmd1.Text = "1";
            this.cmd1.UseVisualStyleBackColor = false;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // cmd2
            // 
            this.cmd2.BackColor = System.Drawing.Color.LightGray;
            this.cmd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd2.Location = new System.Drawing.Point(95, 305);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(75, 43);
            this.cmd2.TabIndex = 1;
            this.cmd2.Text = "2";
            this.cmd2.UseVisualStyleBackColor = false;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
            // 
            // cmd3
            // 
            this.cmd3.BackColor = System.Drawing.Color.LightGray;
            this.cmd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd3.Location = new System.Drawing.Point(176, 305);
            this.cmd3.Name = "cmd3";
            this.cmd3.Size = new System.Drawing.Size(75, 43);
            this.cmd3.TabIndex = 1;
            this.cmd3.Text = "3";
            this.cmd3.UseVisualStyleBackColor = false;
            this.cmd3.Click += new System.EventHandler(this.cmd3_Click);
            // 
            // cmdEqual
            // 
            this.cmdEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEqual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdEqual.Location = new System.Drawing.Point(258, 368);
            this.cmdEqual.Name = "cmdEqual";
            this.cmdEqual.Size = new System.Drawing.Size(75, 43);
            this.cmdEqual.TabIndex = 1;
            this.cmdEqual.Text = "=";
            this.cmdEqual.UseVisualStyleBackColor = false;
            this.cmdEqual.Click += new System.EventHandler(this.cmdEqual_Click);
            // 
            // cmd0
            // 
            this.cmd0.BackColor = System.Drawing.Color.LightGray;
            this.cmd0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd0.Location = new System.Drawing.Point(14, 368);
            this.cmd0.Name = "cmd0";
            this.cmd0.Size = new System.Drawing.Size(75, 43);
            this.cmd0.TabIndex = 1;
            this.cmd0.Text = "0";
            this.cmd0.UseVisualStyleBackColor = false;
            this.cmd0.Click += new System.EventHandler(this.cmd0_Click);
            // 
            // cmdNegPos
            // 
            this.cmdNegPos.BackColor = System.Drawing.Color.Gray;
            this.cmdNegPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNegPos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdNegPos.Location = new System.Drawing.Point(95, 368);
            this.cmdNegPos.Name = "cmdNegPos";
            this.cmdNegPos.Size = new System.Drawing.Size(75, 43);
            this.cmdNegPos.TabIndex = 1;
            this.cmdNegPos.Text = "+/-";
            this.cmdNegPos.UseVisualStyleBackColor = false;
            this.cmdNegPos.Click += new System.EventHandler(this.cmdNegPos_Click);
            // 
            // cmdPercentage
            // 
            this.cmdPercentage.BackColor = System.Drawing.Color.Gray;
            this.cmdPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPercentage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdPercentage.Location = new System.Drawing.Point(95, 113);
            this.cmdPercentage.Name = "cmdPercentage";
            this.cmdPercentage.Size = new System.Drawing.Size(75, 43);
            this.cmdPercentage.TabIndex = 1;
            this.cmdPercentage.Text = "%";
            this.cmdPercentage.UseVisualStyleBackColor = false;
            this.cmdPercentage.Click += new System.EventHandler(this.cmdPercentage_Click);
            // 
            // cmdDot
            // 
            this.cmdDot.BackColor = System.Drawing.Color.Gray;
            this.cmdDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdDot.Location = new System.Drawing.Point(176, 368);
            this.cmdDot.Name = "cmdDot";
            this.cmdDot.Size = new System.Drawing.Size(75, 43);
            this.cmdDot.TabIndex = 1;
            this.cmdDot.Text = ".";
            this.cmdDot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdDot.UseVisualStyleBackColor = false;
            this.cmdDot.Click += new System.EventHandler(this.cmdDot_Click);
            // 
            // cmdDel
            // 
            this.cmdDel.BackColor = System.Drawing.Color.Gray;
            this.cmdDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdDel.Location = new System.Drawing.Point(176, 113);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(75, 43);
            this.cmdDel.TabIndex = 1;
            this.cmdDel.Text = "Del";
            this.cmdDel.UseVisualStyleBackColor = false;
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click);
            // 
            // LblFormular
            // 
            this.LblFormular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblFormular.Location = new System.Drawing.Point(14, 12);
            this.LblFormular.Name = "LblFormular";
            this.LblFormular.Size = new System.Drawing.Size(319, 23);
            this.LblFormular.TabIndex = 2;
            this.LblFormular.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(347, 425);
            this.Controls.Add(this.LblFormular);
            this.Controls.Add(this.cmd3);
            this.Controls.Add(this.cmd6);
            this.Controls.Add(this.cmd9);
            this.Controls.Add(this.cmd0);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.cmd5);
            this.Controls.Add(this.cmdEqual);
            this.Controls.Add(this.cmd4);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmd8);
            this.Controls.Add(this.cmdSubtract);
            this.Controls.Add(this.cmd7);
            this.Controls.Add(this.cmdMultiply);
            this.Controls.Add(this.cmdDivide);
            this.Controls.Add(this.cmdDot);
            this.Controls.Add(this.cmdDel);
            this.Controls.Add(this.cmdPercentage);
            this.Controls.Add(this.cmdNegPos);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.txtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmd7;
        private System.Windows.Forms.Button cmdDivide;
        private System.Windows.Forms.Button cmd8;
        private System.Windows.Forms.Button cmd9;
        private System.Windows.Forms.Button cmdMultiply;
        private System.Windows.Forms.Button cmdSubtract;
        private System.Windows.Forms.Button cmd4;
        private System.Windows.Forms.Button cmd5;
        private System.Windows.Forms.Button cmd6;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.Button cmd2;
        private System.Windows.Forms.Button cmd3;
        private System.Windows.Forms.Button cmdEqual;
        private System.Windows.Forms.Button cmd0;
        private System.Windows.Forms.Button cmdNegPos;
        private System.Windows.Forms.Button cmdPercentage;
        private System.Windows.Forms.Button cmdDot;
        private System.Windows.Forms.Button cmdDel;
        private System.Windows.Forms.Label LblFormular;
    }
}

