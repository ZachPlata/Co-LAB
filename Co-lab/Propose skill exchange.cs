using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Co_LAB
{
    public partial class Propose_skill_exchange : UserControl
    {


        public Propose_skill_exchange()
        {

            InitializeComponent();

            TextBoxNotes.Multiline = true;

            TextBoxNotes.Size = new Size(424, 116);
            TextBoxNotes.MinimumSize = new Size(424, 116);
        }

    }
}
