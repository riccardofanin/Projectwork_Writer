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

        Testo text = new Testo();





        private void Writer_Load(object sender, EventArgs e)
        {
            
            tabs.Appearance = TabAppearance.FlatButtons;
            tabs.ItemSize = new Size(0, 1);
            tabs.SizeMode = TabSizeMode.Fixed;
            
        }


        /* SEZIONE MENU' PRINCIPALE */
        
        private void btnCreaFile_Click_1(object sender, EventArgs e)
        {
            tabs.SelectedIndex = 1;
        }

        private void btnChiudi_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        /* SEZIONE STILE */

        private void fONTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                if(richtbMain.SelectionLength > 0)
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


        private void cONTEGGIOCARATTERIToolStripMenuItem_Click(object sender, EventArgs e)  // al click del bottone nel menu' strip comparira' una massage box con in numeri dei caratteri
        {
            text = new Testo(richtbMain.Text);
            text.CounterChar();
            MessageBox.Show($"Caratteri con spazi : {text.NChar} \nCaratteri senza spazi : {text.NCharNoSpace} ");
        }

        private void cONTEGGIOPAROLEToolStripMenuItem_Click(object sender, EventArgs e) // al click del bottone nel menu' strip comparira' una massage box con in numeri delle parole
        {
            text = new Testo(richtbMain.Text);
            MessageBox.Show($"Numero Parole : {text.NWords}");
        }
        private void cERCAESOSTITUISCIToolStripMenuItem_Click(object sender, EventArgs e) // al click del bottone nel menu' strip comparira' una massage box con il numero di parole corrispondenti trovate e fara' poi lo scambio
        {
            text = new Testo(richtbMain.Text);
            richtbMain.Text = text.SwitchWord(tbFind.Text, tbSwitch.Text);
        }

     


        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboTema_Click(object sender, EventArgs e)
        {

        }

        private void aPRIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,
            };


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    richtbMain.Text = text;
                }
                catch (IOException) { }

            }
        }
    }
}
