namespace Turing_ia_ihc_Joystick_tester
{
    partial class Client
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.txtMessageReceived = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessageToSend = new System.Windows.Forms.TextBox();
            this.txtServerPort = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnContenctFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerPort)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFile);
            this.groupBox2.Controls.Add(this.btnSelectFile);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnContenctFile);
            this.groupBox2.Controls.Add(this.txtServerAddress);
            this.groupBox2.Controls.Add(this.txtMessageReceived);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Controls.Add(this.txtMessageToSend);
            this.groupBox2.Controls.Add(this.txtServerPort);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 161);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Location = new System.Drawing.Point(58, 19);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(75, 20);
            this.txtServerAddress.TabIndex = 7;
            this.txtServerAddress.Text = "localhost";
            // 
            // txtMessageReceived
            // 
            this.txtMessageReceived.AcceptsReturn = true;
            this.txtMessageReceived.AcceptsTab = true;
            this.txtMessageReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageReceived.Location = new System.Drawing.Point(6, 98);
            this.txtMessageReceived.Multiline = true;
            this.txtMessageReceived.Name = "txtMessageReceived";
            this.txtMessageReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageReceived.Size = new System.Drawing.Size(264, 57);
            this.txtMessageReceived.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(199, 43);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessageToSend
            // 
            this.txtMessageToSend.Location = new System.Drawing.Point(6, 46);
            this.txtMessageToSend.Name = "txtMessageToSend";
            this.txtMessageToSend.Size = new System.Drawing.Size(187, 20);
            this.txtMessageToSend.TabIndex = 4;
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(139, 20);
            this.txtServerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.txtServerPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(54, 20);
            this.txtServerPort.TabIndex = 2;
            this.txtServerPort.Value = new decimal(new int[] {
            53211,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server:";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(199, 17);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "&Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnContenctFile
            // 
            this.btnContenctFile.Enabled = false;
            this.btnContenctFile.Location = new System.Drawing.Point(199, 69);
            this.btnContenctFile.Name = "btnContenctFile";
            this.btnContenctFile.Size = new System.Drawing.Size(75, 23);
            this.btnContenctFile.TabIndex = 8;
            this.btnContenctFile.Text = "&Send";
            this.btnContenctFile.UseVisualStyleBackColor = true;
            this.btnContenctFile.Click += new System.EventHandler(this.btnContenctFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "From File:";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(139, 69);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(54, 23);
            this.btnSelectFile.TabIndex = 10;
            this.btnSelectFile.Text = "&File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(58, 71);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(75, 20);
            this.txtFile.TabIndex = 11;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 161);
            this.Controls.Add(this.groupBox2);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtServerAddress;
        private System.Windows.Forms.TextBox txtMessageReceived;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessageToSend;
        private System.Windows.Forms.NumericUpDown txtServerPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnContenctFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.OpenFileDialog ofdFile;
    }
}