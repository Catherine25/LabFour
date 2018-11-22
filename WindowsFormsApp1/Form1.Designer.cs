namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSA = new System.Windows.Forms.TextBox();
            this.textBoxSB = new System.Windows.Forms.TextBox();
            this.textBoxSC = new System.Windows.Forms.TextBox();
            this.textBoxSD = new System.Windows.Forms.TextBox();
            this.GetSABt = new System.Windows.Forms.Button();
            this.ShowResultBt = new System.Windows.Forms.Button();
            this.GetSBBt = new System.Windows.Forms.Button();
            this.GetSCBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Content of SA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Content of SB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Content of SC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result";
            // 
            // textBoxSA
            // 
            this.textBoxSA.Location = new System.Drawing.Point(12, 32);
            this.textBoxSA.Name = "textBoxSA";
            this.textBoxSA.ReadOnly = true;
            this.textBoxSA.Size = new System.Drawing.Size(637, 26);
            this.textBoxSA.TabIndex = 4;
            // 
            // textBoxSB
            // 
            this.textBoxSB.Location = new System.Drawing.Point(12, 84);
            this.textBoxSB.Name = "textBoxSB";
            this.textBoxSB.ReadOnly = true;
            this.textBoxSB.Size = new System.Drawing.Size(637, 26);
            this.textBoxSB.TabIndex = 5;
            // 
            // textBoxSC
            // 
            this.textBoxSC.Location = new System.Drawing.Point(12, 136);
            this.textBoxSC.Name = "textBoxSC";
            this.textBoxSC.ReadOnly = true;
            this.textBoxSC.Size = new System.Drawing.Size(637, 26);
            this.textBoxSC.TabIndex = 6;
            // 
            // textBoxSD
            // 
            this.textBoxSD.Location = new System.Drawing.Point(12, 188);
            this.textBoxSD.Name = "textBoxSD";
            this.textBoxSD.ReadOnly = true;
            this.textBoxSD.Size = new System.Drawing.Size(637, 26);
            this.textBoxSD.TabIndex = 7;
            // 
            // GetSABt
            // 
            this.GetSABt.BackColor = System.Drawing.Color.Transparent;
            this.GetSABt.Location = new System.Drawing.Point(656, 9);
            this.GetSABt.Name = "GetSABt";
            this.GetSABt.Size = new System.Drawing.Size(132, 49);
            this.GetSABt.TabIndex = 8;
            this.GetSABt.Text = "Get SA";
            this.GetSABt.UseVisualStyleBackColor = false;
            // 
            // ShowResultBt
            // 
            this.ShowResultBt.Location = new System.Drawing.Point(656, 168);
            this.ShowResultBt.Name = "ShowResultBt";
            this.ShowResultBt.Size = new System.Drawing.Size(132, 46);
            this.ShowResultBt.TabIndex = 9;
            this.ShowResultBt.Text = "Show result";
            this.ShowResultBt.UseVisualStyleBackColor = true;
            // 
            // GetSBBt
            // 
            this.GetSBBt.Location = new System.Drawing.Point(656, 61);
            this.GetSBBt.Name = "GetSBBt";
            this.GetSBBt.Size = new System.Drawing.Size(132, 49);
            this.GetSBBt.TabIndex = 10;
            this.GetSBBt.Text = "Get SB";
            this.GetSBBt.UseVisualStyleBackColor = true;
            // 
            // GetSCBt
            // 
            this.GetSCBt.Location = new System.Drawing.Point(656, 113);
            this.GetSCBt.Name = "GetSCBt";
            this.GetSCBt.Size = new System.Drawing.Size(132, 49);
            this.GetSCBt.TabIndex = 11;
            this.GetSCBt.Text = "Get SC";
            this.GetSCBt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 228);
            this.Controls.Add(this.GetSCBt);
            this.Controls.Add(this.GetSBBt);
            this.Controls.Add(this.ShowResultBt);
            this.Controls.Add(this.GetSABt);
            this.Controls.Add(this.textBoxSD);
            this.Controls.Add(this.textBoxSC);
            this.Controls.Add(this.textBoxSB);
            this.Controls.Add(this.textBoxSA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSA;
        private System.Windows.Forms.TextBox textBoxSB;
        private System.Windows.Forms.TextBox textBoxSC;
        private System.Windows.Forms.TextBox textBoxSD;
        private System.Windows.Forms.Button GetSABt;
        private System.Windows.Forms.Button ShowResultBt;
        private System.Windows.Forms.Button GetSBBt;
        private System.Windows.Forms.Button GetSCBt;
    }
}

