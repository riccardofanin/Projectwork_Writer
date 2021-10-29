using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Projectwork_1
{

    public partial class Writer : Form
    {
        public Writer()
        {
            InitializeComponent();
        }


        class Testo
        {
            // field per il testo
            private string fullText;    // field contentente il testo in unica string
            private string[] arrText;   // field contente un array con il testo splittato in parole

            private int nChar = 0;
            private int nCharNoSpace = 0;

            private int nWords = 0;

            public Testo(string richtb = "")
            {
                fullText = richtb;
                arrText = fullText.Split(' ');
                if (fullText == "")
                {
                    nWords = 0;
                }
                else
                {
                    nWords = arrText.Length;
                }

            }

            public int NCharNoSpace { get => nCharNoSpace; }
            public int NChar { get => nChar; }
            public int NWords { get => nWords; }


            public void CounterChar()
            {
                for (int i = 0; i < fullText.Length; i++)
                {
                    nChar++;    // conta caratteri con spazi
                }

                for (int i = 0; i < arrText.Length; i++)
                {
                    nCharNoSpace += arrText[i].Length;  // conta caratteri senza spazi
                }
            }

            private int nWordsFound = 0;



            public void FindWords(string wordToFind)    // trova parole
            {
                for (int i = 0; i < arrText.Length; i++)
                {
                    if (arrText[i] == wordToFind)
                    {
                        nWordsFound++;
                    }
                }
                MessageBox.Show($"Sono state trovate {nWordsFound} parola/e.");
            }

            public string SwitchWord(string wordToFind, string wordToSwitch)    // scambia parole
            {
                FindWords(wordToFind);
                for (int c = 0; c < arrText.Length; c++)
                {
                    if (arrText[c] == wordToFind)
                    {
                        arrText[c] = wordToSwitch;
                    }
                }
                fullText = NewText();
                return fullText;
            }

            public string NewText() // crea il nuovo testo con prole sostituitr
            {
                string newText = "";
                for (int i = 0; i < arrText.Length; i++)
                {
                    newText += arrText[i] + " ";
                }
                fullText = newText;
                return newText;
            }
        }
        

        public class Themes : ProfessionalColorTable
        {
            private string[] _colors;
            public Themes(string[] pallette)
            {
                _colors = pallette;
            }

            public override Color MenuItemSelected
            {
                get { return ColorTranslator.FromHtml(_colors[0]); }
            }

            public override Color MenuItemBorder
            {
                get { return ColorTranslator.FromHtml(_colors[0]); }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get { return ColorTranslator.FromHtml(_colors[0]); }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get { return ColorTranslator.FromHtml(_colors[0]); }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get { return ColorTranslator.FromHtml(_colors[0]); }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get { return ColorTranslator.FromHtml(_colors[0]); }
            }

            public override Color MenuBorder
            {
                get { return ColorTranslator.FromHtml(_colors[0]); }
            }

            public override Color ToolStripBorder
            {
                get { return ColorTranslator.FromHtml(_colors[0]); }
            }


            public override Color ToolStripGradientBegin
            {
                get { return ColorTranslator.FromHtml(_colors[0]); }
            }


            public override Color ToolStripGradientEnd
            {
                get { return ColorTranslator.FromHtml(_colors[0]); }
            }
        }

        Testo text = new Testo();

        public void themeSelection(string theme)
        {
            string[] colors = new string[0];
            string[] brown = { "#110a04", "#e5be9e", "#cbc0ad", "#86a397", "#ffffff" };
            string[] blue = { "#012a4a", "#2a6f97", "#61a5c2", "#89c2d9", "#a9d6e5" };
            string[] black = { "#343a40", "#adb5bd", "#dee2e6", "#e9ecef", "#f8f9fa" };

            int n1 = 0;
            int n2 = 0;

            switch (theme)
            {
                case "brown":
                    colors = brown;
                    n1 = 1;
                    n2 = 2;
                    break;
                case "blue":
                    colors = blue;
                    n1 = 3;
                    n2 = 4;
                    break;
                case "black":
                    colors = black;
                    n1 = 5;
                    n2 = 6;
                    break;
            }

            menustripMain.Renderer = new ToolStripProfessionalRenderer(new Themes(colors));

            menu.BackColor = ColorTranslator.FromHtml(colors[0]);

            btnCreaFile.FlatStyle = FlatStyle.Flat;
            btnCreaFile.ForeColor = ColorTranslator.FromHtml(colors[0]);
            btnCreaFile.BackColor = ColorTranslator.FromHtml(colors[2]);

            btnChiudi.FlatStyle = FlatStyle.Flat;
            btnChiudi.ForeColor = ColorTranslator.FromHtml(colors[0]);
            btnChiudi.BackColor = ColorTranslator.FromHtml(colors[2]);

            pictureBox2.ImageLocation = @"..\..\Tema/" + n1 + ".png";
            pictureBox1.ImageLocation = @"..\..\Tema/" + n2 + ".png";


            /* Style Secondo Tab */

            mainpage.BackColor = ColorTranslator.FromHtml(colors[0]);

            menustripMain.BackColor = ColorTranslator.FromHtml(colors[1]);
            msFile.BackColor = ColorTranslator.FromHtml(colors[1]);
            msStile.BackColor = ColorTranslator.FromHtml(colors[1]);
            msStrumenti.BackColor = ColorTranslator.FromHtml(colors[1]);

            fileSave.BackColor = ColorTranslator.FromHtml(colors[2]);
            fileMenu.BackColor = ColorTranslator.FromHtml(colors[2]);
            fileOpen.BackColor = ColorTranslator.FromHtml(colors[2]);

            styleFont.BackColor = ColorTranslator.FromHtml(colors[2]);
            styleTema.BackColor = ColorTranslator.FromHtml(colors[2]);

            strmFinder.BackColor = ColorTranslator.FromHtml(colors[2]);
            strmCounterW.BackColor = ColorTranslator.FromHtml(colors[2]);
            strmCountrC.BackColor = ColorTranslator.FromHtml(colors[2]);

        }

        private void Writer_Load(object sender, EventArgs e)
        {


            tabs.Appearance = TabAppearance.FlatButtons;
            tabs.ItemSize = new Size(0, 1);
            tabs.SizeMode = TabSizeMode.Fixed;



            themeSelection("black");
        }


        /* SEZIONE MENU' PRINCIPALE */

        private void btnCreaFile_Click_1(object sender, EventArgs e)
        {
            tabs.SelectedIndex = 1;
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* SEZIONE STILE */

        private void styleFont_Click_1(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                if (richtbMain.SelectionLength > 0)
                {
                    richtbMain.SelectionFont = fontDialog.Font;
                }
                else
                {
                    richtbMain.Font = fontDialog.Font;
                }
            }
        }


        /*
        private void comboTemaMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboTemaMenu.SelectedIndex)
            {
                case 1:
                    tableMenu1.BackColor = ColorTranslator.FromHtml("#86a397");
                    
                    110a04
                    e5be9e
                    cbc0ad
                    86a397
                    ffffff
                     
                    break;
                case 2:
                    break;
                case 3:
                    break;

            }
        }
        */

        /* SEZIONE STRUMENTI */

        private void strmFinder_Click_1(object sender, EventArgs e)    // al click del bottone nel menu' strip comparira' una massage box con il numero di parole corrispondenti trovate e fara' poi lo scambio
        {
            text = new Testo(richtbMain.Text);
            richtbMain.Text = text.SwitchWord(tbFind.Text, tbSwitch.Text); 
        }

        private void strmCounterW_Click(object sender, EventArgs e) // al click del bottone nel menu' strip comparira' una massage box con in numeri delle parole
        {
            text = new Testo(richtbMain.Text);
            MessageBox.Show($"Numero Parole : {text.NWords}");
        }

        private void strmCountrC_Click_1(object sender, EventArgs e)    // al click del bottone nel menu' strip comparira' una massage box con in numeri dei caratteri
        {
            text = new Testo(richtbMain.Text);
            text.CounterChar();
            MessageBox.Show($"Caratteri con spazi : {text.NChar} \nCaratteri senza spazi : {text.NCharNoSpace} ");
        }


        /* SEZIONE FILE */

        private void fileSave_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Title = "Salva file di testo";
            saveFile.Filter = "TXT files|*.txt";
            saveFile.InitialDirectory = @"C:\";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFile.FileName, richtbMain.Text);
            }
        }

        private void fileOpen_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Title = "Apri file di testo";
            openFile.Filter = "TXT files|*.txt";
            openFile.InitialDirectory = @"C:\";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                richtbMain.Text = File.ReadAllText(openFile.FileName);
            }
        }

        private void fileMenu_Click_1(object sender, EventArgs e)
        {
            tabs.SelectedIndex = 0;
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void cbThemes_Click(object sender, EventArgs e)
        {

        }

        private void cbThemes_SelectedIndexChanged(object sender,
        System.EventArgs e)
        {
            switch (cbThemes.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    themeSelection("brown");
                    break;
                case 2:
                    themeSelection("blue");
                    break;
                case 3:
                    themeSelection("black");
                    break;

            }
        }
    }
}
