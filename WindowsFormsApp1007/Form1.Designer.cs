namespace WindowsFormsApp1007
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.서식EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.보기VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.도움ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.새로만들ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.새창WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.열기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.다른이름으로저장AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.끝내기XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.실행취소ZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.잘라내ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.복사CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.붙여넣기PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.삭제LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.bing으로검색SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.찾기FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.다음찾기NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.이전찾기VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.바꾸기RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.이동GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.모두선택AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.시간날짜DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.편집EToolStripMenuItem,
            this.서식EToolStripMenuItem,
            this.보기VToolStripMenuItem,
            this.도움ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(808, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 파일FToolStripMenuItem
			// 
			this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들ToolStripMenuItem,
            this.새창WToolStripMenuItem,
            this.열기OToolStripMenuItem,
            this.저장SToolStripMenuItem,
            this.다른이름으로저장AToolStripMenuItem,
            this.toolStripSeparator1,
            this.끝내기XToolStripMenuItem});
			this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
			this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.파일FToolStripMenuItem.Text = "파일(F)";
			// 
			// 편집EToolStripMenuItem
			// 
			this.편집EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소ZToolStripMenuItem,
            this.toolStripSeparator2,
            this.잘라내ToolStripMenuItem,
            this.복사CToolStripMenuItem,
            this.붙여넣기PToolStripMenuItem,
            this.삭제LToolStripMenuItem,
            this.toolStripSeparator3,
            this.bing으로검색SToolStripMenuItem,
            this.찾기FToolStripMenuItem,
            this.다음찾기NToolStripMenuItem,
            this.이전찾기VToolStripMenuItem,
            this.바꾸기RToolStripMenuItem,
            this.이동GToolStripMenuItem,
            this.toolStripSeparator4,
            this.모두선택AToolStripMenuItem,
            this.시간날짜DToolStripMenuItem});
			this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
			this.편집EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.편집EToolStripMenuItem.Text = "편집(E)";
			// 
			// 서식EToolStripMenuItem
			// 
			this.서식EToolStripMenuItem.Name = "서식EToolStripMenuItem";
			this.서식EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.서식EToolStripMenuItem.Text = "서식(E)";
			// 
			// 보기VToolStripMenuItem
			// 
			this.보기VToolStripMenuItem.Name = "보기VToolStripMenuItem";
			this.보기VToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.보기VToolStripMenuItem.Text = "보기(V)";
			// 
			// 도움ToolStripMenuItem
			// 
			this.도움ToolStripMenuItem.Name = "도움ToolStripMenuItem";
			this.도움ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.도움ToolStripMenuItem.Text = "도움말(H)";
			this.도움ToolStripMenuItem.Click += new System.EventHandler(this.도움ToolStripMenuItem_Click);
			// 
			// 새로만들ToolStripMenuItem
			// 
			this.새로만들ToolStripMenuItem.Name = "새로만들ToolStripMenuItem";
			this.새로만들ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.새로만들ToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
			this.새로만들ToolStripMenuItem.Text = "새로 만들기(N)";
			this.새로만들ToolStripMenuItem.Click += new System.EventHandler(this.새로만들ToolStripMenuItem_Click);
			// 
			// 새창WToolStripMenuItem
			// 
			this.새창WToolStripMenuItem.Name = "새창WToolStripMenuItem";
			this.새창WToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
			this.새창WToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
			this.새창WToolStripMenuItem.Text = "새 창(W)";
			// 
			// 열기OToolStripMenuItem
			// 
			this.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem";
			this.열기OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.열기OToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
			this.열기OToolStripMenuItem.Text = "열기(O)";
			this.열기OToolStripMenuItem.Click += new System.EventHandler(this.열기OToolStripMenuItem_Click);
			// 
			// 저장SToolStripMenuItem
			// 
			this.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem";
			this.저장SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.저장SToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
			this.저장SToolStripMenuItem.Text = "저장(S)";
			this.저장SToolStripMenuItem.Click += new System.EventHandler(this.저장SToolStripMenuItem_Click);
			// 
			// 다른이름으로저장AToolStripMenuItem
			// 
			this.다른이름으로저장AToolStripMenuItem.Name = "다른이름으로저장AToolStripMenuItem";
			this.다른이름으로저장AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.다른이름으로저장AToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
			this.다른이름으로저장AToolStripMenuItem.Text = "다른 이름으로 저장(A)";
			this.다른이름으로저장AToolStripMenuItem.Click += new System.EventHandler(this.다른이름으로저장AToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(265, 6);
			// 
			// 끝내기XToolStripMenuItem
			// 
			this.끝내기XToolStripMenuItem.Name = "끝내기XToolStripMenuItem";
			this.끝내기XToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
			this.끝내기XToolStripMenuItem.Text = "끝내기(X)";
			// 
			// 실행취소ZToolStripMenuItem
			// 
			this.실행취소ZToolStripMenuItem.Name = "실행취소ZToolStripMenuItem";
			this.실행취소ZToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.실행취소ZToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.실행취소ZToolStripMenuItem.Text = "실행 취소(U)";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
			// 
			// 잘라내ToolStripMenuItem
			// 
			this.잘라내ToolStripMenuItem.Name = "잘라내ToolStripMenuItem";
			this.잘라내ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.잘라내ToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.잘라내ToolStripMenuItem.Text = "잘라내기(T)";
			// 
			// 복사CToolStripMenuItem
			// 
			this.복사CToolStripMenuItem.Name = "복사CToolStripMenuItem";
			this.복사CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.복사CToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.복사CToolStripMenuItem.Text = "복사(C)";
			// 
			// 붙여넣기PToolStripMenuItem
			// 
			this.붙여넣기PToolStripMenuItem.Name = "붙여넣기PToolStripMenuItem";
			this.붙여넣기PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.붙여넣기PToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.붙여넣기PToolStripMenuItem.Text = "붙여넣기(P)";
			// 
			// 삭제LToolStripMenuItem
			// 
			this.삭제LToolStripMenuItem.Name = "삭제LToolStripMenuItem";
			this.삭제LToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.삭제LToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.삭제LToolStripMenuItem.Text = "삭제(L)";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(202, 6);
			// 
			// bing으로검색SToolStripMenuItem
			// 
			this.bing으로검색SToolStripMenuItem.Name = "bing으로검색SToolStripMenuItem";
			this.bing으로검색SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.bing으로검색SToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.bing으로검색SToolStripMenuItem.Text = "Bing으로 검색(S)";
			// 
			// 찾기FToolStripMenuItem
			// 
			this.찾기FToolStripMenuItem.Name = "찾기FToolStripMenuItem";
			this.찾기FToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.찾기FToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.찾기FToolStripMenuItem.Text = "찾기(F)";
			// 
			// 다음찾기NToolStripMenuItem
			// 
			this.다음찾기NToolStripMenuItem.Name = "다음찾기NToolStripMenuItem";
			this.다음찾기NToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.다음찾기NToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.다음찾기NToolStripMenuItem.Text = "다음 찾기(N)";
			// 
			// 이전찾기VToolStripMenuItem
			// 
			this.이전찾기VToolStripMenuItem.Name = "이전찾기VToolStripMenuItem";
			this.이전찾기VToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
			this.이전찾기VToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.이전찾기VToolStripMenuItem.Text = "이전 찾기(V)";
			// 
			// 바꾸기RToolStripMenuItem
			// 
			this.바꾸기RToolStripMenuItem.Name = "바꾸기RToolStripMenuItem";
			this.바꾸기RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
			this.바꾸기RToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.바꾸기RToolStripMenuItem.Text = "바꾸기(R)";
			// 
			// 이동GToolStripMenuItem
			// 
			this.이동GToolStripMenuItem.Name = "이동GToolStripMenuItem";
			this.이동GToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
			this.이동GToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.이동GToolStripMenuItem.Text = "이동(G)";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(202, 6);
			// 
			// 모두선택AToolStripMenuItem
			// 
			this.모두선택AToolStripMenuItem.Name = "모두선택AToolStripMenuItem";
			this.모두선택AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.모두선택AToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.모두선택AToolStripMenuItem.Text = "모두 선택(A)";
			// 
			// 시간날짜DToolStripMenuItem
			// 
			this.시간날짜DToolStripMenuItem.Name = "시간날짜DToolStripMenuItem";
			this.시간날짜DToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.시간날짜DToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.시간날짜DToolStripMenuItem.Text = "시간/날짜(D)";
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Font = new System.Drawing.Font("나눔고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox1.Location = new System.Drawing.Point(0, 24);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(808, 450);
			this.textBox1.TabIndex = 4;
			this.textBox1.WordWrap = false;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 474);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 서식EToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 보기VToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 도움ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 새로만들ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 새창WToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 열기OToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 저장SToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장AToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem 끝내기XToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 실행취소ZToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem 잘라내ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 복사CToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 붙여넣기PToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 삭제LToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem bing으로검색SToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 찾기FToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 다음찾기NToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 이전찾기VToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 바꾸기RToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 이동GToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem 모두선택AToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 시간날짜DToolStripMenuItem;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}

