namespace SimpleJect
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDll = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnInject = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ActiveBorder;
            this.linkLabel1.Location = new System.Drawing.Point(40, 182);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(175, 17);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/avexxed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Process Name:";
            // 
            // txtProc
            // 
            this.txtProc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtProc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProc.Location = new System.Drawing.Point(125, 43);
            this.txtProc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProc.Name = "txtProc";
            this.txtProc.Size = new System.Drawing.Size(133, 22);
            this.txtProc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Injection File:";
            // 
            // txtDll
            // 
            this.txtDll.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtDll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDll.Location = new System.Drawing.Point(125, 78);
            this.txtDll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDll.Name = "txtDll";
            this.txtDll.ReadOnly = true;
            this.txtDll.Size = new System.Drawing.Size(133, 22);
            this.txtDll.TabIndex = 4;
            // 
            // btnSelect
            // 
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSelect.Location = new System.Drawing.Point(20, 110);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(239, 27);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // btnInject
            // 
            this.btnInject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInject.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnInject.Location = new System.Drawing.Point(20, 144);
            this.btnInject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(239, 27);
            this.btnInject.TabIndex = 7;
            this.btnInject.Text = "Inject";
            this.btnInject.UseVisualStyleBackColor = true;
            this.btnInject.Click += new System.EventHandler(this.BtnInject_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TopPanel.Controls.Add(this.btnExit);
            this.TopPanel.Location = new System.Drawing.Point(0, -2);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(273, 38);
            this.TopPanel.TabIndex = 8;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(233, 6);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(275, 209);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.btnInject);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtDll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "SimpleJect";
            this.Load += new System.EventHandler(this.Main_Load);
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDll;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnInject;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

