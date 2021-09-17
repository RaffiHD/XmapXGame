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
        FormGame formGame;
        Map map;
        Object player;

        public FormGame()
        {
            InitializeComponent(); // ÜBERALL GETTER SETTER BERICHTIGEN            // DRAW.cs nur für draw Logik und das tatsächliche draw hier in der FORMGame.cs
            graphics = panelMap.CreateGraphics();
            formGame = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void buttonGenerateMap_Click(object sender, EventArgs e)
        {
            buttonMapGenerate.Enabled = false;

            generateMap(Convert.ToInt16(numericUpDownMapX.Value), Convert.ToInt16(numericUpDownMapY.Value));

            buttonMapGenerate.Enabled = true;

        }

        private void buttonDrawMap_Click(object sender, EventArgs e)
        {
            buttonMapDraw.Enabled = false;
            drawMap(formGame);
            buttonMapDraw.Enabled = true;
        }
        public void drawImage(Point location, Image image)
        {
            graphics.DrawImage(image, location);
            richTextBoxDebug.Text += location + Environment.NewLine;

        }

        private void generateMap(int tilesX, int tilesY, int tileSize = 50)
        {

            buttonMapGenerateDraw.Enabled = false;

            map = new Map().generateMap(tilesX, tilesY, tileSize);

            buttonMapGenerateDraw.Enabled = true;

        }
        private void drawMap(FormGame form)
        {
            formGame = new Draw(form).drawMap(map);

        }

        private void buttonGenerateDrawMap_Click(object sender, EventArgs e)
        {
            buttonMapGenerateDraw.Enabled = false;

            generateMap(Convert.ToInt16(numericUpDownMapX.Value), Convert.ToInt16(numericUpDownMapY.Value));

            drawMap(formGame);

            buttonMapGenerateDraw.Enabled = true;

        }


        private void buttonPlayerGenerate_Click(object sender, EventArgs e)
        {

            buttonPlayerGenerate.Enabled = false;
            generatePlayer(Convert.ToInt16(numericUpDownPlayerX.Value), Convert.ToInt16(numericUpDownPlayerY.Value));
            buttonPlayerGenerate.Enabled = true;

        }

        private void generatePlayer(int playerX, int playerY, int tileSize = 50, string playerName = "Player1")
        {

            player = new Object() { _Category = (Object)new Person { _Name = playerName, _PersonType = (Person)new Player() }, _Location = new Point { X = playerX * tileSize, Y = playerY * tileSize }, _Size = tileSize, _Picture = new Player()._Image };

        }

        private void buttonPlayerDraw_Click(object sender, EventArgs e)
        {
            buttonMapDraw.Enabled = false;
            drawPlayer(formGame);
            buttonMapDraw.Enabled = true;
        }

        private void drawPlayer(FormGame form)
        {
            new Draw(form).drawTile(new Tile { _Location = player._Location, _Size = player._Size, _Objct = player }); //new Point(x * size, y * size)
        }

        private void buttonPlayerGenerateDraw_Click(object sender, EventArgs e)
        {

            buttonPlayerGenerateDraw.Enabled = false;

            generatePlayer(Convert.ToInt16(numericUpDownPlayerX.Value), Convert.ToInt16(numericUpDownPlayerY.Value));
            drawPlayer(formGame);

            buttonPlayerGenerateDraw.Enabled = true;

        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
        }

    }
}
