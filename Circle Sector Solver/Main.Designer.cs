namespace Circle_Sector_Solver
{
    partial class Main
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
            this.slvBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ang = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.secArea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.arcLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.segArea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.secPi = new System.Windows.Forms.TextBox();
            this.arcPi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ang)).BeginInit();
            this.SuspendLayout();
            // 
            // slvBtn
            // 
            this.slvBtn.Location = new System.Drawing.Point(12, 63);
            this.slvBtn.Name = "slvBtn";
            this.slvBtn.Size = new System.Drawing.Size(414, 23);
            this.slvBtn.TabIndex = 0;
            this.slvBtn.Text = "Solve";
            this.slvBtn.UseVisualStyleBackColor = true;
            this.slvBtn.Click += new System.EventHandler(this.slvBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Radius: ";
            // 
            // rad
            // 
            this.rad.Location = new System.Drawing.Point(105, 11);
            this.rad.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.rad.Name = "rad";
            this.rad.Size = new System.Drawing.Size(321, 20);
            this.rad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Angle (degrees):";
            // 
            // ang
            // 
            this.ang.Location = new System.Drawing.Point(105, 37);
            this.ang.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.ang.Name = "ang";
            this.ang.Size = new System.Drawing.Size(321, 20);
            this.ang.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sector area:";
            // 
            // secArea
            // 
            this.secArea.Location = new System.Drawing.Point(102, 99);
            this.secArea.Name = "secArea";
            this.secArea.ReadOnly = true;
            this.secArea.Size = new System.Drawing.Size(120, 20);
            this.secArea.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Arc length: ";
            // 
            // arcLength
            // 
            this.arcLength.Location = new System.Drawing.Point(102, 124);
            this.arcLength.Name = "arcLength";
            this.arcLength.ReadOnly = true;
            this.arcLength.Size = new System.Drawing.Size(120, 20);
            this.arcLength.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Segment area:";
            // 
            // segArea
            // 
            this.segArea.Location = new System.Drawing.Point(102, 154);
            this.segArea.Name = "segArea";
            this.segArea.ReadOnly = true;
            this.segArea.Size = new System.Drawing.Size(120, 20);
            this.segArea.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Miramonte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trevor Hedstrom";
            // 
            // secPi
            // 
            this.secPi.Location = new System.Drawing.Point(303, 96);
            this.secPi.Name = "secPi";
            this.secPi.ReadOnly = true;
            this.secPi.Size = new System.Drawing.Size(120, 20);
            this.secPi.TabIndex = 14;
            // 
            // arcPi
            // 
            this.arcPi.Location = new System.Drawing.Point(303, 124);
            this.arcPi.Name = "arcPi";
            this.arcPi.ReadOnly = true;
            this.arcPi.Size = new System.Drawing.Size(120, 20);
            this.arcPi.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Term of pi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Term of pi:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 180);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.arcPi);
            this.Controls.Add(this.secPi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.segArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.arcLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.secArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slvBtn);
            this.Name = "Main";
            this.Text = "Circle Sector Solver";
            ((System.ComponentModel.ISupportInitialize)(this.rad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button slvBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown rad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox secArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox arcLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox segArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox secPi;
        private System.Windows.Forms.TextBox arcPi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

