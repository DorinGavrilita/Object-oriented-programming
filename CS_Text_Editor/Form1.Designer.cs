namespace CS_Text_Editor {
   partial class Form1 {
      /// <summary>
      /// Обязательная переменная конструктора.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Освободить все используемые ресурсы.
      /// </summary>
      /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
      protected override void Dispose(bool disposing) {
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
      private void InitializeComponent() {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
         this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.сохранитькакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.отменадействияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.отменадействияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
         this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.вставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
         this.выделитьвсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.фонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
         this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.richTextBox1 = new System.Windows.Forms.RichTextBox();
         this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
         this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
         this.fontDialog1 = new System.Windows.Forms.FontDialog();
         this.colorDialog1 = new System.Windows.Forms.ColorDialog();
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.вырезатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.копироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.выделитьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
         this.шрифтToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.фонToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.создатьToolStripButton = new System.Windows.Forms.ToolStripButton();
         this.открытьToolStripButton = new System.Windows.Forms.ToolStripButton();
         this.сохранитьToolStripButton = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.вырезатьToolStripButton = new System.Windows.Forms.ToolStripButton();
         this.копироватьToolStripButton = new System.Windows.Forms.ToolStripButton();
         this.вставкаToolStripButton = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
         this.справкаToolStripButton = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
         this.fineBtn = new System.Windows.Forms.ToolStripLabel();
         this.findText = new System.Windows.Forms.ToolStripTextBox();
         this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
         this.replaceBtn = new System.Windows.Forms.ToolStripLabel();
         this.replaceText = new System.Windows.Forms.ToolStripTextBox();
         this.menuStrip1.SuspendLayout();
         this.contextMenuStrip1.SuspendLayout();
         this.toolStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.форматToolStripMenuItem,
            this.справкаToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(686, 24);
         this.menuStrip1.TabIndex = 1;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // файлToolStripMenuItem
         // 
         this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.toolStripSeparator,
            this.сохранитьToolStripMenuItem,
            this.сохранитькакToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
         this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
         this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
         this.файлToolStripMenuItem.Text = "&Файл";
         // 
         // создатьToolStripMenuItem
         // 
         this.создатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripMenuItem.Image")));
         this.создатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
         this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
         this.создатьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
         this.создатьToolStripMenuItem.Text = "&Создать";
         this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
         // 
         // открытьToolStripMenuItem
         // 
         this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
         this.открытьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
         this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
         this.открытьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
         this.открытьToolStripMenuItem.Text = "&Открыть";
         this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
         // 
         // toolStripSeparator
         // 
         this.toolStripSeparator.Name = "toolStripSeparator";
         this.toolStripSeparator.Size = new System.Drawing.Size(169, 6);
         // 
         // сохранитьToolStripMenuItem
         // 
         this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
         this.сохранитьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
         this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
         this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
         this.сохранитьToolStripMenuItem.Text = "&Сохранить";
         this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
         // 
         // сохранитькакToolStripMenuItem
         // 
         this.сохранитькакToolStripMenuItem.Name = "сохранитькакToolStripMenuItem";
         this.сохранитькакToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
         this.сохранитькакToolStripMenuItem.Text = "Сохранить &как";
         this.сохранитькакToolStripMenuItem.Click += new System.EventHandler(this.сохранитькакToolStripMenuItem_Click);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
         // 
         // выходToolStripMenuItem
         // 
         this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
         this.выходToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
         this.выходToolStripMenuItem.Text = "Вы&ход";
         this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
         // 
         // правкаToolStripMenuItem
         // 
         this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменадействияToolStripMenuItem,
            this.отменадействияToolStripMenuItem1,
            this.toolStripSeparator3,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставкаToolStripMenuItem,
            this.toolStripSeparator4,
            this.выделитьвсеToolStripMenuItem});
         this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
         this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
         this.правкаToolStripMenuItem.Text = "&Правка";
         // 
         // отменадействияToolStripMenuItem
         // 
         this.отменадействияToolStripMenuItem.Name = "отменадействияToolStripMenuItem";
         this.отменадействияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
         this.отменадействияToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
         this.отменадействияToolStripMenuItem.Text = "&Отмена действия";
         this.отменадействияToolStripMenuItem.Click += new System.EventHandler(this.отменадействияToolStripMenuItem_Click);
         // 
         // отменадействияToolStripMenuItem1
         // 
         this.отменадействияToolStripMenuItem1.Name = "отменадействияToolStripMenuItem1";
         this.отменадействияToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
         this.отменадействияToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
         this.отменадействияToolStripMenuItem1.Text = "&Вернуть действия";
         this.отменадействияToolStripMenuItem1.Click += new System.EventHandler(this.вернутьдействияToolStripMenuItem1_Click);
         // 
         // toolStripSeparator3
         // 
         this.toolStripSeparator3.Name = "toolStripSeparator3";
         this.toolStripSeparator3.Size = new System.Drawing.Size(208, 6);
         // 
         // вырезатьToolStripMenuItem
         // 
         this.вырезатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вырезатьToolStripMenuItem.Image")));
         this.вырезатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
         this.вырезатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
         this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
         this.вырезатьToolStripMenuItem.Text = "Вырезат&ь";
         this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
         // 
         // копироватьToolStripMenuItem
         // 
         this.копироватьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("копироватьToolStripMenuItem.Image")));
         this.копироватьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
         this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
         this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
         this.копироватьToolStripMenuItem.Text = "&Копировать";
         this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
         // 
         // вставкаToolStripMenuItem
         // 
         this.вставкаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вставкаToolStripMenuItem.Image")));
         this.вставкаToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.вставкаToolStripMenuItem.Name = "вставкаToolStripMenuItem";
         this.вставкаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
         this.вставкаToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
         this.вставкаToolStripMenuItem.Text = "Вст&авка";
         this.вставкаToolStripMenuItem.Click += new System.EventHandler(this.вставкаToolStripMenuItem_Click);
         // 
         // toolStripSeparator4
         // 
         this.toolStripSeparator4.Name = "toolStripSeparator4";
         this.toolStripSeparator4.Size = new System.Drawing.Size(208, 6);
         // 
         // выделитьвсеToolStripMenuItem
         // 
         this.выделитьвсеToolStripMenuItem.Name = "выделитьвсеToolStripMenuItem";
         this.выделитьвсеToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
         this.выделитьвсеToolStripMenuItem.Text = "Выделить &все";
         this.выделитьвсеToolStripMenuItem.Click += new System.EventHandler(this.выделитьвсеToolStripMenuItem_Click);
         // 
         // форматToolStripMenuItem
         // 
         this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шрифтToolStripMenuItem,
            this.фонToolStripMenuItem,
            this.цветToolStripMenuItem});
         this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
         this.форматToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
         this.форматToolStripMenuItem.Text = "&Формат";
         // 
         // шрифтToolStripMenuItem
         // 
         this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
         this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.шрифтToolStripMenuItem.Text = "Шрифт...";
         this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
         // 
         // фонToolStripMenuItem
         // 
         this.фонToolStripMenuItem.Name = "фонToolStripMenuItem";
         this.фонToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.фонToolStripMenuItem.Text = "Фон...";
         this.фонToolStripMenuItem.Click += new System.EventHandler(this.фонToolStripMenuItem_Click);
         // 
         // цветToolStripMenuItem
         // 
         this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
         this.цветToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.цветToolStripMenuItem.Text = "Цвет...";
         this.цветToolStripMenuItem.Click += new System.EventHandler(this.цветToolStripMenuItem_Click);
         // 
         // справкаToolStripMenuItem
         // 
         this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.опрограммеToolStripMenuItem});
         this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
         this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
         this.справкаToolStripMenuItem.Text = "Спра&вка";
         // 
         // toolStripSeparator5
         // 
         this.toolStripSeparator5.Name = "toolStripSeparator5";
         this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
         // 
         // опрограммеToolStripMenuItem
         // 
         this.опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
         this.опрограммеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
         this.опрограммеToolStripMenuItem.Text = "&О программе...";
         this.опрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОпрограммеToolStripMenuItem_Click);
         // 
         // richTextBox1
         // 
         this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
         this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.richTextBox1.EnableAutoDragDrop = true;
         this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.richTextBox1.HideSelection = false;
         this.richTextBox1.Location = new System.Drawing.Point(0, 51);
         this.richTextBox1.Name = "richTextBox1";
         this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
         this.richTextBox1.ShowSelectionMargin = true;
         this.richTextBox1.Size = new System.Drawing.Size(686, 376);
         this.richTextBox1.TabIndex = 2;
         this.richTextBox1.Text = "";
         this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseUp);
         // 
         // openFileDialog1
         // 
         this.openFileDialog1.FileName = "openFileDialog1";
         // 
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вырезатьToolStripMenuItem1,
            this.копироватьToolStripMenuItem1,
            this.вставитьToolStripMenuItem,
            this.выделитьВсёToolStripMenuItem,
            this.toolStripSeparator6,
            this.шрифтToolStripMenuItem1,
            this.фонToolStripMenuItem1});
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.Size = new System.Drawing.Size(167, 142);
         this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
         // 
         // вырезатьToolStripMenuItem1
         // 
         this.вырезатьToolStripMenuItem1.Name = "вырезатьToolStripMenuItem1";
         this.вырезатьToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
         this.вырезатьToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
         this.вырезатьToolStripMenuItem1.Text = "Вырезать";
         this.вырезатьToolStripMenuItem1.Click += new System.EventHandler(this.вырезатьToolStripMenuItem1_Click);
         // 
         // копироватьToolStripMenuItem1
         // 
         this.копироватьToolStripMenuItem1.Name = "копироватьToolStripMenuItem1";
         this.копироватьToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
         this.копироватьToolStripMenuItem1.Text = "Копировать";
         this.копироватьToolStripMenuItem1.Click += new System.EventHandler(this.копироватьToolStripMenuItem1_Click);
         // 
         // вставитьToolStripMenuItem
         // 
         this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
         this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
         this.вставитьToolStripMenuItem.Text = "Вставить";
         this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
         // 
         // выделитьВсёToolStripMenuItem
         // 
         this.выделитьВсёToolStripMenuItem.Name = "выделитьВсёToolStripMenuItem";
         this.выделитьВсёToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
         this.выделитьВсёToolStripMenuItem.Text = "Выделить всё";
         this.выделитьВсёToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсёToolStripMenuItem_Click);
         // 
         // toolStripSeparator6
         // 
         this.toolStripSeparator6.Name = "toolStripSeparator6";
         this.toolStripSeparator6.Size = new System.Drawing.Size(163, 6);
         // 
         // шрифтToolStripMenuItem1
         // 
         this.шрифтToolStripMenuItem1.Name = "шрифтToolStripMenuItem1";
         this.шрифтToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
         this.шрифтToolStripMenuItem1.Text = "Шрифт...";
         this.шрифтToolStripMenuItem1.Click += new System.EventHandler(this.шрифтToolStripMenuItem1_Click);
         // 
         // фонToolStripMenuItem1
         // 
         this.фонToolStripMenuItem1.Name = "фонToolStripMenuItem1";
         this.фонToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
         this.фонToolStripMenuItem1.Text = "Фон...";
         this.фонToolStripMenuItem1.Click += new System.EventHandler(this.фонToolStripMenuItem1_Click);
         // 
         // directorySearcher1
         // 
         this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
         this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
         this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
         // 
         // toolStrip1
         // 
         this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
         this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
         this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripButton,
            this.открытьToolStripButton,
            this.сохранитьToolStripButton,
            this.toolStripSeparator2,
            this.вырезатьToolStripButton,
            this.копироватьToolStripButton,
            this.вставкаToolStripButton,
            this.toolStripSeparator7,
            this.справкаToolStripButton,
            this.toolStripSeparator8,
            this.fineBtn,
            this.findText,
            this.toolStripSeparator9,
            this.replaceBtn,
            this.replaceText});
         this.toolStrip1.Location = new System.Drawing.Point(0, 24);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(686, 27);
         this.toolStrip1.TabIndex = 3;
         this.toolStrip1.TabStop = true;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // создатьToolStripButton
         // 
         this.создатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.создатьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripButton.Image")));
         this.создатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.создатьToolStripButton.Name = "создатьToolStripButton";
         this.создатьToolStripButton.Size = new System.Drawing.Size(24, 24);
         this.создатьToolStripButton.Text = "&Создать";
         this.создатьToolStripButton.Click += new System.EventHandler(this.создатьToolStripButton_Click);
         // 
         // открытьToolStripButton
         // 
         this.открытьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.открытьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripButton.Image")));
         this.открытьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.открытьToolStripButton.Name = "открытьToolStripButton";
         this.открытьToolStripButton.Size = new System.Drawing.Size(24, 24);
         this.открытьToolStripButton.Text = "&Открыть";
         // 
         // сохранитьToolStripButton
         // 
         this.сохранитьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.сохранитьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripButton.Image")));
         this.сохранитьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.сохранитьToolStripButton.Name = "сохранитьToolStripButton";
         this.сохранитьToolStripButton.Size = new System.Drawing.Size(24, 24);
         this.сохранитьToolStripButton.Text = "&Сохранить";
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
         // 
         // вырезатьToolStripButton
         // 
         this.вырезатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.вырезатьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("вырезатьToolStripButton.Image")));
         this.вырезатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.вырезатьToolStripButton.Name = "вырезатьToolStripButton";
         this.вырезатьToolStripButton.Size = new System.Drawing.Size(24, 24);
         this.вырезатьToolStripButton.Text = "В&ырезать";
         // 
         // копироватьToolStripButton
         // 
         this.копироватьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.копироватьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("копироватьToolStripButton.Image")));
         this.копироватьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.копироватьToolStripButton.Name = "копироватьToolStripButton";
         this.копироватьToolStripButton.Size = new System.Drawing.Size(24, 24);
         this.копироватьToolStripButton.Text = "&Копировать";
         // 
         // вставкаToolStripButton
         // 
         this.вставкаToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.вставкаToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("вставкаToolStripButton.Image")));
         this.вставкаToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.вставкаToolStripButton.Name = "вставкаToolStripButton";
         this.вставкаToolStripButton.Size = new System.Drawing.Size(24, 24);
         this.вставкаToolStripButton.Text = "Вст&авка";
         // 
         // toolStripSeparator7
         // 
         this.toolStripSeparator7.Name = "toolStripSeparator7";
         this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
         // 
         // справкаToolStripButton
         // 
         this.справкаToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.справкаToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("справкаToolStripButton.Image")));
         this.справкаToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.справкаToolStripButton.Name = "справкаToolStripButton";
         this.справкаToolStripButton.Size = new System.Drawing.Size(24, 24);
         this.справкаToolStripButton.Text = "Спр&авка";
         // 
         // toolStripSeparator8
         // 
         this.toolStripSeparator8.Name = "toolStripSeparator8";
         this.toolStripSeparator8.Size = new System.Drawing.Size(6, 27);
         // 
         // fineBtn
         // 
         this.fineBtn.BackColor = System.Drawing.SystemColors.Control;
         this.fineBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.fineBtn.Image = global::CS_Text_Editor.Properties.Resources.Zerode_Plump_;
         this.fineBtn.Name = "fineBtn";
         this.fineBtn.Size = new System.Drawing.Size(77, 24);
         this.fineBtn.Text = "Найти:";
         // 
         // findText
         // 
         this.findText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
         this.findText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
         this.findText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.findText.Name = "findText";
         this.findText.Size = new System.Drawing.Size(100, 27);
         this.findText.TextChanged += new System.EventHandler(this.findText_TextChanged);
         // 
         // toolStripSeparator9
         // 
         this.toolStripSeparator9.Name = "toolStripSeparator9";
         this.toolStripSeparator9.Size = new System.Drawing.Size(6, 27);
         // 
         // replaceBtn
         // 
         this.replaceBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.replaceBtn.Image = global::CS_Text_Editor.Properties.Resources.download;
         this.replaceBtn.Name = "replaceBtn";
         this.replaceBtn.Size = new System.Drawing.Size(123, 24);
         this.replaceBtn.Text = "Заменить на:";
         this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
         // 
         // replaceText
         // 
         this.replaceText.BackColor = System.Drawing.SystemColors.Window;
         this.replaceText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.replaceText.Name = "replaceText";
         this.replaceText.Size = new System.Drawing.Size(100, 27);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.GrayText;
         this.ClientSize = new System.Drawing.Size(686, 427);
         this.Controls.Add(this.richTextBox1);
         this.Controls.Add(this.toolStrip1);
         this.Controls.Add(this.menuStrip1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MainMenuStrip = this.menuStrip1;
         this.MinimumSize = new System.Drawing.Size(580, 250);
         this.Name = "Form1";
         this.Text = "NotePad in C#";
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.contextMenuStrip1.ResumeLayout(false);
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem выделитьвсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фонToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсёToolStripMenuItem;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem фонToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитькакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton создатьToolStripButton;
        private System.Windows.Forms.ToolStripButton открытьToolStripButton;
        private System.Windows.Forms.ToolStripButton сохранитьToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton вырезатьToolStripButton;
        private System.Windows.Forms.ToolStripButton копироватьToolStripButton;
        private System.Windows.Forms.ToolStripButton вставкаToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton справкаToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripLabel fineBtn;
        private System.Windows.Forms.ToolStripTextBox findText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripLabel replaceBtn;
        private System.Windows.Forms.ToolStripTextBox replaceText;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
    }
}

