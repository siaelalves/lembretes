namespace LMB
{
    partial class LMB
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LMB));
            this.cmdIg = new System.Windows.Forms.Button();
            this.cmdTn = new System.Windows.Forms.Button();
            this.txtTm = new System.Windows.Forms.ComboBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.bkg = new System.ComponentModel.BackgroundWorker();
            this.tmT = new System.Windows.Forms.Timer(this.components);
            this.txtLm = new System.Windows.Forms.RichTextBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdIg
            // 
            this.cmdIg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdIg.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.cmdIg.Enabled = false;
            this.cmdIg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIg.Location = new System.Drawing.Point(219, 111);
            this.cmdIg.Name = "cmdIg";
            this.cmdIg.Size = new System.Drawing.Size(75, 23);
            this.cmdIg.TabIndex = 1;
            this.cmdIg.Text = "&Ignorar";
            this.cmdIg.UseVisualStyleBackColor = true;
            this.cmdIg.Click += new System.EventHandler(this.cmdIg_Click);
            // 
            // cmdTn
            // 
            this.cmdTn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdTn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdTn.Enabled = false;
            this.cmdTn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTn.Location = new System.Drawing.Point(15, 111);
            this.cmdTn.Name = "cmdTn";
            this.cmdTn.Size = new System.Drawing.Size(96, 23);
            this.cmdTn.TabIndex = 2;
            this.cmdTn.Text = "&Tocar de novo";
            this.cmdTn.UseVisualStyleBackColor = true;
            this.cmdTn.Click += new System.EventHandler(this.cmdTn_Click);
            // 
            // txtTm
            // 
            this.txtTm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTm.FormattingEnabled = true;
            this.txtTm.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "60"});
            this.txtTm.Location = new System.Drawing.Point(117, 113);
            this.txtTm.Name = "txtTm";
            this.txtTm.Size = new System.Drawing.Size(47, 21);
            this.txtTm.TabIndex = 3;
            this.txtTm.Text = "5";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(170, 116);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(43, 13);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "minutos";
            // 
            // bkg
            // 
            this.bkg.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkg_DoWork);
            // 
            // tmT
            // 
            this.tmT.Interval = 1000;
            this.tmT.Tick += new System.EventHandler(this.tmT_Tick);
            // 
            // txtLm
            // 
            this.txtLm.Enabled = false;
            this.txtLm.Font = new System.Drawing.Font("Calibri", 20F);
            this.txtLm.Location = new System.Drawing.Point(15, 12);
            this.txtLm.Name = "txtLm";
            this.txtLm.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtLm.Size = new System.Drawing.Size(452, 93);
            this.txtLm.TabIndex = 5;
            this.txtLm.Text = "Lembretes";
            // 
            // cmdOK
            // 
            this.cmdOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOK.Location = new System.Drawing.Point(392, 111);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 6;
            this.cmdOK.Text = "&OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // LMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 146);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.txtLm);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.txtTm);
            this.Controls.Add(this.cmdTn);
            this.Controls.Add(this.cmdIg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "LMB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lembrete";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LMB_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LMB_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdIg;
        private System.Windows.Forms.Button cmdTn;
        private System.Windows.Forms.ComboBox txtTm;
        private System.Windows.Forms.Label lblMin;
        private System.ComponentModel.BackgroundWorker bkg;
        private System.Windows.Forms.Timer tmT;
        private System.Windows.Forms.RichTextBox txtLm;
        private System.Windows.Forms.Button cmdOK;
    }
}

