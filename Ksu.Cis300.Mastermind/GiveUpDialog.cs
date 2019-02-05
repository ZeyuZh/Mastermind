using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.Mastermind
{
    public partial class uxGiveUp : Form
    {
        /// <summary>
        /// the constructor for initilize the dialog.
        /// </summary>
        public uxGiveUp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// the property to get the code of user typed.
        /// </summary>
        public string Code
        {
            get
            {
                return uxCode.Text;
            }
        }
    }
}
