namespace ProxyChanger
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.proxyChangeBtn = new System.Windows.Forms.Button();
            this.cBoxProxyList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hideInTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // proxyChangeBtn
            // 
            this.proxyChangeBtn.Location = new System.Drawing.Point(88, 63);
            this.proxyChangeBtn.Name = "proxyChangeBtn";
            this.proxyChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.proxyChangeBtn.TabIndex = 0;
            this.proxyChangeBtn.Text = "Змінити";
            this.proxyChangeBtn.UseVisualStyleBackColor = true;
            this.proxyChangeBtn.Click += new System.EventHandler(this.proxyChangeBtn_Click);
            // 
            // cBoxProxyList
            // 
            this.cBoxProxyList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cBoxProxyList.FormattingEnabled = true;
            this.cBoxProxyList.Location = new System.Drawing.Point(12, 25);
            this.cBoxProxyList.Name = "cBoxProxyList";
            this.cBoxProxyList.Size = new System.Drawing.Size(221, 21);
            this.cBoxProxyList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proxy-сервер";
            // 
            // hideInTray
            // 
            this.hideInTray.Icon = ((System.Drawing.Icon)(resources.GetObject("hideInTray.Icon")));
            this.hideInTray.Text = "ProxyChanger";
            this.hideInTray.Visible = true;            
            this.hideInTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.hideInTray_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 102);
            this.Controls.Add(this.proxyChangeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxProxyList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ProxyChanger";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button proxyChangeBtn;
        private System.Windows.Forms.ComboBox cBoxProxyList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon hideInTray;
    }
}

