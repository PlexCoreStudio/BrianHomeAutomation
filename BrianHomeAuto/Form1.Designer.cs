namespace BrianHomeAuto
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.stateLable = new ns1.BunifuCustomLabel();
            this.outputTextbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.inputTextbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 15);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(288, 28);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Brian Home Automation";
            // 
            // stateLable
            // 
            this.stateLable.AutoSize = true;
            this.stateLable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLable.Location = new System.Drawing.Point(12, 72);
            this.stateLable.Name = "stateLable";
            this.stateLable.Size = new System.Drawing.Size(109, 19);
            this.stateLable.TabIndex = 5;
            this.stateLable.Text = "State: Awake";
            // 
            // outputTextbox
            // 
            this.outputTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.outputTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.outputTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.outputTextbox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextbox.Location = new System.Drawing.Point(12, 121);
            this.outputTextbox.Multiline = true;
            this.outputTextbox.Name = "outputTextbox";
            this.outputTextbox.Size = new System.Drawing.Size(287, 21);
            this.outputTextbox.TabIndex = 7;
            // 
            // inputTextbox
            // 
            this.inputTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.inputTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.inputTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputTextbox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextbox.Location = new System.Drawing.Point(12, 94);
            this.inputTextbox.Multiline = true;
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(287, 21);
            this.inputTextbox.TabIndex = 8;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(312, 12);
            this.Header.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(312, 155);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.outputTextbox);
            this.Controls.Add(this.stateLable);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "BrianHomeAuto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuCustomLabel stateLable;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox inputTextbox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox outputTextbox;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel Header;
    }
}

