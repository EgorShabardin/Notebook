namespace MyNotebook
{
    partial class MainNotebookForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing"> Истинно, если управляемый ресурс должен быть удален; иначе ложно. </param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainNotebookForm));
            this.NotebookMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeTextColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeTextFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EncodingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnicodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ASKIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotebookStatusStrip = new System.Windows.Forms.StatusStrip();
            this.NotebookNumberOfCharacters = new System.Windows.Forms.ToolStripStatusLabel();
            this.EncodingData = new System.Windows.Forms.ToolStripStatusLabel();
            this.NotebookContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyToolContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeColorToolContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeFontToolContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotebookRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NotebookColorDialog = new System.Windows.Forms.ColorDialog();
            this.NotebookFontDialog = new System.Windows.Forms.FontDialog();
            this.NotebookOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.NotebookSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.NotebookPrintDialog = new System.Windows.Forms.PrintDialog();
            this.NotebookPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.NotebookMenuStrip.SuspendLayout();
            this.NotebookStatusStrip.SuspendLayout();
            this.NotebookContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotebookMenuStrip
            // 
            this.NotebookMenuStrip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.NotebookMenuStrip.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotebookMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NotebookMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.FontToolStripMenuItem,
            this.EditingToolStripMenuItem,
            this.EncodingsToolStripMenuItem1,
            this.InformationToolStripMenuItem});
            this.NotebookMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.NotebookMenuStrip.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.NotebookMenuStrip.Name = "NotebookMenuStrip";
            this.NotebookMenuStrip.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.NotebookMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.NotebookMenuStrip.Size = new System.Drawing.Size(782, 32);
            this.NotebookMenuStrip.TabIndex = 0;
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.PrintToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.CreateToolStripMenuItem.Text = "Создать";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.PrintToolStripMenuItem.Text = "Печать";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeTextColorToolStripMenuItem,
            this.ChangeTextFontToolStripMenuItem});
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.FontToolStripMenuItem.Text = "Шрифт";
            // 
            // ChangeTextColorToolStripMenuItem
            // 
            this.ChangeTextColorToolStripMenuItem.Name = "ChangeTextColorToolStripMenuItem";
            this.ChangeTextColorToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.ChangeTextColorToolStripMenuItem.Text = "Изменить цвет всего текста";
            this.ChangeTextColorToolStripMenuItem.Click += new System.EventHandler(this.ChangeAllTextColorToolStripMenuItem_Click);
            // 
            // ChangeTextFontToolStripMenuItem
            // 
            this.ChangeTextFontToolStripMenuItem.Name = "ChangeTextFontToolStripMenuItem";
            this.ChangeTextFontToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.ChangeTextFontToolStripMenuItem.Text = "Изменить шрифт всего текста";
            this.ChangeTextFontToolStripMenuItem.Click += new System.EventHandler(this.ChangeAllTextFontToolStripMenuItem_Click);
            // 
            // EditingToolStripMenuItem
            // 
            this.EditingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem});
            this.EditingToolStripMenuItem.Name = "EditingToolStripMenuItem";
            this.EditingToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.EditingToolStripMenuItem.Text = "Правка";
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.CutToolStripMenuItem.Text = "Вырезать";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.CopyToolStripMenuItem.Text = "Копировать";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.PasteToolStripMenuItem.Text = "Вставить";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolMenuItem_Click);
            // 
            // EncodingsToolStripMenuItem1
            // 
            this.EncodingsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UTF8ToolStripMenuItem,
            this.UnicodeToolStripMenuItem,
            this.ASKIIToolStripMenuItem});
            this.EncodingsToolStripMenuItem1.Name = "EncodingsToolStripMenuItem1";
            this.EncodingsToolStripMenuItem1.Size = new System.Drawing.Size(102, 26);
            this.EncodingsToolStripMenuItem1.Text = "Кодировка";
            // 
            // UTF8ToolStripMenuItem
            // 
            this.UTF8ToolStripMenuItem.Name = "UTF8ToolStripMenuItem";
            this.UTF8ToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.UTF8ToolStripMenuItem.Text = "UTF - 8";
            this.UTF8ToolStripMenuItem.Click += new System.EventHandler(this.UTF8ToolStripMenuItem_Click);
            // 
            // UnicodeToolStripMenuItem
            // 
            this.UnicodeToolStripMenuItem.Name = "UnicodeToolStripMenuItem";
            this.UnicodeToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.UnicodeToolStripMenuItem.Text = "Unicode";
            this.UnicodeToolStripMenuItem.Click += new System.EventHandler(this.UnicodeToolStripMenuItem_Click);
            // 
            // ASKIIToolStripMenuItem
            // 
            this.ASKIIToolStripMenuItem.Name = "ASKIIToolStripMenuItem";
            this.ASKIIToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.ASKIIToolStripMenuItem.Text = "ASKII";
            this.ASKIIToolStripMenuItem.Click += new System.EventHandler(this.ASKIIToolStripMenuItem_Click);
            // 
            // InformationToolStripMenuItem
            // 
            this.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem";
            this.InformationToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.InformationToolStripMenuItem.Text = "Справка";
            this.InformationToolStripMenuItem.Click += new System.EventHandler(this.InformationToolStripMenuItem_Click);
            // 
            // NotebookStatusStrip
            // 
            this.NotebookStatusStrip.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotebookStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NotebookStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NotebookNumberOfCharacters,
            this.EncodingData});
            this.NotebookStatusStrip.Location = new System.Drawing.Point(0, 523);
            this.NotebookStatusStrip.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.NotebookStatusStrip.Name = "NotebookStatusStrip";
            this.NotebookStatusStrip.Size = new System.Drawing.Size(782, 30);
            this.NotebookStatusStrip.TabIndex = 2;
            // 
            // NotebookNumberOfCharacters
            // 
            this.NotebookNumberOfCharacters.BackColor = System.Drawing.SystemColors.MenuBar;
            this.NotebookNumberOfCharacters.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotebookNumberOfCharacters.Margin = new System.Windows.Forms.Padding(4, 4, 10, 2);
            this.NotebookNumberOfCharacters.Name = "NotebookNumberOfCharacters";
            this.NotebookNumberOfCharacters.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.NotebookNumberOfCharacters.Size = new System.Drawing.Size(152, 24);
            this.NotebookNumberOfCharacters.Text = "Число символов: 0";
            // 
            // EncodingData
            // 
            this.EncodingData.BackColor = System.Drawing.SystemColors.MenuBar;
            this.EncodingData.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncodingData.Margin = new System.Windows.Forms.Padding(10, 4, 0, 2);
            this.EncodingData.Name = "EncodingData";
            this.EncodingData.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.EncodingData.Size = new System.Drawing.Size(63, 24);
            this.EncodingData.Text = "UTF - 8";
            // 
            // NotebookContextMenuStrip
            // 
            this.NotebookContextMenuStrip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.NotebookContextMenuStrip.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotebookContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NotebookContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolContextMenuItem,
            this.CutToolContextMenuItem,
            this.PasteToolContextMenuItem,
            this.ChangeColorToolContextMenuItem,
            this.ChangeFontToolContextMenuItem});
            this.NotebookContextMenuStrip.Name = "NotebookContextMenuStrip";
            this.NotebookContextMenuStrip.Size = new System.Drawing.Size(295, 134);
            // 
            // CopyToolContextMenuItem
            // 
            this.CopyToolContextMenuItem.Name = "CopyToolContextMenuItem";
            this.CopyToolContextMenuItem.Size = new System.Drawing.Size(294, 26);
            this.CopyToolContextMenuItem.Text = "Копировать";
            this.CopyToolContextMenuItem.Click += new System.EventHandler(this.CopyToolMenuItem_Click);
            // 
            // CutToolContextMenuItem
            // 
            this.CutToolContextMenuItem.Name = "CutToolContextMenuItem";
            this.CutToolContextMenuItem.Size = new System.Drawing.Size(294, 26);
            this.CutToolContextMenuItem.Text = "Вырезать";
            this.CutToolContextMenuItem.Click += new System.EventHandler(this.CutToolMenuItem_Click);
            // 
            // PasteToolContextMenuItem
            // 
            this.PasteToolContextMenuItem.Name = "PasteToolContextMenuItem";
            this.PasteToolContextMenuItem.Size = new System.Drawing.Size(294, 26);
            this.PasteToolContextMenuItem.Text = "Вставить";
            this.PasteToolContextMenuItem.Click += new System.EventHandler(this.PasteToolMenuItem_Click);
            // 
            // ChangeColorToolContextMenuItem
            // 
            this.ChangeColorToolContextMenuItem.Name = "ChangeColorToolContextMenuItem";
            this.ChangeColorToolContextMenuItem.Size = new System.Drawing.Size(294, 26);
            this.ChangeColorToolContextMenuItem.Text = "Изменить цвет части текста";
            this.ChangeColorToolContextMenuItem.Click += new System.EventHandler(this.ChangeColorToolStripMenuItem_Click);
            // 
            // ChangeFontToolContextMenuItem
            // 
            this.ChangeFontToolContextMenuItem.Name = "ChangeFontToolContextMenuItem";
            this.ChangeFontToolContextMenuItem.Size = new System.Drawing.Size(294, 26);
            this.ChangeFontToolContextMenuItem.Text = "Изменить шрифт части текста";
            this.ChangeFontToolContextMenuItem.Click += new System.EventHandler(this.ChangeFontToolStripMenuItem_Click);
            // 
            // NotebookRichTextBox
            // 
            this.NotebookRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotebookRichTextBox.ContextMenuStrip = this.NotebookContextMenuStrip;
            this.NotebookRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotebookRichTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotebookRichTextBox.Location = new System.Drawing.Point(0, 32);
            this.NotebookRichTextBox.Name = "NotebookRichTextBox";
            this.NotebookRichTextBox.Size = new System.Drawing.Size(782, 491);
            this.NotebookRichTextBox.TabIndex = 4;
            this.NotebookRichTextBox.Text = "";
            this.NotebookRichTextBox.TextChanged += new System.EventHandler(this.NotebookRichTextBox_TextChanged);
            // 
            // NotebookColorDialog
            // 
            this.NotebookColorDialog.AnyColor = true;
            // 
            // NotebookFontDialog
            // 
            this.NotebookFontDialog.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // NotebookOpenFileDialog
            // 
            this.NotebookOpenFileDialog.Filter = "Текстовые файлы (*.rtf)|*.rtf";
            this.NotebookOpenFileDialog.Title = "Открыть файл";
            // 
            // NotebookSaveFileDialog
            // 
            this.NotebookSaveFileDialog.Filter = "Текстовые файлы (*.rtf)|*.rtf";
            this.NotebookSaveFileDialog.Title = "Сохранить файл";
            // 
            // NotebookPrintDialog
            // 
            this.NotebookPrintDialog.AllowCurrentPage = true;
            this.NotebookPrintDialog.AllowSelection = true;
            this.NotebookPrintDialog.AllowSomePages = true;
            this.NotebookPrintDialog.Document = this.NotebookPrintDocument;
            this.NotebookPrintDialog.ShowHelp = true;
            this.NotebookPrintDialog.UseEXDialog = true;
            // 
            // NotebookPrintDocument
            // 
            this.NotebookPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.NotebookPrintDocument_PrintPage);
            // 
            // MainNotebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.NotebookRichTextBox);
            this.Controls.Add(this.NotebookStatusStrip);
            this.Controls.Add(this.NotebookMenuStrip);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.NotebookMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainNotebookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Безымянный - Блокнот";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainNotebookForm_FormClosing);
            this.NotebookMenuStrip.ResumeLayout(false);
            this.NotebookMenuStrip.PerformLayout();
            this.NotebookStatusStrip.ResumeLayout(false);
            this.NotebookStatusStrip.PerformLayout();
            this.NotebookContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip NotebookMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeTextColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeTextFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InformationToolStripMenuItem;
        private System.Windows.Forms.StatusStrip NotebookStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel NotebookNumberOfCharacters;
        private System.Windows.Forms.ToolStripStatusLabel EncodingData;
        private System.Windows.Forms.ContextMenuStrip NotebookContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CopyToolContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutToolContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeColorToolContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeFontToolContextMenuItem;
        private System.Windows.Forms.RichTextBox NotebookRichTextBox;
        private System.Windows.Forms.ColorDialog NotebookColorDialog;
        private System.Windows.Forms.FontDialog NotebookFontDialog;
        private System.Windows.Forms.OpenFileDialog NotebookOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog NotebookSaveFileDialog;
        private System.Windows.Forms.PrintDialog NotebookPrintDialog;
        private System.Windows.Forms.ToolStripMenuItem EncodingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem UTF8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnicodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ASKIIToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument NotebookPrintDocument;
    }
}