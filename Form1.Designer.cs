namespace XMLUsageDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnXMLDocumentWrite = new System.Windows.Forms.Button();
            this.btnXmlDocumentRead = new System.Windows.Forms.Button();
            this.btnXDocumentWrite = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnXDocumentRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXMLDocumentWrite
            // 
            this.btnXMLDocumentWrite.Location = new System.Drawing.Point(37, 61);
            this.btnXMLDocumentWrite.Name = "btnXMLDocumentWrite";
            this.btnXMLDocumentWrite.Size = new System.Drawing.Size(194, 23);
            this.btnXMLDocumentWrite.TabIndex = 0;
            this.btnXMLDocumentWrite.Text = "XmlDocument方式写入";
            this.btnXMLDocumentWrite.UseVisualStyleBackColor = true;
            this.btnXMLDocumentWrite.Click += new System.EventHandler(this.btnXMLDocumentWrite_Click);
            // 
            // btnXmlDocumentRead
            // 
            this.btnXmlDocumentRead.Location = new System.Drawing.Point(496, 61);
            this.btnXmlDocumentRead.Name = "btnXmlDocumentRead";
            this.btnXmlDocumentRead.Size = new System.Drawing.Size(161, 23);
            this.btnXmlDocumentRead.TabIndex = 1;
            this.btnXmlDocumentRead.Text = "XmlDocument方式读取";
            this.btnXmlDocumentRead.UseVisualStyleBackColor = true;
            this.btnXmlDocumentRead.Click += new System.EventHandler(this.btnXmlDocumentRead_Click);
            // 
            // btnXDocumentWrite
            // 
            this.btnXDocumentWrite.Location = new System.Drawing.Point(263, 61);
            this.btnXDocumentWrite.Name = "btnXDocumentWrite";
            this.btnXDocumentWrite.Size = new System.Drawing.Size(187, 23);
            this.btnXDocumentWrite.TabIndex = 2;
            this.btnXDocumentWrite.Text = "XDocument方式写入";
            this.btnXDocumentWrite.UseVisualStyleBackColor = true;
            this.btnXDocumentWrite.Click += new System.EventHandler(this.btnXDocumentWrite_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(195, 157);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(462, 304);
            this.listBox.TabIndex = 3;
            // 
            // btnXDocumentRead
            // 
            this.btnXDocumentRead.Location = new System.Drawing.Point(725, 60);
            this.btnXDocumentRead.Name = "btnXDocumentRead";
            this.btnXDocumentRead.Size = new System.Drawing.Size(163, 23);
            this.btnXDocumentRead.TabIndex = 4;
            this.btnXDocumentRead.Text = "XDocument方式读取";
            this.btnXDocumentRead.UseVisualStyleBackColor = true;
            this.btnXDocumentRead.Click += new System.EventHandler(this.btnXDocumentRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 492);
            this.Controls.Add(this.btnXDocumentRead);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnXDocumentWrite);
            this.Controls.Add(this.btnXmlDocumentRead);
            this.Controls.Add(this.btnXMLDocumentWrite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXMLDocumentWrite;
        private System.Windows.Forms.Button btnXmlDocumentRead;
        private System.Windows.Forms.Button btnXDocumentWrite;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnXDocumentRead;
    }
}

