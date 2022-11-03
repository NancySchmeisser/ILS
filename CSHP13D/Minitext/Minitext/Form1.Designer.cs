namespace Minitext
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.neuToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.öffnenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.speichernToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ausschneidenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.kopierenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.einfügenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.fettToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.kursivToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.unterstreichenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.linksbuendigToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zentriertToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rechtsbuendigToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernunterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rückgängigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wiederholenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ausschneidenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einfügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.alleauswählenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeichenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripButtonBackup = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // neuToolStripButton
            // 
            this.neuToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.neuToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("neuToolStripButton.Image")));
            this.neuToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.neuToolStripButton.Name = "neuToolStripButton";
            this.neuToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.neuToolStripButton.Text = "&Neu";
            this.neuToolStripButton.Click += new System.EventHandler(this.NeuToolStripButton_Click);
            // 
            // öffnenToolStripButton
            // 
            this.öffnenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.öffnenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("öffnenToolStripButton.Image")));
            this.öffnenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.öffnenToolStripButton.Name = "öffnenToolStripButton";
            this.öffnenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.öffnenToolStripButton.Text = "Ö&ffnen";
            this.öffnenToolStripButton.Click += new System.EventHandler(this.DateiLaden);
            // 
            // speichernToolStripButton
            // 
            this.speichernToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.speichernToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("speichernToolStripButton.Image")));
            this.speichernToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.speichernToolStripButton.Name = "speichernToolStripButton";
            this.speichernToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.speichernToolStripButton.Text = "&Speichern";
            this.speichernToolStripButton.Click += new System.EventHandler(this.DateiSpeichern);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // ausschneidenToolStripButton
            // 
            this.ausschneidenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ausschneidenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ausschneidenToolStripButton.Image")));
            this.ausschneidenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ausschneidenToolStripButton.Name = "ausschneidenToolStripButton";
            this.ausschneidenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ausschneidenToolStripButton.Text = "&Ausschneiden";
            this.ausschneidenToolStripButton.Click += new System.EventHandler(this.AusschneidenToolStripMenuItem_Click);
            // 
            // kopierenToolStripButton
            // 
            this.kopierenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kopierenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("kopierenToolStripButton.Image")));
            this.kopierenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kopierenToolStripButton.Name = "kopierenToolStripButton";
            this.kopierenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.kopierenToolStripButton.Text = "&Kopieren";
            this.kopierenToolStripButton.Click += new System.EventHandler(this.KopierenToolStripMenuItem_Click);
            // 
            // einfügenToolStripButton
            // 
            this.einfügenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.einfügenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("einfügenToolStripButton.Image")));
            this.einfügenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.einfügenToolStripButton.Name = "einfügenToolStripButton";
            this.einfügenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.einfügenToolStripButton.Text = "&Einfügen";
            this.einfügenToolStripButton.Click += new System.EventHandler(this.EinfügenToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripButton,
            this.öffnenToolStripButton,
            this.speichernToolStripButton,
            this.toolStripSeparator6,
            this.toolStripButtonBackup,
            this.ausschneidenToolStripButton,
            this.kopierenToolStripButton,
            this.einfügenToolStripButton,
            this.toolStripSeparator7,
            this.fettToolStripButton,
            this.kursivToolStripButton,
            this.unterstreichenToolStripButton,
            this.toolStripSeparator5,
            this.linksbuendigToolStripButton,
            this.zentriertToolStripButton,
            this.rechtsbuendigToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(331, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // fettToolStripButton
            // 
            this.fettToolStripButton.CheckOnClick = true;
            this.fettToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fettToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fettToolStripButton.Image")));
            this.fettToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fettToolStripButton.Name = "fettToolStripButton";
            this.fettToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.fettToolStripButton.Text = "Fett";
            this.fettToolStripButton.Click += new System.EventHandler(this.FettToolStripButton_Click);
            // 
            // kursivToolStripButton
            // 
            this.kursivToolStripButton.CheckOnClick = true;
            this.kursivToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kursivToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("kursivToolStripButton.Image")));
            this.kursivToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kursivToolStripButton.Name = "kursivToolStripButton";
            this.kursivToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.kursivToolStripButton.Text = "Kursiv";
            this.kursivToolStripButton.Click += new System.EventHandler(this.KursivToolStripButton_Click);
            // 
            // unterstreichenToolStripButton
            // 
            this.unterstreichenToolStripButton.CheckOnClick = true;
            this.unterstreichenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.unterstreichenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("unterstreichenToolStripButton.Image")));
            this.unterstreichenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.unterstreichenToolStripButton.Name = "unterstreichenToolStripButton";
            this.unterstreichenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.unterstreichenToolStripButton.Text = "Unterstreichen";
            this.unterstreichenToolStripButton.Click += new System.EventHandler(this.UnterstreichenToolStripButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // linksbuendigToolStripButton
            // 
            this.linksbuendigToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.linksbuendigToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("linksbuendigToolStripButton.Image")));
            this.linksbuendigToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.linksbuendigToolStripButton.Name = "linksbuendigToolStripButton";
            this.linksbuendigToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.linksbuendigToolStripButton.Text = "Linksbündig";
            this.linksbuendigToolStripButton.Click += new System.EventHandler(this.LinksbuendigToolStripButton_Click);
            // 
            // zentriertToolStripButton
            // 
            this.zentriertToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zentriertToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zentriertToolStripButton.Image")));
            this.zentriertToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zentriertToolStripButton.Name = "zentriertToolStripButton";
            this.zentriertToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.zentriertToolStripButton.Text = "Zentriert";
            this.zentriertToolStripButton.Click += new System.EventHandler(this.ZentriertToolStripButton_Click);
            // 
            // rechtsbuendigToolStripButton
            // 
            this.rechtsbuendigToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rechtsbuendigToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("rechtsbuendigToolStripButton.Image")));
            this.rechtsbuendigToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rechtsbuendigToolStripButton.Name = "rechtsbuendigToolStripButton";
            this.rechtsbuendigToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.rechtsbuendigToolStripButton.Text = "Rechtsbündig";
            this.rechtsbuendigToolStripButton.Click += new System.EventHandler(this.RechtsbuendigToolStripButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "RTF-Dateien|*.rtf";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.SystemColors.ControlText;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(331, 212);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(331, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.öffnenToolStripMenuItem,
            this.toolStripSeparator,
            this.speichernToolStripMenuItem,
            this.speichernunterToolStripMenuItem,
            this.toolStripSeparator1,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "&Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("neuToolStripMenuItem.Image")));
            this.neuToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.neuToolStripMenuItem.Text = "&Neu";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.NeuToolStripMenuItem_Click);
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öffnenToolStripMenuItem.Image")));
            this.öffnenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.öffnenToolStripMenuItem.Text = "Ö&ffnen";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.DateiLaden);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(163, 6);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("speichernToolStripMenuItem.Image")));
            this.speichernToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.speichernToolStripMenuItem.Text = "&Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.DateiSpeichern);
            // 
            // speichernunterToolStripMenuItem
            // 
            this.speichernunterToolStripMenuItem.Name = "speichernunterToolStripMenuItem";
            this.speichernunterToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.speichernunterToolStripMenuItem.Text = "Speichern &unter";
            this.speichernunterToolStripMenuItem.Click += new System.EventHandler(this.SpeichernunterToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.beendenToolStripMenuItem.Text = "&Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.BeendenToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rückgängigToolStripMenuItem,
            this.wiederholenToolStripMenuItem,
            this.toolStripSeparator3,
            this.ausschneidenToolStripMenuItem,
            this.kopierenToolStripMenuItem,
            this.einfügenToolStripMenuItem,
            this.toolStripSeparator4,
            this.alleauswählenToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "&Bearbeiten";
            // 
            // rückgängigToolStripMenuItem
            // 
            this.rückgängigToolStripMenuItem.Name = "rückgängigToolStripMenuItem";
            this.rückgängigToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.rückgängigToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.rückgängigToolStripMenuItem.Text = "&Rückgängig";
            this.rückgängigToolStripMenuItem.Click += new System.EventHandler(this.RückgängigToolStripMenuItem_Click);
            // 
            // wiederholenToolStripMenuItem
            // 
            this.wiederholenToolStripMenuItem.Name = "wiederholenToolStripMenuItem";
            this.wiederholenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.wiederholenToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.wiederholenToolStripMenuItem.Text = "Wiede&rholen";
            this.wiederholenToolStripMenuItem.Click += new System.EventHandler(this.WiederholenToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(186, 6);
            // 
            // ausschneidenToolStripMenuItem
            // 
            this.ausschneidenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ausschneidenToolStripMenuItem.Image")));
            this.ausschneidenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ausschneidenToolStripMenuItem.Name = "ausschneidenToolStripMenuItem";
            this.ausschneidenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ausschneidenToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ausschneidenToolStripMenuItem.Text = "&Ausschneiden";
            this.ausschneidenToolStripMenuItem.Click += new System.EventHandler(this.AusschneidenToolStripMenuItem_Click);
            // 
            // kopierenToolStripMenuItem
            // 
            this.kopierenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kopierenToolStripMenuItem.Image")));
            this.kopierenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kopierenToolStripMenuItem.Name = "kopierenToolStripMenuItem";
            this.kopierenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopierenToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.kopierenToolStripMenuItem.Text = "&Kopieren";
            this.kopierenToolStripMenuItem.Click += new System.EventHandler(this.KopierenToolStripMenuItem_Click);
            // 
            // einfügenToolStripMenuItem
            // 
            this.einfügenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("einfügenToolStripMenuItem.Image")));
            this.einfügenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.einfügenToolStripMenuItem.Name = "einfügenToolStripMenuItem";
            this.einfügenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.einfügenToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.einfügenToolStripMenuItem.Text = "&Einfügen";
            this.einfügenToolStripMenuItem.Click += new System.EventHandler(this.EinfügenToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(186, 6);
            // 
            // alleauswählenToolStripMenuItem
            // 
            this.alleauswählenToolStripMenuItem.Name = "alleauswählenToolStripMenuItem";
            this.alleauswählenToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.alleauswählenToolStripMenuItem.Text = "&Alle auswählen";
            this.alleauswählenToolStripMenuItem.Click += new System.EventHandler(this.AlleauswählenToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zeichenToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "&Format";
            // 
            // zeichenToolStripMenuItem
            // 
            this.zeichenToolStripMenuItem.Name = "zeichenToolStripMenuItem";
            this.zeichenToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.zeichenToolStripMenuItem.Text = "&Zeichen";
            this.zeichenToolStripMenuItem.Click += new System.EventHandler(this.ZeichenToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "RTF-Dateien|*.rtf";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // toolStripButtonBackup
            // 
            this.toolStripButtonBackup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBackup.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBackup.Image")));
            this.toolStripButtonBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBackup.Name = "toolStripButtonBackup";
            this.toolStripButtonBackup.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBackup.Text = "Backup laden";
            this.toolStripButtonBackup.Click += new System.EventHandler(this.toolStripButtonBackup_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 261);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Minitext";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton neuToolStripButton;
        private System.Windows.Forms.ToolStripButton öffnenToolStripButton;
        private System.Windows.Forms.ToolStripButton speichernToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton ausschneidenToolStripButton;
        private System.Windows.Forms.ToolStripButton kopierenToolStripButton;
        private System.Windows.Forms.ToolStripButton einfügenToolStripButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton fettToolStripButton;
        private System.Windows.Forms.ToolStripButton kursivToolStripButton;
        private System.Windows.Forms.ToolStripButton unterstreichenToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton linksbuendigToolStripButton;
        private System.Windows.Forms.ToolStripButton zentriertToolStripButton;
        private System.Windows.Forms.ToolStripButton rechtsbuendigToolStripButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernunterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rückgängigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wiederholenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ausschneidenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einfügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem alleauswählenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeichenToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBackup;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

