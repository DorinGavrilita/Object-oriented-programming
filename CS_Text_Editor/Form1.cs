using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CS_Text_Editor
{
   public partial class Form1: Form
   {
      public Form1()
      {
         InitializeComponent();
         saveFileDialog1.Filter = "Text file(*.txt)|*.txt";
      }

      private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Form1 newForm = new Form1();
         newForm.Show();
      }

      private void выходToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
      {
         /*         OpenFileDialog ofd = new OpenFileDialog();
                  ofd.Filter = "Text Files (.txt)|*.txt";
                  ofd.Title = "Open a file...";
                  if (ofd.ShowDialog() == DialogResult.OK)
                  {
                     System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                     richTextBox1.Text = sr.ReadToEnd();
                     sr.Close();
                  }*/
         if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            return;
         string filename = openFileDialog1.FileName;
         string fileText = File.ReadAllText(filename);
         richTextBox1.Text = fileText;
         MessageBox.Show("Файл открыт!");
      }

      private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
      {
         SaveFileDialog svf = new SaveFileDialog();
         svf.Filter = "Text Files (.txt)|*.txt";
         svf.Title = "Save file...";
         if (svf.ShowDialog() == DialogResult.OK)
         {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(svf.FileName);
            sw.Write(richTextBox1.Text);
            sw.Close();
         }
      }

      private void сохранитькакToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            return;
         string filename = saveFileDialog1.FileName;

         File.WriteAllText(filename, richTextBox1.Text);
         MessageBox.Show("Файл сохранён!");
      }


      private void отменадействияToolStripMenuItem_Click(object sender, EventArgs e)
      {
         richTextBox1.Undo();
      }

      private void вернутьдействияToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         richTextBox1.Redo();
      }

      private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (richTextBox1.TextLength > 0)
         {
            richTextBox1.Cut();
         }
      }

      private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (richTextBox1.TextLength > 0)
         {
            richTextBox1.Copy();
         }
      }

      private void вставкаToolStripMenuItem_Click(object sender, EventArgs e)
      {
         richTextBox1.Paste();
      }

      private void выделитьвсеToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (richTextBox1.TextLength > 0)
         {
            richTextBox1.SelectAll();
         }
      }

      private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
      {
         fontDialog1.ShowDialog();
         richTextBox1.SelectionFont = fontDialog1.Font;
      }

      private void фонToolStripMenuItem_Click(object sender, EventArgs e)
      {
         colorDialog1.ShowDialog();
         richTextBox1.BackColor = colorDialog1.Color;
      }

      private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
      {

      }

      private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
      {
         if (e.Button == MouseButtons.Right)
         {
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
         }
      }

      private void вырезатьToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         if (richTextBox1.TextLength > 0)
         {
            richTextBox1.Cut();
         }
      }

      private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         if (richTextBox1.TextLength > 0)
         {
            richTextBox1.Copy();
         }
      }

      private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (richTextBox1.TextLength >= 0)
         {
            richTextBox1.Paste();
         }
      }

      private void выделитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (richTextBox1.TextLength > 0)
         {
            richTextBox1.SelectAll();
         }
      }

      private void ОпрограммеToolStripMenuItem_Click(object sender, EventArgs e)
      {
         AboutBox1 about = new AboutBox1();
         about.ShowDialog();
      }

      private void шрифтToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         fontDialog1.ShowDialog();
         richTextBox1.SelectionFont = fontDialog1.Font;
      }

      private void фонToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         colorDialog1.ShowDialog();
         richTextBox1.BackColor = colorDialog1.Color;
      }
      private void цветToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            richTextBox1.SelectionColor = colorDialog1.Color;
      }

      private void создатьToolStripButton_Click(object sender, EventArgs e)
      {
         создатьToolStripMenuItem_Click(sender, e);
      }

      private void findText_TextChanged(object sender, EventArgs e)
      {
         Regex regex = new Regex(findText.Text);
         MatchCollection matches = regex.Matches(richTextBox1.Text);
         richTextBox1.SelectAll();
         richTextBox1.SelectionBackColor = richTextBox1.BackColor;
         foreach (Match match in matches)
         {
            richTextBox1.Select(match.Index, match.Length);
            richTextBox1.SelectionBackColor = Color.Yellow;
         }
      }

      private void replaceBtn_Click(object sender, EventArgs e)
      {
         ReplaceAll(richTextBox1, findText.Text, replaceText.Text);
      }

      public void ReplaceAll(RichTextBox myRtb, string word, string replacement)
      {
         int i = 0;
         int n = 0;
         int a = replacement.Length - word.Length;
         foreach (Match m in Regex.Matches(myRtb.Text, word))
         {
            myRtb.Select(m.Index + i, word.Length);
            i += a;
            myRtb.SelectedText = replacement;
            n++;
         }
         MessageBox.Show("Заменено " + n + " совпадение(-ий)!");
      }

   }
}
