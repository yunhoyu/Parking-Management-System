namespace Week5_Homework
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
            if (disposing && (components != null)) {
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.btnArrive = new System.Windows.Forms.Button();
            this.btnDeparture = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.tbxView = new System.Windows.Forms.TextBox();
            this.rbtnShortTerm = new System.Windows.Forms.RadioButton();
            this.rbtnLongTerm = new System.Windows.Forms.RadioButton();
            this.pnlTermData = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTerm = new System.Windows.Forms.TextBox();
            this.rbtnFree = new System.Windows.Forms.RadioButton();
            this.pnlTermData.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "차량번호";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(187, 48);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(158, 29);
            this.tbxNumber.TabIndex = 1;
            // 
            // btnArrive
            // 
            this.btnArrive.Location = new System.Drawing.Point(351, 48);
            this.btnArrive.Name = "btnArrive";
            this.btnArrive.Size = new System.Drawing.Size(97, 29);
            this.btnArrive.TabIndex = 2;
            this.btnArrive.Text = "입차";
            this.btnArrive.UseVisualStyleBackColor = true;
            this.btnArrive.Click += new System.EventHandler(this.btnArrive_Click);
            // 
            // btnDeparture
            // 
            this.btnDeparture.Location = new System.Drawing.Point(454, 48);
            this.btnDeparture.Name = "btnDeparture";
            this.btnDeparture.Size = new System.Drawing.Size(97, 29);
            this.btnDeparture.TabIndex = 2;
            this.btnDeparture.Text = "출차";
            this.btnDeparture.UseVisualStyleBackColor = true;
            this.btnDeparture.Click += new System.EventHandler(this.btnDeparture_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(778, 85);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(97, 29);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "조회";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // tbxView
            // 
            this.tbxView.Location = new System.Drawing.Point(25, 137);
            this.tbxView.Multiline = true;
            this.tbxView.Name = "tbxView";
            this.tbxView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxView.Size = new System.Drawing.Size(850, 346);
            this.tbxView.TabIndex = 3;
            // 
            // rbtnShortTerm
            // 
            this.rbtnShortTerm.AutoSize = true;
            this.rbtnShortTerm.Checked = true;
            this.rbtnShortTerm.Location = new System.Drawing.Point(38, 95);
            this.rbtnShortTerm.Name = "rbtnShortTerm";
            this.rbtnShortTerm.Size = new System.Drawing.Size(65, 23);
            this.rbtnShortTerm.TabIndex = 4;
            this.rbtnShortTerm.TabStop = true;
            this.rbtnShortTerm.Text = "단기";
            this.rbtnShortTerm.UseVisualStyleBackColor = true;
            this.rbtnShortTerm.CheckedChanged += new System.EventHandler(this.rbtnType_CheckedChanged);
            // 
            // rbtnLongTerm
            // 
            this.rbtnLongTerm.AutoSize = true;
            this.rbtnLongTerm.Location = new System.Drawing.Point(184, 95);
            this.rbtnLongTerm.Name = "rbtnLongTerm";
            this.rbtnLongTerm.Size = new System.Drawing.Size(65, 23);
            this.rbtnLongTerm.TabIndex = 5;
            this.rbtnLongTerm.Text = "장기";
            this.rbtnLongTerm.UseVisualStyleBackColor = true;
            this.rbtnLongTerm.CheckedChanged += new System.EventHandler(this.rbtnType_CheckedChanged);
            // 
            // pnlTermData
            // 
            this.pnlTermData.Controls.Add(this.label2);
            this.pnlTermData.Controls.Add(this.tbxTerm);
            this.pnlTermData.Location = new System.Drawing.Point(257, 91);
            this.pnlTermData.Name = "pnlTermData";
            this.pnlTermData.Size = new System.Drawing.Size(364, 31);
            this.pnlTermData.TabIndex = 6;
            this.pnlTermData.Visible = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "기간 (초단위)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxTerm
            // 
            this.tbxTerm.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbxTerm.Location = new System.Drawing.Point(206, 0);
            this.tbxTerm.Name = "tbxTerm";
            this.tbxTerm.Size = new System.Drawing.Size(158, 29);
            this.tbxTerm.TabIndex = 1;
            // 
            // rbtnFree
            // 
            this.rbtnFree.AutoSize = true;
            this.rbtnFree.Location = new System.Drawing.Point(111, 95);
            this.rbtnFree.Name = "rbtnFree";
            this.rbtnFree.Size = new System.Drawing.Size(65, 23);
            this.rbtnFree.TabIndex = 5;
            this.rbtnFree.Text = "무료";
            this.rbtnFree.UseVisualStyleBackColor = true;
            this.rbtnFree.CheckedChanged += new System.EventHandler(this.rbtnType_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(899, 511);
            this.Controls.Add(this.pnlTermData);
            this.Controls.Add(this.rbtnFree);
            this.Controls.Add(this.rbtnLongTerm);
            this.Controls.Add(this.rbtnShortTerm);
            this.Controls.Add(this.tbxView);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDeparture);
            this.Controls.Add(this.btnArrive);
            this.Controls.Add(this.tbxNumber);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "FormMain";
            this.Text = "주차관리시스템";
            this.pnlTermData.ResumeLayout(false);
            this.pnlTermData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Button btnArrive;
        private System.Windows.Forms.Button btnDeparture;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox tbxView;
        private System.Windows.Forms.RadioButton rbtnShortTerm;
        private System.Windows.Forms.RadioButton rbtnLongTerm;
        private System.Windows.Forms.Panel pnlTermData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTerm;
        private System.Windows.Forms.RadioButton rbtnFree;
    }
}

