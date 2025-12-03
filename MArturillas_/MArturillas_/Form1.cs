using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MArturillas_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class MusicalInstrument
        {
            public string Color;
            public string Size;
            public string Type;
            public int StringNum;
            public string Material;
        }
        private void btnDisplay1_Click(object sender, EventArgs e)
        {
            MusicalInstrument musInstru1 = new MusicalInstrument();
            musInstru1.Color = "Brown";
            musInstru1.Size = "Large";
            musInstru1.Type = "Acoustic Guitar";
            musInstru1.StringNum = 6;
            musInstru1.Material = "Wood";
            lblColor1.Text = musInstru1.Color;
            lblSize1.Text = musInstru1.Size;
            lblType1.Text = musInstru1.Type;
            lblStringNum1.Text = musInstru1.StringNum.ToString();
            lblMaterial1.Text = musInstru1.Material;
        }

        private void btnDisplay2_Click(object sender, EventArgs e)
        {
            MusicalInstrument musInstru1 = new MusicalInstrument();
            musInstru1.Color = "Grey";
            musInstru1.Size = "Medium";
            musInstru1.Type = "Electric Guitar";
            musInstru1.StringNum = 6;
            musInstru1.Material = "Wood";
            lblColor1.Text = musInstru1.Color;
            lblSize1.Text = musInstru1.Size;
            lblType1.Text = musInstru1.Type;
            lblStringNum1.Text = musInstru1.StringNum.ToString();
            lblMaterial1.Text = musInstru1.Material;
        }
    }
}
