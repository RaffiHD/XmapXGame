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
        Graphics graphics;

        List<List<Tile>> map;

        int tilesX = 10;
        int tilesY = 10;
        int sizeMap = 25;

        public FormGame()
        {
            InitializeComponent(); // ÜBERALL GETTER SETTER BERICHTIGEN            // DRAW.cs nur für draw Logik und das tatsächliche draw hier in der FORMGame.cs
            graphics = panelMap.CreateGraphics();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void buttonGenerateMap_Click(object sender, EventArgs e)
        {
            buttonGenerateMap.Enabled = false;
            generateMap();
            buttonGenerateMap.Enabled = true;
        }

        private void buttonDrawMap_Click(object sender, EventArgs e)
        {
            buttonDrawMap.Enabled = false;
            drawMap(this);
            buttonDrawMap.Enabled = true;
        }
        public void drawImage(Point location, Image image)
        {
            graphics.DrawImage(image, location);

        }

        private void generateMap(int tilesX = 10, int tilesY = 10, int size = 25)
        {
            map = new Map().generateMap(tilesX, tilesY, size);

        }
        private void drawMap(FormGame form)
        {
            new Draw(form).drawMap(map);

        }

        private void buttonGenerateDrawMap_Click(object sender, EventArgs e)
        {
            buttonGenerateDrawMap.Enabled = false;

            tilesX = Convert.ToInt16(numericUpDownTilesX.Value);
            tilesY = Convert.ToInt16(numericUpDownTilesY.Value);
            sizeMap = Convert.ToInt16(numericUpDownSizeMap.Value);

            generateMap(tilesX, tilesY, sizeMap);
            drawMap(this);

            buttonGenerateDrawMap.Enabled = true;

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
        }
    }
}
