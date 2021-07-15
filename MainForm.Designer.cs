﻿
namespace TarkovPriceViewer
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayshow = new System.Windows.Forms.ToolStripMenuItem();
            this.trayexit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TransParent_Text = new System.Windows.Forms.Label();
            this.CloseOverlayWhenMouseMoved = new System.Windows.Forms.CheckBox();
            this.TransParent_Bar = new System.Windows.Forms.TrackBar();
            this.HideOverlay_Desc2 = new System.Windows.Forms.Label();
            this.TransParent_Desc = new System.Windows.Forms.Label();
            this.HideOverlay_Button = new System.Windows.Forms.Button();
            this.ShowOverlay_Button = new System.Windows.Forms.Button();
            this.ShowOverlay_Desc = new System.Windows.Forms.Label();
            this.HideOverlay_Desc = new System.Windows.Forms.Label();
            this.CheckUpdate = new System.Windows.Forms.Button();
            this.Github = new System.Windows.Forms.Button();
            this.TarkovMarket = new System.Windows.Forms.Button();
            this.TarkovWiki = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DataProvidedBy = new System.Windows.Forms.Label();
            this.MinimizetoTrayWhenStartup = new System.Windows.Forms.CheckBox();
            this.Version = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TrayMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransParent_Bar)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "TarkovPriceViewer";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // TrayMenu
            // 
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayshow,
            this.trayexit});
            this.TrayMenu.Name = "TrayMenu";
            this.TrayMenu.Size = new System.Drawing.Size(105, 48);
            // 
            // trayshow
            // 
            this.trayshow.Name = "trayshow";
            this.trayshow.Size = new System.Drawing.Size(104, 22);
            this.trayshow.Text = "Show";
            this.trayshow.Click += new System.EventHandler(this.TrayShow_Click);
            // 
            // trayexit
            // 
            this.trayexit.Name = "trayexit";
            this.trayexit.Size = new System.Drawing.Size(104, 22);
            this.trayexit.Text = "Exit";
            this.trayexit.Click += new System.EventHandler(this.TrayExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TransParent_Text);
            this.panel1.Controls.Add(this.CloseOverlayWhenMouseMoved);
            this.panel1.Controls.Add(this.TransParent_Bar);
            this.panel1.Controls.Add(this.HideOverlay_Desc2);
            this.panel1.Controls.Add(this.TransParent_Desc);
            this.panel1.Controls.Add(this.HideOverlay_Button);
            this.panel1.Controls.Add(this.ShowOverlay_Button);
            this.panel1.Controls.Add(this.ShowOverlay_Desc);
            this.panel1.Controls.Add(this.HideOverlay_Desc);
            this.panel1.Location = new System.Drawing.Point(14, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 191);
            this.panel1.TabIndex = 1;
            // 
            // TransParent_Text
            // 
            this.TransParent_Text.AutoSize = true;
            this.TransParent_Text.Location = new System.Drawing.Point(246, 145);
            this.TransParent_Text.Name = "TransParent_Text";
            this.TransParent_Text.Size = new System.Drawing.Size(27, 12);
            this.TransParent_Text.TabIndex = 4;
            this.TransParent_Text.Text = "80%";
            // 
            // CloseOverlayWhenMouseMoved
            // 
            this.CloseOverlayWhenMouseMoved.AutoSize = true;
            this.CloseOverlayWhenMouseMoved.Location = new System.Drawing.Point(5, 87);
            this.CloseOverlayWhenMouseMoved.Name = "CloseOverlayWhenMouseMoved";
            this.CloseOverlayWhenMouseMoved.Size = new System.Drawing.Size(224, 16);
            this.CloseOverlayWhenMouseMoved.TabIndex = 6;
            this.CloseOverlayWhenMouseMoved.TabStop = false;
            this.CloseOverlayWhenMouseMoved.Text = "Close Overlay When Mouse Moved";
            this.CloseOverlayWhenMouseMoved.UseVisualStyleBackColor = true;
            this.CloseOverlayWhenMouseMoved.CheckedChanged += new System.EventHandler(this.CloseOverlayWhenMouseMoved_CheckedChanged);
            // 
            // TransParent_Bar
            // 
            this.TransParent_Bar.Location = new System.Drawing.Point(5, 135);
            this.TransParent_Bar.Maximum = 100;
            this.TransParent_Bar.Name = "TransParent_Bar";
            this.TransParent_Bar.Size = new System.Drawing.Size(235, 45);
            this.TransParent_Bar.TabIndex = 3;
            this.TransParent_Bar.TabStop = false;
            this.TransParent_Bar.Value = 80;
            this.TransParent_Bar.Scroll += new System.EventHandler(this.TransParent_Bar_Scroll);
            // 
            // HideOverlay_Desc2
            // 
            this.HideOverlay_Desc2.AutoSize = true;
            this.HideOverlay_Desc2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HideOverlay_Desc2.ForeColor = System.Drawing.Color.Red;
            this.HideOverlay_Desc2.Location = new System.Drawing.Point(19, 58);
            this.HideOverlay_Desc2.Name = "HideOverlay_Desc2";
            this.HideOverlay_Desc2.Size = new System.Drawing.Size(230, 12);
            this.HideOverlay_Desc2.TabIndex = 0;
            this.HideOverlay_Desc2.Text = "※ Tab, Esc Keys are fixed to use";
            // 
            // TransParent_Desc
            // 
            this.TransParent_Desc.AutoSize = true;
            this.TransParent_Desc.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TransParent_Desc.Location = new System.Drawing.Point(3, 120);
            this.TransParent_Desc.Name = "TransParent_Desc";
            this.TransParent_Desc.Size = new System.Drawing.Size(107, 12);
            this.TransParent_Desc.TabIndex = 0;
            this.TransParent_Desc.Text = "Control Opacity";
            // 
            // HideOverlay_Button
            // 
            this.HideOverlay_Button.Location = new System.Drawing.Point(170, 32);
            this.HideOverlay_Button.Name = "HideOverlay_Button";
            this.HideOverlay_Button.Size = new System.Drawing.Size(59, 23);
            this.HideOverlay_Button.TabIndex = 1;
            this.HideOverlay_Button.TabStop = false;
            this.HideOverlay_Button.Text = "F10";
            this.HideOverlay_Button.UseVisualStyleBackColor = true;
            this.HideOverlay_Button.Click += new System.EventHandler(this.Overlay_Button_Click);
            // 
            // ShowOverlay_Button
            // 
            this.ShowOverlay_Button.Location = new System.Drawing.Point(170, 3);
            this.ShowOverlay_Button.Name = "ShowOverlay_Button";
            this.ShowOverlay_Button.Size = new System.Drawing.Size(59, 23);
            this.ShowOverlay_Button.TabIndex = 1;
            this.ShowOverlay_Button.TabStop = false;
            this.ShowOverlay_Button.Text = "F9";
            this.ShowOverlay_Button.UseVisualStyleBackColor = true;
            this.ShowOverlay_Button.Click += new System.EventHandler(this.Overlay_Button_Click);
            // 
            // ShowOverlay_Desc
            // 
            this.ShowOverlay_Desc.AutoSize = true;
            this.ShowOverlay_Desc.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ShowOverlay_Desc.Location = new System.Drawing.Point(3, 8);
            this.ShowOverlay_Desc.Name = "ShowOverlay_Desc";
            this.ShowOverlay_Desc.Size = new System.Drawing.Size(126, 12);
            this.ShowOverlay_Desc.TabIndex = 0;
            this.ShowOverlay_Desc.Text = "Show Overlay Key";
            // 
            // HideOverlay_Desc
            // 
            this.HideOverlay_Desc.AutoSize = true;
            this.HideOverlay_Desc.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HideOverlay_Desc.Location = new System.Drawing.Point(3, 37);
            this.HideOverlay_Desc.Name = "HideOverlay_Desc";
            this.HideOverlay_Desc.Size = new System.Drawing.Size(119, 12);
            this.HideOverlay_Desc.TabIndex = 0;
            this.HideOverlay_Desc.Text = "Hide Overlay Key";
            // 
            // CheckUpdate
            // 
            this.CheckUpdate.Location = new System.Drawing.Point(21, 119);
            this.CheckUpdate.Name = "CheckUpdate";
            this.CheckUpdate.Size = new System.Drawing.Size(115, 23);
            this.CheckUpdate.TabIndex = 5;
            this.CheckUpdate.TabStop = false;
            this.CheckUpdate.Text = "CheckUpdate";
            this.CheckUpdate.UseVisualStyleBackColor = true;
            this.CheckUpdate.Click += new System.EventHandler(this.CheckUpdate_Click);
            // 
            // Github
            // 
            this.Github.Location = new System.Drawing.Point(21, 90);
            this.Github.Name = "Github";
            this.Github.Size = new System.Drawing.Size(115, 23);
            this.Github.TabIndex = 5;
            this.Github.TabStop = false;
            this.Github.Text = "Github";
            this.Github.UseVisualStyleBackColor = true;
            this.Github.Click += new System.EventHandler(this.Github_Click);
            // 
            // TarkovMarket
            // 
            this.TarkovMarket.Location = new System.Drawing.Point(21, 32);
            this.TarkovMarket.Name = "TarkovMarket";
            this.TarkovMarket.Size = new System.Drawing.Size(115, 23);
            this.TarkovMarket.TabIndex = 5;
            this.TarkovMarket.TabStop = false;
            this.TarkovMarket.Text = "Tarkov Market";
            this.TarkovMarket.UseVisualStyleBackColor = true;
            this.TarkovMarket.Click += new System.EventHandler(this.TarkovMarket_Click);
            // 
            // TarkovWiki
            // 
            this.TarkovWiki.Location = new System.Drawing.Point(21, 61);
            this.TarkovWiki.Name = "TarkovWiki";
            this.TarkovWiki.Size = new System.Drawing.Size(115, 23);
            this.TarkovWiki.TabIndex = 5;
            this.TarkovWiki.TabStop = false;
            this.TarkovWiki.Text = "Tarkov Wiki";
            this.TarkovWiki.UseVisualStyleBackColor = true;
            this.TarkovWiki.Click += new System.EventHandler(this.TarkovWiki_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.CheckUpdate);
            this.panel4.Controls.Add(this.Github);
            this.panel4.Controls.Add(this.DataProvidedBy);
            this.panel4.Controls.Add(this.TarkovWiki);
            this.panel4.Controls.Add(this.TarkovMarket);
            this.panel4.Location = new System.Drawing.Point(299, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(153, 157);
            this.panel4.TabIndex = 7;
            // 
            // DataProvidedBy
            // 
            this.DataProvidedBy.AutoSize = true;
            this.DataProvidedBy.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DataProvidedBy.Location = new System.Drawing.Point(19, 9);
            this.DataProvidedBy.Name = "DataProvidedBy";
            this.DataProvidedBy.Size = new System.Drawing.Size(118, 12);
            this.DataProvidedBy.TabIndex = 6;
            this.DataProvidedBy.Text = "Data Provided By";
            // 
            // MinimizetoTrayWhenStartup
            // 
            this.MinimizetoTrayWhenStartup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizetoTrayWhenStartup.AutoSize = true;
            this.MinimizetoTrayWhenStartup.Location = new System.Drawing.Point(254, 293);
            this.MinimizetoTrayWhenStartup.Name = "MinimizetoTrayWhenStartup";
            this.MinimizetoTrayWhenStartup.Size = new System.Drawing.Size(198, 16);
            this.MinimizetoTrayWhenStartup.TabIndex = 6;
            this.MinimizetoTrayWhenStartup.TabStop = false;
            this.MinimizetoTrayWhenStartup.Text = "Minimize to Tray When Startup";
            this.MinimizetoTrayWhenStartup.UseVisualStyleBackColor = true;
            this.MinimizetoTrayWhenStartup.CheckedChanged += new System.EventHandler(this.MinimizetoTrayWhenStartup_CheckedChanged);
            // 
            // Version
            // 
            this.Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(12, 300);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(48, 12);
            this.Version.TabIndex = 9;
            this.Version.Text = "Version";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TarkovPriceViewer.Properties.Resources.title;
            this.pictureBox1.Location = new System.Drawing.Point(58, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.MinimizetoTrayWhenStartup);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TarkovPriceViewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_load);
            this.TrayMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransParent_Bar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem trayshow;
        private System.Windows.Forms.ToolStripMenuItem trayexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ShowOverlay_Desc;
        private System.Windows.Forms.Button CheckUpdate;
        private System.Windows.Forms.Button ShowOverlay_Button;
        private System.Windows.Forms.Button HideOverlay_Button;
        private System.Windows.Forms.Label HideOverlay_Desc;
        private System.Windows.Forms.Label TransParent_Desc;
        private System.Windows.Forms.Button Github;
        private System.Windows.Forms.Button TarkovMarket;
        private System.Windows.Forms.Button TarkovWiki;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label DataProvidedBy;
        private System.Windows.Forms.CheckBox MinimizetoTrayWhenStartup;
        private System.Windows.Forms.CheckBox CloseOverlayWhenMouseMoved;
        private System.Windows.Forms.Label HideOverlay_Desc2;
        private System.Windows.Forms.TrackBar TransParent_Bar;
        private System.Windows.Forms.Label TransParent_Text;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

