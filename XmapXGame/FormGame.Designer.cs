
namespace XmapXGame
{
    partial class FormGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMap = new System.Windows.Forms.Panel();
            this.buttonMapGenerate = new System.Windows.Forms.Button();
            this.buttonMapDraw = new System.Windows.Forms.Button();
            this.buttonMapGenerateDraw = new System.Windows.Forms.Button();
            this.numericUpDownMapX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMapY = new System.Windows.Forms.NumericUpDown();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelMapX = new System.Windows.Forms.Label();
            this.labelMapY = new System.Windows.Forms.Label();
            this.labelPlayerPositionY = new System.Windows.Forms.Label();
            this.labelPlayerPositionX = new System.Windows.Forms.Label();
            this.numericUpDownPlayerY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPlayerX = new System.Windows.Forms.NumericUpDown();
            this.buttonPlayerGenerateDraw = new System.Windows.Forms.Button();
            this.buttonPlayerDraw = new System.Windows.Forms.Button();
            this.buttonPlayerGenerate = new System.Windows.Forms.Button();
            this.richTextBoxDebug = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayerY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayerX)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMap
            // 
            this.panelMap.BackColor = System.Drawing.Color.White;
            this.panelMap.Location = new System.Drawing.Point(12, 12);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(500, 500);
            this.panelMap.TabIndex = 0;
            // 
            // buttonMapGenerate
            // 
            this.buttonMapGenerate.Location = new System.Drawing.Point(661, 69);
            this.buttonMapGenerate.Name = "buttonMapGenerate";
            this.buttonMapGenerate.Size = new System.Drawing.Size(100, 23);
            this.buttonMapGenerate.TabIndex = 1;
            this.buttonMapGenerate.Text = "generate map";
            this.buttonMapGenerate.UseVisualStyleBackColor = true;
            this.buttonMapGenerate.Click += new System.EventHandler(this.buttonGenerateMap_Click);
            // 
            // buttonMapDraw
            // 
            this.buttonMapDraw.Location = new System.Drawing.Point(661, 98);
            this.buttonMapDraw.Name = "buttonMapDraw";
            this.buttonMapDraw.Size = new System.Drawing.Size(100, 23);
            this.buttonMapDraw.TabIndex = 2;
            this.buttonMapDraw.Text = "draw map";
            this.buttonMapDraw.UseVisualStyleBackColor = true;
            this.buttonMapDraw.Click += new System.EventHandler(this.buttonDrawMap_Click);
            // 
            // buttonMapGenerateDraw
            // 
            this.buttonMapGenerateDraw.Location = new System.Drawing.Point(767, 69);
            this.buttonMapGenerateDraw.Name = "buttonMapGenerateDraw";
            this.buttonMapGenerateDraw.Size = new System.Drawing.Size(100, 52);
            this.buttonMapGenerateDraw.TabIndex = 3;
            this.buttonMapGenerateDraw.Text = "generate\r\n+ draw";
            this.buttonMapGenerateDraw.UseVisualStyleBackColor = true;
            this.buttonMapGenerateDraw.Click += new System.EventHandler(this.buttonGenerateDrawMap_Click);
            // 
            // numericUpDownMapX
            // 
            this.numericUpDownMapX.Location = new System.Drawing.Point(661, 40);
            this.numericUpDownMapX.Name = "numericUpDownMapX";
            this.numericUpDownMapX.Size = new System.Drawing.Size(64, 23);
            this.numericUpDownMapX.TabIndex = 0;
            this.numericUpDownMapX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownMapY
            // 
            this.numericUpDownMapY.Location = new System.Drawing.Point(732, 40);
            this.numericUpDownMapY.Name = "numericUpDownMapY";
            this.numericUpDownMapY.Size = new System.Drawing.Size(64, 23);
            this.numericUpDownMapY.TabIndex = 9;
            this.numericUpDownMapY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(661, 489);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(206, 23);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelMapX
            // 
            this.labelMapX.AutoSize = true;
            this.labelMapX.Location = new System.Drawing.Point(661, 22);
            this.labelMapX.Name = "labelMapX";
            this.labelMapX.Size = new System.Drawing.Size(41, 15);
            this.labelMapX.TabIndex = 12;
            this.labelMapX.Text = "map X";
            // 
            // labelMapY
            // 
            this.labelMapY.AutoSize = true;
            this.labelMapY.Location = new System.Drawing.Point(732, 22);
            this.labelMapY.Name = "labelMapY";
            this.labelMapY.Size = new System.Drawing.Size(41, 15);
            this.labelMapY.TabIndex = 13;
            this.labelMapY.Text = "map Y";
            // 
            // labelPlayerPositionY
            // 
            this.labelPlayerPositionY.AutoSize = true;
            this.labelPlayerPositionY.Location = new System.Drawing.Point(732, 164);
            this.labelPlayerPositionY.Name = "labelPlayerPositionY";
            this.labelPlayerPositionY.Size = new System.Drawing.Size(49, 15);
            this.labelPlayerPositionY.TabIndex = 22;
            this.labelPlayerPositionY.Text = "player Y";
            // 
            // labelPlayerPositionX
            // 
            this.labelPlayerPositionX.AutoSize = true;
            this.labelPlayerPositionX.Location = new System.Drawing.Point(661, 164);
            this.labelPlayerPositionX.Name = "labelPlayerPositionX";
            this.labelPlayerPositionX.Size = new System.Drawing.Size(49, 15);
            this.labelPlayerPositionX.TabIndex = 21;
            this.labelPlayerPositionX.Text = "player X";
            // 
            // numericUpDownPlayerY
            // 
            this.numericUpDownPlayerY.Location = new System.Drawing.Point(732, 182);
            this.numericUpDownPlayerY.Name = "numericUpDownPlayerY";
            this.numericUpDownPlayerY.Size = new System.Drawing.Size(64, 23);
            this.numericUpDownPlayerY.TabIndex = 19;
            // 
            // numericUpDownPlayerX
            // 
            this.numericUpDownPlayerX.Location = new System.Drawing.Point(661, 182);
            this.numericUpDownPlayerX.Name = "numericUpDownPlayerX";
            this.numericUpDownPlayerX.Size = new System.Drawing.Size(64, 23);
            this.numericUpDownPlayerX.TabIndex = 15;
            // 
            // buttonPlayerGenerateDraw
            // 
            this.buttonPlayerGenerateDraw.Location = new System.Drawing.Point(767, 211);
            this.buttonPlayerGenerateDraw.Name = "buttonPlayerGenerateDraw";
            this.buttonPlayerGenerateDraw.Size = new System.Drawing.Size(100, 52);
            this.buttonPlayerGenerateDraw.TabIndex = 18;
            this.buttonPlayerGenerateDraw.Text = "generate\r\n+ draw";
            this.buttonPlayerGenerateDraw.UseVisualStyleBackColor = true;
            this.buttonPlayerGenerateDraw.Click += new System.EventHandler(this.buttonPlayerGenerateDraw_Click);
            // 
            // buttonPlayerDraw
            // 
            this.buttonPlayerDraw.Location = new System.Drawing.Point(661, 240);
            this.buttonPlayerDraw.Name = "buttonPlayerDraw";
            this.buttonPlayerDraw.Size = new System.Drawing.Size(100, 23);
            this.buttonPlayerDraw.TabIndex = 17;
            this.buttonPlayerDraw.Text = "draw player";
            this.buttonPlayerDraw.UseVisualStyleBackColor = true;
            this.buttonPlayerDraw.Click += new System.EventHandler(this.buttonPlayerDraw_Click);
            // 
            // buttonPlayerGenerate
            // 
            this.buttonPlayerGenerate.Location = new System.Drawing.Point(661, 211);
            this.buttonPlayerGenerate.Name = "buttonPlayerGenerate";
            this.buttonPlayerGenerate.Size = new System.Drawing.Size(100, 23);
            this.buttonPlayerGenerate.TabIndex = 16;
            this.buttonPlayerGenerate.Text = "generate player";
            this.buttonPlayerGenerate.UseVisualStyleBackColor = true;
            this.buttonPlayerGenerate.Click += new System.EventHandler(this.buttonPlayerGenerate_Click);
            // 
            // richTextBoxDebug
            // 
            this.richTextBoxDebug.Location = new System.Drawing.Point(562, 287);
            this.richTextBoxDebug.Name = "richTextBoxDebug";
            this.richTextBoxDebug.Size = new System.Drawing.Size(402, 162);
            this.richTextBoxDebug.TabIndex = 24;
            this.richTextBoxDebug.Text = "";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(999, 579);
            this.Controls.Add(this.richTextBoxDebug);
            this.Controls.Add(this.labelPlayerPositionY);
            this.Controls.Add(this.labelPlayerPositionX);
            this.Controls.Add(this.numericUpDownPlayerY);
            this.Controls.Add(this.numericUpDownPlayerX);
            this.Controls.Add(this.buttonPlayerGenerateDraw);
            this.Controls.Add(this.buttonPlayerDraw);
            this.Controls.Add(this.buttonPlayerGenerate);
            this.Controls.Add(this.labelMapY);
            this.Controls.Add(this.labelMapX);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.numericUpDownMapY);
            this.Controls.Add(this.numericUpDownMapX);
            this.Controls.Add(this.buttonMapGenerateDraw);
            this.Controls.Add(this.buttonMapDraw);
            this.Controls.Add(this.buttonMapGenerate);
            this.Controls.Add(this.panelMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGame";
            this.Text = "XmapXGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayerY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayerX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Button buttonMapGenerate;
        private System.Windows.Forms.Button buttonMapDraw;
        private System.Windows.Forms.Button buttonMapGenerateDraw;
        private System.Windows.Forms.NumericUpDown numericUpDownMapX;
        private System.Windows.Forms.NumericUpDown numericUpDownMapY;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelMapX;
        private System.Windows.Forms.Label labelMapY;
        private System.Windows.Forms.Label labelPlayerPositionY;
        private System.Windows.Forms.Label labelPlayerPositionX;
        private System.Windows.Forms.NumericUpDown numericUpDownPlayerY;
        private System.Windows.Forms.NumericUpDown numericUpDownPlayerX;
        private System.Windows.Forms.Button buttonPlayerGenerateDraw;
        private System.Windows.Forms.Button buttonPlayerDraw;
        private System.Windows.Forms.Button buttonPlayerGenerate;
        private System.Windows.Forms.RichTextBox richTextBoxDebug;
    }

}

