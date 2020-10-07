using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1007
{
	public partial class Form1 : Form
	{
		string editingFileName;
		bool dirty = false; // 변경내용 판단을 위한 bool타입 변수
		string dirtyText = "*{0} - Windows 메모장";
		string cleanText = "{0} - Windows 메모장";
		public Form1()
		{
			InitializeComponent();
		}

		private void 도움ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void 새로만들ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Text = "제목없음 - Windows 메모장";
			this.textBox1.Focus();
		}

		private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "txt Files(*.txt)|*.txt|All Files (*.*)|*.*";
			openFileDialog1.FilterIndex = 1; // 필터의 기본값을 정해주는것 1이니까 기본값은 txt Files(*.txt)|*.txt
			if (openFileDialog1.ShowDialog() == DialogResult.OK)// 열기창을 뜨고 열기 버튼만 눌렀을때
			{
				editingFileName = openFileDialog1.FileName;

				try
				{
					StreamReader sr = new StreamReader(editingFileName, Encoding.UTF8);
					textBox1.Text = sr.ReadToEnd(); // 파일을 처음부터 끝까지 다읽어라
					sr.Close();

					dirty = false; //한번 파일을 열었을때 초기화를 시켜줘야함
					UpdateText();
					//string openFileName = editingFileName.Substring(editingFileName.LastIndexOf('\\') + 1);
					////editingFileName은 절대경로를 보여주기때문에 문자열처리로 파일이름만 추출
					//this.Text = string.Format(cleanText, openFileName);
					//// {0} - Windows 메모장 => 0안에 openFileName 내용이 들어가는것
				}
				catch (Exception err)
				{
					MessageBox.Show(err.Message);
				}
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (!dirty)
			{
				dirty = true;
				UpdateText();

			}
		}

		private void UpdateText()
		{
			string openFileName;
			if (string.IsNullOrEmpty(editingFileName))
			{
				openFileName = "제목없음";
			}
			else
			{
				openFileName = editingFileName.Substring(editingFileName.LastIndexOf('\\') + 1);
			}
			if (dirty)
				this.Text = string.Format(dirtyText, openFileName);
			else
				this.Text = string.Format(cleanText, openFileName);
		}

		private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(editingFileName))
			{
				//다른이름으로 저장하고 동일하게
				다른이름으로저장AToolStripMenuItem_Click(null, null);// 파라미터에 딱히 줄게 없을때 타입의 기본형만 줘도 가능

			}
			else
			{
				//그 파일명으로 파일 덮어쓰기
				SaveFile(editingFileName);
			}
		}

		private void SaveFile(string fileName)
		{
			try
			{
				using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
				//Append가 true면 데이터가 두배씩 늘어남
				{
					sw.Write(textBox1.Text);
					//editingFileName = saveFileDialog1.FileName;
					sw.Flush();
				}
				dirty = false;
				UpdateText();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}

		private void 다른이름으로저장AToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Filter="txt Files(*.txt)|*.txt|All Files (*.*)|*.*"; 
			//바를 기준으로 두개씩 짝이다 [txt Files(*.txt)|*.txt] 이렇게 짝 (바 뒤쪽에는 공백이 들어가면 안됨!바 뒤쪽은 시스템이 이해하는 곳이기 떄문)
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				editingFileName = saveFileDialog1.FileName;
				SaveFile(saveFileDialog1.FileName);
			}
		}
	}
}
