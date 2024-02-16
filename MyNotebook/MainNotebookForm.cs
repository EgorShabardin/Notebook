using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Collections.Generic;

namespace MyNotebook
{
    public partial class MainNotebookForm : Form
    {
        #region Поля
        private string pathToFile = "Безымянный";
        private Encoding encoding = Encoding.UTF8;
        private bool isFileSaved = false;
        #endregion

        #region Обработчики событий
        #region Раздел "Файл" NotebookMenuStrip
        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Создать".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isFileSaved)
            {
                DialogResult dialogResult = MessageBox.Show($"Вы хотите сохранить изменения в файле {pathToFile}?", "Блокнот", MessageBoxButtons.YesNoCancel);

                if (dialogResult == DialogResult.Yes)
                {
                    SaveToolStripMenuItem_Click(sender, e);
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
            }

            EncodingData.Text = "UTF - 8";
            Text = $"Безымянный - Блокнот";
            NotebookRichTextBox.Text = String.Empty;
            NotebookRichTextBox.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            NotebookRichTextBox.ForeColor = Color.Black;

            encoding = Encoding.UTF8;
            pathToFile = "Безымянный";
            isFileSaved = false;
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Открыть".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isFileSaved)
            {
                DialogResult dialogResult = MessageBox.Show($"Вы хотите сохранить изменения в файле {pathToFile}?", "Блокнот", MessageBoxButtons.YesNoCancel);

                if (dialogResult == DialogResult.Yes)
                {
                    SaveToolStripMenuItem_Click(sender, e);
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
            }

            if (NotebookOpenFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            byte[] fileBytes = File.ReadAllBytes(NotebookOpenFileDialog.FileName);

            if (fileBytes[0] == 0)
            {
                List<byte> UTF8Bytes = fileBytes.ToList();
                UTF8Bytes.RemoveAt(0);

                char[] UTF8Chars = new char[Encoding.UTF8.GetCharCount(UTF8Bytes.ToArray(), 0, UTF8Bytes.Count)];
                Encoding.UTF8.GetChars(UTF8Bytes.ToArray(), 0, UTF8Bytes.Count, UTF8Chars, 0);
                NotebookRichTextBox.Rtf = new string(UTF8Chars);

                encoding = Encoding.UTF8;
                EncodingData.Text = "UTF - 8";
            }
            else if (fileBytes[0] == 1)
            {
                List<byte> UnicodeBytes = fileBytes.ToList();
                UnicodeBytes.RemoveAt(0);

                char[] UnicodeChars = new char[Encoding.Unicode.GetCharCount(UnicodeBytes.ToArray(), 0, UnicodeBytes.Count)];
                Encoding.Unicode.GetChars(UnicodeBytes.ToArray(), 0, UnicodeBytes.Count, UnicodeChars, 0);
                NotebookRichTextBox.Rtf = new string(UnicodeChars);

                encoding = Encoding.Unicode;
                EncodingData.Text = "Unicode";
            }
            else if (fileBytes[0] == 2)
            {
                List<byte> ASCIIBytes = fileBytes.ToList();
                ASCIIBytes.RemoveAt(0);

                char[] ASCIIChars = new char[Encoding.ASCII.GetCharCount(ASCIIBytes.ToArray(), 0, ASCIIBytes.Count)];
                Encoding.ASCII.GetChars(ASCIIBytes.ToArray(), 0, ASCIIBytes.Count, ASCIIChars, 0);
                NotebookRichTextBox.Rtf = new string(ASCIIChars);

                encoding = Encoding.ASCII;
                EncodingData.Text = "ASCII";
            }
            pathToFile = NotebookOpenFileDialog.FileName;
            isFileSaved = true;

            Text = Path.GetFileNameWithoutExtension(pathToFile) + " - Блокнот";
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Сохранить".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(pathToFile))
            {
                if (encoding == Encoding.UTF8)
                {
                    List<byte> UTF8Bytes = Encoding.UTF8.GetBytes(NotebookRichTextBox.Rtf).ToList<byte>();
                    UTF8Bytes.Insert(0, 0);

                    File.WriteAllBytes(pathToFile, UTF8Bytes.ToArray());

                    isFileSaved = true;
                    return;
                }
                else if (encoding == Encoding.Unicode)
                {
                    List<byte> UnicodeBytes = Encoding.Unicode.GetBytes(NotebookRichTextBox.Rtf).ToList<byte>();
                    UnicodeBytes.Insert(0, 1);

                    File.WriteAllBytes(pathToFile, UnicodeBytes.ToArray());

                    isFileSaved = true;
                    return;
                }
                else if (encoding == Encoding.ASCII)
                {
                    List<byte> ASCIIBytes = Encoding.ASCII.GetBytes(NotebookRichTextBox.Rtf).ToList<byte>();
                    ASCIIBytes.Insert(0, 2);

                    File.WriteAllBytes(pathToFile, ASCIIBytes.ToArray());

                    isFileSaved = true;
                    return;
                }
            }

            if (NotebookSaveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            if (encoding == Encoding.UTF8)
            {
                List<byte> UTF8Bytes = Encoding.UTF8.GetBytes(NotebookRichTextBox.Rtf).ToList<byte>();
                UTF8Bytes.Insert(0, 0);

                File.WriteAllBytes(NotebookSaveFileDialog.FileName, UTF8Bytes.ToArray());
            }
            else if (encoding == Encoding.Unicode)
            {
                List<byte> UnicodeBytes = Encoding.Unicode.GetBytes(NotebookRichTextBox.Rtf).ToList<byte>();
                UnicodeBytes.Insert(0, 1);

                File.WriteAllBytes(NotebookSaveFileDialog.FileName, UnicodeBytes.ToArray());
            }
            else if (encoding == Encoding.ASCII)
            {
                List<byte> ASCIIBytes = Encoding.ASCII.GetBytes(NotebookRichTextBox.Rtf).ToList<byte>();
                ASCIIBytes.Insert(0, 2);

                File.WriteAllBytes(NotebookSaveFileDialog.FileName, ASCIIBytes.ToArray());
            }
            Text = Path.GetFileNameWithoutExtension(pathToFile) + " - Блокнот";

            pathToFile = NotebookSaveFileDialog.FileName;    
            isFileSaved = true;
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Печать".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NotebookPrintDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            NotebookPrintDocument.DocumentName = "Текстовый документ";
            NotebookPrintDocument.PrinterSettings = NotebookPrintDialog.PrinterSettings;
            NotebookPrintDialog.Document.Print();   
        }

        /// <summary>
        /// Метод, который обрабатывает печать страниц.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void NotebookPrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(NotebookRichTextBox.Text, NotebookRichTextBox.Font, new SolidBrush(Color.Black), 5, 5);
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Выход".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Раздел "Шрифт" NotebookMenuStrip
        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Изменить цвет всего текста".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void ChangeAllTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NotebookColorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            NotebookRichTextBox.ForeColor = NotebookColorDialog.Color;
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Изменить шрифт всего текста".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void ChangeAllTextFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NotebookFontDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            NotebookRichTextBox.Font = NotebookFontDialog.Font;
        }
        #endregion

        #region Раздел "Правка" NotebookMenuStrip
        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Вырезать".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void CutToolMenuItem_Click(object sender, EventArgs e)
        {
            NotebookRichTextBox.Cut();
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Копировать".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void CopyToolMenuItem_Click(object sender, EventArgs e)
        {
            NotebookRichTextBox.Copy();
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Вставить".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void PasteToolMenuItem_Click(object sender, EventArgs e)
        {
            NotebookRichTextBox.Paste();
        }
        #endregion

        #region Раздел "Кодировка" NotebookMenuStrip
        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "UTF-8".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void UTF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encoding = Encoding.UTF8;
            isFileSaved = false;

            EncodingData.Text = "UTF - 8";
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Unicode".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void UnicodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encoding = Encoding.Unicode;
            isFileSaved = false;

            EncodingData.Text = "Unicode";
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "ASCII".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void ASKIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encoding = Encoding.ASCII;
            isFileSaved = false;

            EncodingData.Text = "ASKII";
        }
        #endregion

        #region Раздел "Справка" NotebookMenuStrip
        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Справка".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void InformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Блокнот 1.0.0.0\n\n© Application development company, 2024. Все права защищены.", "Информация о приложении");
        }
        #endregion

        #region Контекстное меню NotebookContextMenuStrip
        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Изменить цвет части текста".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void ChangeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NotebookColorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            NotebookRichTextBox.SelectionColor = NotebookColorDialog.Color;
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Изменить шрифт части текста".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void ChangeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NotebookFontDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            NotebookRichTextBox.SelectionFont = NotebookFontDialog.Font;
        }
        #endregion

        /// <summary>
        /// Метод, который обрабатывает изменение текста в NotebookRichTextBox.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param> cxer3
        private void NotebookRichTextBox_TextChanged(object sender, EventArgs e)
        {
            isFileSaved = false;
            NotebookNumberOfCharacters.Text = $"Число символов {NotebookRichTextBox.Text.Length}";
        }

        /// <summary>
        /// Метод, который обрабатывает закрытие формы, нажатием на крестик.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void MainNotebookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isFileSaved)
            {
                DialogResult dialogResult = MessageBox.Show($"Вы хотите сохранить изменения в файле {pathToFile}?", "Блокнот", MessageBoxButtons.YesNoCancel);

                if (dialogResult == DialogResult.Yes)
                {
                    SaveToolStripMenuItem_Click(sender, e);
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
        #endregion

        #region Конструкторы
        public MainNotebookForm()
        {
            InitializeComponent();
            NotebookRichTextBox.SelectionIndent = 6;
            NotebookRichTextBox.SelectionRightIndent = 6;
        }




        #endregion
    }
}