
namespace USBGrabber
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
            this.listBoxUSB = new System.Windows.Forms.ListBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSTOP = new System.Windows.Forms.ToolStripButton();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripButtonCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonCurrent = new System.Windows.Forms.ToolStripLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxUSB
            // 
            this.listBoxUSB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxUSB.FormattingEnabled = true;
            this.listBoxUSB.Location = new System.Drawing.Point(0, 43);
            this.listBoxUSB.Name = "listBoxUSB";
            this.listBoxUSB.Size = new System.Drawing.Size(800, 407);
            this.listBoxUSB.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSTOP,
            this.toolStripProgressBar,
            this.toolStripButtonCount,
            this.toolStripButtonCurrent});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonSTOP
            // 
            this.toolStripButtonSTOP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSTOP.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSTOP.Image")));
            this.toolStripButtonSTOP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSTOP.Name = "toolStripButtonSTOP";
            this.toolStripButtonSTOP.Size = new System.Drawing.Size(38, 22);
            this.toolStripButtonSTOP.Text = "STOP";
            this.toolStripButtonSTOP.Click += new System.EventHandler(this.toolStripButtonSTOP_Click);
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 22);
            // 
            // toolStripButtonCount
            // 
            this.toolStripButtonCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCount.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCount.Image")));
            this.toolStripButtonCount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCount.Name = "toolStripButtonCount";
            this.toolStripButtonCount.Size = new System.Drawing.Size(30, 22);
            this.toolStripButtonCount.Text = "0 / 0";
            // 
            // toolStripButtonCurrent
            // 
            this.toolStripButtonCurrent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCurrent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCurrent.Image")));
            this.toolStripButtonCurrent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCurrent.Name = "toolStripButtonCurrent";
            this.toolStripButtonCurrent.Size = new System.Drawing.Size(0, 22);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "USBGrabber";
            this.notifyIcon.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.listBoxUSB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USBGrabber";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUSB;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripLabel toolStripButtonCount;
        private System.Windows.Forms.ToolStripButton toolStripButtonSTOP;
        private System.Windows.Forms.ToolStripLabel toolStripButtonCurrent;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

