namespace getURL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.rtcResult = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(63, 21);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(1084, 20);
            this.txtURL.TabIndex = 0;
            this.txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(63, 47);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1084, 273);
            this.webBrowser1.TabIndex = 2;
            // 
            // rtcResult
            // 
            this.rtcResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtcResult.Location = new System.Drawing.Point(63, 332);
            this.rtcResult.Name = "rtcResult";
            this.rtcResult.ReadOnly = true;
            this.rtcResult.Size = new System.Drawing.Size(1084, 240);
            this.rtcResult.TabIndex = 3;
            this.rtcResult.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1061, 589);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 36);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 637);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rtcResult);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtURL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Get URL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RichTextBox rtcResult;
        private System.Windows.Forms.Button btnClear;
    }
}

