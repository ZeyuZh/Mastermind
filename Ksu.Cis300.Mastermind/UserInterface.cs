using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Ksu.Cis300.Mastermind
{
    public partial class uxUserInterface : Form
    {
        /// <summary>
        /// Constructor the user interface and two numerics' maximum value
        /// </summary>
        public uxUserInterface()
        {
            InitializeComponent();
            uxBlackNumeric.Maximum = 4;
            uxWhiteNumeric.Maximum = 4;
        }

        /// <summary>
        /// A constant giving the maximum number of plays in the game
        /// </summary>
        private const int _maxPlays = 10;

        /// <summary>
        /// representing the entire decision tree.
        /// </summary>
        private DecisionTree _strategy;

        /// <summary>
        /// giving the node in the above tree containing the current guess.
        /// </summary>
        private DecisionTree _guess;

        /// <summary>
        /// The current play number dispalyed on listbox.
        /// </summary>
        private int _play;

        /// <summary>
        /// This method will be called when the program can't break the code within the allowed number of guesses. 
        /// </summary>
        private void GiveUp()
        {
            uxGiveUp giveup =  new uxGiveUp();
            if(giveup.ShowDialog() == DialogResult.OK)
            {
                for(int i = 0; i < _play; i++)
                {
                    ListViewItem item = uxList.Items[i];
                    string code1 = item.SubItems[1].Text;
                    string code2 = giveup.Code;
                    if (Scorer.CodeIsValid(code2))
                    {
                        int black1 = Scorer.GetBlackHits(code1, code2);
                        int white1 = Scorer.GetTotalHits(code1, code2) - black1;
                        int black2 = Convert.ToInt32(item.SubItems[2].Text);
                        int white2 = Convert.ToInt32(item.SubItems[3].Text);
                        if(black1 != black2 || white1 != white2)
                        {
                            MessageBox.Show("The score for play " + (i+1) +" should be (" + black1 + "," + white1 + ")");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your code is invalid.");
                        return;
                    }
                }
                MessageBox.Show("The strategy failed.");
            }
        }

        /// <summary>
        /// The functionality of this event handler for "Open Strategy File" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpen_Click(object sender, EventArgs e)
        {
            try
            {
                DecisionTree tree = null;
                if (uxOpenDialog.ShowDialog() == DialogResult.OK)
                {
                    uxList.Items.Clear();
                    uxConfirm.Enabled = false;
                    using(StreamReader sr = new StreamReader(uxOpenDialog.FileName))
                    {
                        XmlReaderSettings settings = new XmlReaderSettings();
                        settings.IgnoreComments = true;
                        settings.IgnoreWhitespace = true;
                        XmlReader reader = XmlReader.Create(sr, settings);
                        reader.Read();
                        
                            if (reader.NodeType != XmlNodeType.Element)
                            {
                                throw new IOException("Invalid XML node type found");
                            }
                            else if (reader.Name != "node")
                            {
                                throw new IOException("An element has a name other than node");
                            }
                            else
                            {
                                tree = new DecisionTree(reader);
                            }
                        
                    }
                    MessageBox.Show("File successfully read.");
                    _strategy = tree;
                    uxNew.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// An event handler for the "New Game" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNew_Click(object sender, EventArgs e)
        {
            uxList.Items.Clear();
            _play = 0;
            ListViewItem item = uxList.Items.Add("1");
            _guess = _strategy;
            _play++;
            item.SubItems.Add(_strategy.Guess);
            uxConfirm.Enabled = true;
            uxOpen.Enabled = false;
            uxNew.Enabled = false;
        }

        /// <summary>
        /// An event handler for the "Confirm Hits" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxConfirm_Click(object sender, EventArgs e)
        {
            if (_play < _maxPlays)
            {
                _guess = _guess.GetChild(Convert.ToInt32(uxBlackNumeric.Value), Convert.ToInt32(uxWhiteNumeric.Value));
            }
            else
            {
                _guess = null;
            }
            int RealPlay = _play - 1;// the number of the real play from 0 to 9
            uxList.Items[RealPlay].SubItems.Add(uxBlackNumeric.Value.ToString());
            uxList.Items[RealPlay].SubItems.Add(uxWhiteNumeric.Value.ToString());
            decimal black = uxBlackNumeric.Value;
            
            if (black != 4 && _guess != null) {
                _play++;
                ListViewItem item = uxList.Items.Add((_play).ToString());
                item.SubItems.Add(_guess.Guess);
            }
            else if(black == 4)
            {
                uxList.Items[RealPlay].SubItems.Add(uxBlackNumeric.Value.ToString());
                uxList.Items[RealPlay].SubItems.Add(uxWhiteNumeric.Value.ToString());
                uxConfirm.Enabled = false;
                uxOpen.Enabled = true;
                uxNew.Enabled = true;
            }
            else
            {
                uxList.Items[RealPlay].SubItems.Add(uxBlackNumeric.Value.ToString());
                uxList.Items[RealPlay].SubItems.Add(uxWhiteNumeric.Value.ToString());
                uxConfirm.Enabled = false;
                uxOpen.Enabled = true;
                uxNew.Enabled = true;
                GiveUp();
            }
        }

        /// <summary>
        /// An event handler for the "Black Hits" NumericUpDown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxBlackNumeric_ValueChanged(object sender, EventArgs e)
        {
            uxWhiteNumeric.Maximum = 4 - uxBlackNumeric.Value;
        }
    }
}
