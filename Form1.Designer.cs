
namespace testControler
{
    partial class Form1
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
            this.Btn_Foward = new System.Windows.Forms.Button();
            this.Btn_Backword = new System.Windows.Forms.Button();
            this.Btn_Left = new System.Windows.Forms.Button();
            this.Btn_Right = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Foward
            // 
            this.Btn_Foward.Location = new System.Drawing.Point(544, 103);
            this.Btn_Foward.Name = "Btn_Foward";
            this.Btn_Foward.Size = new System.Drawing.Size(100, 91);
            this.Btn_Foward.TabIndex = 0;
            this.Btn_Foward.Text = "Foward";
            this.Btn_Foward.UseVisualStyleBackColor = true;
            this.Btn_Foward.Click += new System.EventHandler(this.Btn_Foward_Click);
            // 
            // Btn_Backword
            // 
            this.Btn_Backword.Location = new System.Drawing.Point(544, 200);
            this.Btn_Backword.Name = "Btn_Backword";
            this.Btn_Backword.Size = new System.Drawing.Size(100, 91);
            this.Btn_Backword.TabIndex = 0;
            this.Btn_Backword.Text = "Backward";
            this.Btn_Backword.UseVisualStyleBackColor = true;
            this.Btn_Backword.Click += new System.EventHandler(this.Btn_Backword_Click);
            // 
            // Btn_Left
            // 
            this.Btn_Left.Location = new System.Drawing.Point(438, 200);
            this.Btn_Left.Name = "Btn_Left";
            this.Btn_Left.Size = new System.Drawing.Size(100, 91);
            this.Btn_Left.TabIndex = 0;
            this.Btn_Left.Text = "Left";
            this.Btn_Left.UseVisualStyleBackColor = true;
            this.Btn_Left.Click += new System.EventHandler(this.Btn_Left_Click);
            // 
            // Btn_Right
            // 
            this.Btn_Right.Location = new System.Drawing.Point(650, 200);
            this.Btn_Right.Name = "Btn_Right";
            this.Btn_Right.Size = new System.Drawing.Size(100, 91);
            this.Btn_Right.TabIndex = 0;
            this.Btn_Right.Text = "Right";
            this.Btn_Right.UseVisualStyleBackColor = true;
            this.Btn_Right.Click += new System.EventHandler(this.Btn_Right_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Left);
            this.Controls.Add(this.Btn_Right);
            this.Controls.Add(this.Btn_Backword);
            this.Controls.Add(this.Btn_Foward);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Foward;
        private System.Windows.Forms.Button Btn_Backword;
        private System.Windows.Forms.Button Btn_Left;
        private System.Windows.Forms.Button Btn_Right;
    }
}

