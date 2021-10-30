
namespace Projectwork_1
{
    partial class Writer
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Writer));
            this.tabs = new System.Windows.Forms.TabControl();
            this.menu = new System.Windows.Forms.TabPage();
            this.tableMenuBase = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableMenuPulsanti = new System.Windows.Forms.TableLayoutPanel();
            this.tableMenuPulsanti2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.btnCreaFile = new System.Windows.Forms.Button();
            this.mainpage = new System.Windows.Forms.TabPage();
            this.tabellaMenustrip = new System.Windows.Forms.TableLayoutPanel();
            this.menustripMain = new System.Windows.Forms.MenuStrip();
            this.msFile = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.msStile = new System.Windows.Forms.ToolStripMenuItem();
            this.styleFont = new System.Windows.Forms.ToolStripMenuItem();
            this.styleTema = new System.Windows.Forms.ToolStripMenuItem();
            this.msStrumenti = new System.Windows.Forms.ToolStripMenuItem();
            this.strmFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.strmCounterW = new System.Windows.Forms.ToolStripMenuItem();
            this.strmCountrC = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.richtbMain = new System.Windows.Forms.RichTextBox();
            this.pAROLADACERCAREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbSwitch = new System.Windows.Forms.ToolStripTextBox();
            this.pAROLADASOSTITUIREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cbThemes = new System.Windows.Forms.ToolStripComboBox();
            this.tabs.SuspendLayout();
            this.menu.SuspendLayout();
            this.tableMenuBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableMenuPulsanti.SuspendLayout();
            this.tableMenuPulsanti2.SuspendLayout();
            this.mainpage.SuspendLayout();
            this.tabellaMenustrip.SuspendLayout();
            this.menustripMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.menu);
            this.tabs.Controls.Add(this.mainpage);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(800, 450);
            this.tabs.TabIndex = 2;
            // 
            // menu
            // 
            this.menu.Controls.Add(this.tableMenuBase);
            this.menu.Location = new System.Drawing.Point(4, 22);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(3);
            this.menu.Size = new System.Drawing.Size(792, 424);
            this.menu.TabIndex = 0;
            this.menu.Text = "MENU";
            this.menu.UseVisualStyleBackColor = true;
            // 
            // tableMenuBase
            // 
            this.tableMenuBase.ColumnCount = 1;
            this.tableMenuBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMenuBase.Controls.Add(this.pictureBox2, 0, 0);
            this.tableMenuBase.Controls.Add(this.pictureBox1, 0, 2);
            this.tableMenuBase.Controls.Add(this.tableMenuPulsanti, 0, 1);
            this.tableMenuBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMenuBase.Location = new System.Drawing.Point(3, 3);
            this.tableMenuBase.Margin = new System.Windows.Forms.Padding(0);
            this.tableMenuBase.Name = "tableMenuBase";
            this.tableMenuBase.RowCount = 3;
            this.tableMenuBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableMenuBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableMenuBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableMenuBase.Size = new System.Drawing.Size(786, 418);
            this.tableMenuBase.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(780, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 274);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(780, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableMenuPulsanti
            // 
            this.tableMenuPulsanti.ColumnCount = 3;
            this.tableMenuPulsanti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableMenuPulsanti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableMenuPulsanti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableMenuPulsanti.Controls.Add(this.tableMenuPulsanti2, 1, 0);
            this.tableMenuPulsanti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMenuPulsanti.Location = new System.Drawing.Point(3, 149);
            this.tableMenuPulsanti.Name = "tableMenuPulsanti";
            this.tableMenuPulsanti.RowCount = 1;
            this.tableMenuPulsanti.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMenuPulsanti.Size = new System.Drawing.Size(780, 119);
            this.tableMenuPulsanti.TabIndex = 2;
            // 
            // tableMenuPulsanti2
            // 
            this.tableMenuPulsanti2.ColumnCount = 1;
            this.tableMenuPulsanti2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMenuPulsanti2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMenuPulsanti2.Controls.Add(this.btnChiudi, 0, 1);
            this.tableMenuPulsanti2.Controls.Add(this.btnCreaFile, 0, 0);
            this.tableMenuPulsanti2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMenuPulsanti2.Location = new System.Drawing.Point(263, 3);
            this.tableMenuPulsanti2.Name = "tableMenuPulsanti2";
            this.tableMenuPulsanti2.RowCount = 2;
            this.tableMenuPulsanti2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMenuPulsanti2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMenuPulsanti2.Size = new System.Drawing.Size(254, 113);
            this.tableMenuPulsanti2.TabIndex = 0;
            // 
            // btnChiudi
            // 
            this.btnChiudi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChiudi.Location = new System.Drawing.Point(3, 59);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(248, 51);
            this.btnChiudi.TabIndex = 1;
            this.btnChiudi.Text = "CHIUDI";
            this.btnChiudi.UseVisualStyleBackColor = true;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // btnCreaFile
            // 
            this.btnCreaFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreaFile.Location = new System.Drawing.Point(3, 3);
            this.btnCreaFile.Name = "btnCreaFile";
            this.btnCreaFile.Size = new System.Drawing.Size(248, 50);
            this.btnCreaFile.TabIndex = 0;
            this.btnCreaFile.Text = "NUOVO FOGLIO";
            this.btnCreaFile.UseVisualStyleBackColor = true;
            this.btnCreaFile.Click += new System.EventHandler(this.btnCreaFile_Click_1);
            // 
            // mainpage
            // 
            this.mainpage.Controls.Add(this.tabellaMenustrip);
            this.mainpage.Location = new System.Drawing.Point(4, 22);
            this.mainpage.Name = "mainpage";
            this.mainpage.Padding = new System.Windows.Forms.Padding(3);
            this.mainpage.Size = new System.Drawing.Size(792, 424);
            this.mainpage.TabIndex = 1;
            this.mainpage.Text = "MAINPAGE";
            this.mainpage.UseVisualStyleBackColor = true;
            // 
            // tabellaMenustrip
            // 
            this.tabellaMenustrip.ColumnCount = 1;
            this.tabellaMenustrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabellaMenustrip.Controls.Add(this.menustripMain, 0, 0);
            this.tabellaMenustrip.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tabellaMenustrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabellaMenustrip.Location = new System.Drawing.Point(3, 3);
            this.tabellaMenustrip.Name = "tabellaMenustrip";
            this.tabellaMenustrip.RowCount = 2;
            this.tabellaMenustrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tabellaMenustrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tabellaMenustrip.Size = new System.Drawing.Size(786, 418);
            this.tabellaMenustrip.TabIndex = 1;
            // 
            // menustripMain
            // 
            this.menustripMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menustripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFile,
            this.msStile,
            this.msStrumenti});
            this.menustripMain.Location = new System.Drawing.Point(0, 0);
            this.menustripMain.Name = "menustripMain";
            this.menustripMain.Size = new System.Drawing.Size(786, 25);
            this.menustripMain.TabIndex = 0;
            this.menustripMain.Text = "menuStrip1";
            // 
            // msFile
            // 
            this.msFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileSave,
            this.fileOpen,
            this.fileMenu});
            this.msFile.Name = "msFile";
            this.msFile.Size = new System.Drawing.Size(40, 21);
            this.msFile.Text = "FILE";
            // 
            // fileSave
            // 
            this.fileSave.Name = "fileSave";
            this.fileSave.Size = new System.Drawing.Size(180, 22);
            this.fileSave.Text = "SALVA";
            this.fileSave.Click += new System.EventHandler(this.fileSave_Click_1);
            // 
            // fileOpen
            // 
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.Size = new System.Drawing.Size(180, 22);
            this.fileOpen.Text = "APRI";
            this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click_1);
            // 
            // fileMenu
            // 
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(180, 22);
            this.fileMenu.Text = "MENU\' PRINCIPALE";
            this.fileMenu.Click += new System.EventHandler(this.fileMenu_Click_1);
            // 
            // msStile
            // 
            this.msStile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleFont,
            this.toolStripSeparator2,
            this.styleTema,
            this.cbThemes});
            this.msStile.Name = "msStile";
            this.msStile.Size = new System.Drawing.Size(46, 21);
            this.msStile.Text = "STILE";
            // 
            // styleFont
            // 
            this.styleFont.Name = "styleFont";
            this.styleFont.Size = new System.Drawing.Size(181, 22);
            this.styleFont.Text = "FONT";
            this.styleFont.Click += new System.EventHandler(this.styleFont_Click_1);
            // 
            // styleTema
            // 
            this.styleTema.Name = "styleTema";
            this.styleTema.Size = new System.Drawing.Size(181, 22);
            this.styleTema.Text = "TEMA";
            // 
            // msStrumenti
            // 
            this.msStrumenti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strmFinder,
            this.strmCounterW,
            this.strmCountrC});
            this.msStrumenti.Name = "msStrumenti";
            this.msStrumenti.Size = new System.Drawing.Size(81, 21);
            this.msStrumenti.Text = "STRUMENTI";
            // 
            // strmFinder
            // 
            this.strmFinder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pAROLADACERCAREToolStripMenuItem,
            this.tbFind,
            this.toolStripSeparator1,
            this.pAROLADASOSTITUIREToolStripMenuItem,
            this.tbSwitch});
            this.strmFinder.Name = "strmFinder";
            this.strmFinder.Size = new System.Drawing.Size(201, 22);
            this.strmFinder.Text = "CERCA E SOSTITUISCI";
            this.strmFinder.Click += new System.EventHandler(this.strmFinder_Click_1);
            // 
            // strmCounterW
            // 
            this.strmCounterW.Name = "strmCounterW";
            this.strmCounterW.Size = new System.Drawing.Size(201, 22);
            this.strmCounterW.Text = "CONTEGGIO PAROLE";
            this.strmCounterW.Click += new System.EventHandler(this.strmCounterW_Click);
            // 
            // strmCountrC
            // 
            this.strmCountrC.Name = "strmCountrC";
            this.strmCountrC.Size = new System.Drawing.Size(201, 22);
            this.strmCountrC.Text = "CONTEGGIO CARATTERI";
            this.strmCountrC.Click += new System.EventHandler(this.strmCountrC_Click_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.richtbMain, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(780, 387);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // richtbMain
            // 
            this.richtbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richtbMain.Location = new System.Drawing.Point(81, 22);
            this.richtbMain.Name = "richtbMain";
            this.richtbMain.Size = new System.Drawing.Size(618, 342);
            this.richtbMain.TabIndex = 0;
            this.richtbMain.Text = "";
            // 
            // pAROLADACERCAREToolStripMenuItem
            // 
            this.pAROLADACERCAREToolStripMenuItem.Name = "pAROLADACERCAREToolStripMenuItem";
            this.pAROLADACERCAREToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.pAROLADACERCAREToolStripMenuItem.Text = "PAROLA DA CERCARE";
            // 
            // tbFind
            // 
            this.tbFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // tbSwitch
            // 
            this.tbSwitch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSwitch.Name = "tbSwitch";
            this.tbSwitch.Size = new System.Drawing.Size(100, 23);
            this.tbSwitch.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // pAROLADASOSTITUIREToolStripMenuItem
            // 
            this.pAROLADASOSTITUIREToolStripMenuItem.Name = "pAROLADASOSTITUIREToolStripMenuItem";
            this.pAROLADASOSTITUIREToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.pAROLADASOSTITUIREToolStripMenuItem.Text = "PAROLA DA SOSTITUIRE";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // cbThemes
            // 
            this.cbThemes.Items.AddRange(new object[] {
            "Scegli il tema...",
            "Brown",
            "Blue",
            "Black",
            "Custom"});
            this.cbThemes.Name = "cbThemes";
            this.cbThemes.Size = new System.Drawing.Size(121, 23);
            this.cbThemes.Click += new System.EventHandler(this.cbThemes_Click);
            // 
            // Writer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabs);
            this.Name = "Writer";
            this.Text = "Writer";
            this.Load += new System.EventHandler(this.Writer_Load);
            this.tabs.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.tableMenuBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableMenuPulsanti.ResumeLayout(false);
            this.tableMenuPulsanti2.ResumeLayout(false);
            this.mainpage.ResumeLayout(false);
            this.tabellaMenustrip.ResumeLayout(false);
            this.tabellaMenustrip.PerformLayout();
            this.menustripMain.ResumeLayout(false);
            this.menustripMain.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage menu;
        private System.Windows.Forms.TableLayoutPanel tableMenuBase;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableMenuPulsanti;
        private System.Windows.Forms.TableLayoutPanel tableMenuPulsanti2;
        private System.Windows.Forms.Button btnChiudi;
        private System.Windows.Forms.Button btnCreaFile;
        private System.Windows.Forms.TabPage mainpage;
        private System.Windows.Forms.TableLayoutPanel tabellaMenustrip;
        private System.Windows.Forms.MenuStrip menustripMain;
        private System.Windows.Forms.ToolStripMenuItem msFile;
        private System.Windows.Forms.ToolStripMenuItem fileSave;
        private System.Windows.Forms.ToolStripMenuItem fileOpen;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem msStile;
        private System.Windows.Forms.ToolStripMenuItem styleFont;
        private System.Windows.Forms.ToolStripMenuItem styleTema;
        private System.Windows.Forms.ToolStripMenuItem msStrumenti;
        private System.Windows.Forms.ToolStripMenuItem strmFinder;
        private System.Windows.Forms.ToolStripMenuItem strmCounterW;
        private System.Windows.Forms.ToolStripMenuItem strmCountrC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RichTextBox richtbMain;
        private System.Windows.Forms.ToolStripMenuItem pAROLADACERCAREToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tbFind;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pAROLADASOSTITUIREToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tbSwitch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox cbThemes;
    }
}

