namespace LMB
{
    partial class NLMB
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
            this.txtNv = new System.Windows.Forms.TextBox();
            this.lblNv = new System.Windows.Forms.Label();
            this.cmdOK = new System.Windows.Forms.Button();
            this.txtH = new System.Windows.Forms.NumericUpDown();
            this.txtM = new System.Windows.Forms.NumericUpDown();
            this.txtS = new System.Windows.Forms.NumericUpDown();
            this.lblH = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtS)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNv
            // 
            this.txtNv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNv.Location = new System.Drawing.Point(12, 24);
            this.txtNv.Name = "txtNv";
            this.txtNv.Size = new System.Drawing.Size(220, 20);
            this.txtNv.TabIndex = 0;
            this.txtNv.Text = "Novo lembrete";
            this.txtNv.Enter += new System.EventHandler(this.cmdNv_Enter);
            // 
            // lblNv
            // 
            this.lblNv.AutoSize = true;
            this.lblNv.Location = new System.Drawing.Point(9, 8);
            this.lblNv.Name = "lblNv";
            this.lblNv.Size = new System.Drawing.Size(79, 13);
            this.lblNv.TabIndex = 1;
            this.lblNv.Text = "Novo lembrete:";
            // 
            // cmdOK
            // 
            this.cmdOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOK.Location = new System.Drawing.Point(157, 89);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 2;
            this.cmdOK.Text = "&OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(12, 63);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(41, 20);
            this.txtH.TabIndex = 3;
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(75, 63);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(41, 20);
            this.txtM.TabIndex = 4;
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(151, 63);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(41, 20);
            this.txtS.TabIndex = 5;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(59, 70);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(13, 13);
            this.lblH.TabIndex = 6;
            this.lblH.Text = "h";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(122, 70);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(23, 13);
            this.lblM.TabIndex = 7;
            this.lblM.Text = "min";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(9, 47);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(137, 13);
            this.lblT.TabIndex = 8;
            this.lblT.Text = "Devo ser lembrado daqui a ";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(198, 70);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(24, 13);
            this.lblS.TabIndex = 9;
            this.lblS.Text = "seg";
            // 
            // NLMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 123);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.lblNv);
            this.Controls.Add(this.txtNv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "NLMB";
            this.Text = "Adicionar";
            ((System.ComponentModel.ISupportInitialize)(this.txtH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNv;
        private System.Windows.Forms.Label lblNv;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.NumericUpDown txtH;
        private System.Windows.Forms.NumericUpDown txtM;
        private System.Windows.Forms.NumericUpDown txtS;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblS;
    }
}