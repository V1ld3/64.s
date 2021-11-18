namespace _64.s
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
            this.gbxM = new System.Windows.Forms.GroupBox();
            this.btnML = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMT = new System.Windows.Forms.Button();
            this.tbxH = new System.Windows.Forms.TextBox();
            this.tbxW = new System.Windows.Forms.TextBox();
            this.lblH = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.btnAS = new System.Windows.Forms.Button();
            this.lbxFL = new System.Windows.Forms.ListBox();
            this.lblFL = new System.Windows.Forms.Label();
            this.tbxAS = new System.Windows.Forms.TextBox();
            this.lblAS = new System.Windows.Forms.Label();
            this.gbxM.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxM
            // 
            this.gbxM.Controls.Add(this.btnML);
            this.gbxM.Controls.Add(this.btnMC);
            this.gbxM.Controls.Add(this.btnMT);
            this.gbxM.Controls.Add(this.tbxH);
            this.gbxM.Controls.Add(this.tbxW);
            this.gbxM.Controls.Add(this.lblH);
            this.gbxM.Controls.Add(this.lblW);
            this.gbxM.Location = new System.Drawing.Point(78, 55);
            this.gbxM.Name = "gbxM";
            this.gbxM.Size = new System.Drawing.Size(311, 298);
            this.gbxM.TabIndex = 0;
            this.gbxM.TabStop = false;
            this.gbxM.Text = "Skapa";
            // 
            // btnML
            // 
            this.btnML.Location = new System.Drawing.Point(80, 244);
            this.btnML.Name = "btnML";
            this.btnML.Size = new System.Drawing.Size(150, 37);
            this.btnML.TabIndex = 2;
            this.btnML.Text = "Skapa Linje";
            this.btnML.UseVisualStyleBackColor = true;
            this.btnML.Click += new System.EventHandler(this.btnML_Click);
            // 
            // btnMC
            // 
            this.btnMC.Location = new System.Drawing.Point(80, 158);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(150, 37);
            this.btnMC.TabIndex = 2;
            this.btnMC.Text = "Skapa Cirkel";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnMT
            // 
            this.btnMT.Location = new System.Drawing.Point(80, 201);
            this.btnMT.Name = "btnMT";
            this.btnMT.Size = new System.Drawing.Size(150, 37);
            this.btnMT.TabIndex = 2;
            this.btnMT.Text = "Skapa Triangel";
            this.btnMT.UseVisualStyleBackColor = true;
            this.btnMT.Click += new System.EventHandler(this.btnMT_Click);
            // 
            // tbxH
            // 
            this.tbxH.Location = new System.Drawing.Point(80, 106);
            this.tbxH.Name = "tbxH";
            this.tbxH.Size = new System.Drawing.Size(150, 31);
            this.tbxH.TabIndex = 1;
            // 
            // tbxW
            // 
            this.tbxW.Location = new System.Drawing.Point(80, 59);
            this.tbxW.Name = "tbxW";
            this.tbxW.Size = new System.Drawing.Size(150, 31);
            this.tbxW.TabIndex = 1;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(6, 109);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(51, 25);
            this.lblH.TabIndex = 0;
            this.lblH.Text = "Höjd";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Location = new System.Drawing.Point(6, 62);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(59, 25);
            this.lblW.TabIndex = 0;
            this.lblW.Text = "Bredd";
            // 
            // btnAS
            // 
            this.btnAS.Location = new System.Drawing.Point(127, 387);
            this.btnAS.Name = "btnAS";
            this.btnAS.Size = new System.Drawing.Size(164, 37);
            this.btnAS.TabIndex = 1;
            this.btnAS.Text = "Sammanlagd area";
            this.btnAS.UseVisualStyleBackColor = true;
            // 
            // lbxFL
            // 
            this.lbxFL.FormattingEnabled = true;
            this.lbxFL.ItemHeight = 25;
            this.lbxFL.Location = new System.Drawing.Point(405, 114);
            this.lbxFL.Name = "lbxFL";
            this.lbxFL.Size = new System.Drawing.Size(181, 229);
            this.lbxFL.TabIndex = 2;
            // 
            // lblFL
            // 
            this.lblFL.AutoSize = true;
            this.lblFL.Location = new System.Drawing.Point(405, 74);
            this.lblFL.Name = "lblFL";
            this.lblFL.Size = new System.Drawing.Size(83, 25);
            this.lblFL.TabIndex = 3;
            this.lblFL.Text = "Figurlista";
            // 
            // tbxAS
            // 
            this.tbxAS.Location = new System.Drawing.Point(405, 387);
            this.tbxAS.Name = "tbxAS";
            this.tbxAS.Size = new System.Drawing.Size(181, 31);
            this.tbxAS.TabIndex = 1;
            // 
            // lblAS
            // 
            this.lblAS.AutoSize = true;
            this.lblAS.Location = new System.Drawing.Point(405, 359);
            this.lblAS.Name = "lblAS";
            this.lblAS.Size = new System.Drawing.Size(155, 25);
            this.lblAS.TabIndex = 3;
            this.lblAS.Text = "Sammanlagd area";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.lblAS);
            this.Controls.Add(this.tbxAS);
            this.Controls.Add(this.lblFL);
            this.Controls.Add(this.lbxFL);
            this.Controls.Add(this.btnAS);
            this.Controls.Add(this.gbxM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxM.ResumeLayout(false);
            this.gbxM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxM;
        private System.Windows.Forms.Button btnML;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMT;
        private System.Windows.Forms.TextBox tbxH;
        private System.Windows.Forms.TextBox tbxW;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Button btnAS;
        private System.Windows.Forms.ListBox lbxFL;
        private System.Windows.Forms.Label lblFL;
        private System.Windows.Forms.TextBox tbxAS;
        private System.Windows.Forms.Label lblAS;
    }
}

