using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmapXGame
{
    public partial class FormGame : Form
    {
        Draw draw;

        public FormGame()
        {
            InitializeComponent(); // ÜBERALL GETTER SETTER BERICHTIGEN
            draw = new Draw();            
            draw.Graphics = panelMap.CreateGraphics();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void buttonGenerateMap_Click(object sender, EventArgs e)
        {

            new Map().generateMap();

        }

        private void buttonDrawMap_Click(object sender, EventArgs e)
        {

            new Draw().drawMap();

        }
    }
}
