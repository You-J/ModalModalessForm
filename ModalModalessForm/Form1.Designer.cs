namespace ModalModalessForm
{
    partial class FormMain
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
            this.btmModal = new System.Windows.Forms.Button();
            this.btnModaless = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modalessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이프로그램은ModalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이프로그램은ModalessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btmModal
            // 
            this.btmModal.Location = new System.Drawing.Point(10, 22);
            this.btmModal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmModal.Name = "btmModal";
            this.btmModal.Size = new System.Drawing.Size(195, 113);
            this.btmModal.TabIndex = 1;
            this.btmModal.Text = "모달창 띄우기";
            this.btmModal.UseVisualStyleBackColor = true;
            this.btmModal.Click += new System.EventHandler(this.BtmModal_Click);
            // 
            // btnModaless
            // 
            this.btnModaless.Location = new System.Drawing.Point(211, 22);
            this.btnModaless.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModaless.Name = "btnModaless";
            this.btnModaless.Size = new System.Drawing.Size(201, 113);
            this.btnModaless.TabIndex = 4;
            this.btnModaless.Text = "모달리스창 띄우기";
            this.btnModaless.UseVisualStyleBackColor = true;
            this.btnModaless.Click += new System.EventHandler(this.BtnModaless_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.창ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(423, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            // 
            // 창ToolStripMenuItem
            // 
            this.창ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modalToolStripMenuItem,
            this.modalessToolStripMenuItem});
            this.창ToolStripMenuItem.Name = "창ToolStripMenuItem";
            this.창ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.창ToolStripMenuItem.Text = "창띄우기";
            // 
            // modalToolStripMenuItem
            // 
            this.modalToolStripMenuItem.Name = "modalToolStripMenuItem";
            this.modalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modalToolStripMenuItem.Text = "Modal";
            this.modalToolStripMenuItem.Click += new System.EventHandler(this.ModalToolStripMenuItem_Click);
            // 
            // modalessToolStripMenuItem
            // 
            this.modalessToolStripMenuItem.Name = "modalessToolStripMenuItem";
            this.modalessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modalessToolStripMenuItem.Text = "Modaless";
            this.modalessToolStripMenuItem.Click += new System.EventHandler(this.ModalessToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.이프로그램은ModalToolStripMenuItem,
            this.이프로그램은ModalessToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 이프로그램은ModalToolStripMenuItem
            // 
            this.이프로그램은ModalToolStripMenuItem.Name = "이프로그램은ModalToolStripMenuItem";
            this.이프로그램은ModalToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.이프로그램은ModalToolStripMenuItem.Text = "이 프로그램은..(Modal)";
            this.이프로그램은ModalToolStripMenuItem.Click += new System.EventHandler(this.이프로그램은ModalToolStripMenuItem_Click);
            // 
            // 이프로그램은ModalessToolStripMenuItem
            // 
            this.이프로그램은ModalessToolStripMenuItem.Name = "이프로그램은ModalessToolStripMenuItem";
            this.이프로그램은ModalessToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.이프로그램은ModalessToolStripMenuItem.Text = "이 프로그램은..(Modaless)";
            this.이프로그램은ModalessToolStripMenuItem.Click += new System.EventHandler(this.이프로그램은ModalessToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusTitle,
            this.statusMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 139);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(423, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusTitle
            // 
            this.statusTitle.Name = "statusTitle";
            this.statusTitle.Size = new System.Drawing.Size(42, 17);
            this.statusTitle.Text = "상태 : ";
            // 
            // statusMessage
            // 
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(12, 17);
            this.statusMessage.Text = "-";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 161);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnModaless);
            this.Controls.Add(this.btmModal);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Modal & Modaless 창 띄우기 by 3113 이유정";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmModal;
        private System.Windows.Forms.Button btnModaless;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 창ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modalessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이프로그램은ModalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이프로그램은ModalessToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusTitle;
        private System.Windows.Forms.ToolStripStatusLabel statusMessage;
    }
}

