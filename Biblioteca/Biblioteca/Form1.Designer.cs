namespace Biblioteca
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
            this.glControl1 = new OpenTK.GLControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPosX = new System.Windows.Forms.TextBox();
            this.txtPosY = new System.Windows.Forms.TextBox();
            this.txtPosZ = new System.Windows.Forms.TextBox();
            this.txtDirZ = new System.Windows.Forms.TextBox();
            this.txtDirY = new System.Windows.Forms.TextBox();
            this.txtDirX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(12, 2);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(1151, 727);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseMove);
            this.glControl1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.glControl1_PreviewKeyDown);
            this.glControl1.Resize += new System.EventHandler(this.glControl1_Resize);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1214, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Posição Personagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1220, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1220, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1220, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Z";
            // 
            // txtPosX
            // 
            this.txtPosX.Location = new System.Drawing.Point(1254, 73);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(57, 20);
            this.txtPosX.TabIndex = 5;
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(1254, 101);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(57, 20);
            this.txtPosY.TabIndex = 6;
            // 
            // txtPosZ
            // 
            this.txtPosZ.Location = new System.Drawing.Point(1254, 127);
            this.txtPosZ.Name = "txtPosZ";
            this.txtPosZ.Size = new System.Drawing.Size(57, 20);
            this.txtPosZ.TabIndex = 7;
            // 
            // txtDirZ
            // 
            this.txtDirZ.Location = new System.Drawing.Point(1254, 279);
            this.txtDirZ.Name = "txtDirZ";
            this.txtDirZ.Size = new System.Drawing.Size(57, 20);
            this.txtDirZ.TabIndex = 14;
            // 
            // txtDirY
            // 
            this.txtDirY.Location = new System.Drawing.Point(1254, 253);
            this.txtDirY.Name = "txtDirY";
            this.txtDirY.Size = new System.Drawing.Size(57, 20);
            this.txtDirY.TabIndex = 13;
            // 
            // txtDirX
            // 
            this.txtDirX.Location = new System.Drawing.Point(1254, 225);
            this.txtDirX.Name = "txtDirX";
            this.txtDirX.Size = new System.Drawing.Size(57, 20);
            this.txtDirX.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1220, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1220, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1220, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1220, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Direção Camera";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 741);
            this.Controls.Add(this.txtDirZ);
            this.Controls.Add(this.txtDirY);
            this.Controls.Add(this.txtDirX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPosZ);
            this.Controls.Add(this.txtPosY);
            this.Controls.Add(this.txtPosX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.glControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPosX;
        private System.Windows.Forms.TextBox txtPosY;
        private System.Windows.Forms.TextBox txtPosZ;
        private System.Windows.Forms.TextBox txtDirZ;
        private System.Windows.Forms.TextBox txtDirY;
        private System.Windows.Forms.TextBox txtDirX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

