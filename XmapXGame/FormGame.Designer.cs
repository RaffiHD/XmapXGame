
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
            this.buttonGenerateMap = new System.Windows.Forms.Button();
            this.buttonDrawMap = new System.Windows.Forms.Button();
            this.buttonGenerateDrawMap = new System.Windows.Forms.Button();
            this.numericUpDownTilesX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTilesY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSizeMap = new System.Windows.Forms.NumericUpDown();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTilesX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTilesY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeMap)).BeginInit();
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
            // buttonGenerateMap
            // 
            this.buttonGenerateMap.Location = new System.Drawing.Point(793, 285);
            this.buttonGenerateMap.Name = "buttonGenerateMap";
            this.buttonGenerateMap.Size = new System.Drawing.Size(100, 23);
            this.buttonGenerateMap.TabIndex = 1;
            this.buttonGenerateMap.Text = "generate map";
            this.buttonGenerateMap.UseVisualStyleBackColor = true;
            this.buttonGenerateMap.Click += new System.EventHandler(this.buttonGenerateMap_Click);
            // 
            // buttonDrawMap
            // 
            this.buttonDrawMap.Location = new System.Drawing.Point(793, 314);
            this.buttonDrawMap.Name = "buttonDrawMap";
            this.buttonDrawMap.Size = new System.Drawing.Size(100, 23);
            this.buttonDrawMap.TabIndex = 2;
            this.buttonDrawMap.Text = "draw map";
            this.buttonDrawMap.UseVisualStyleBackColor = true;
            this.buttonDrawMap.Click += new System.EventHandler(this.buttonDrawMap_Click);
            // 
            // buttonGenerateDrawMap
            // 
            this.buttonGenerateDrawMap.Location = new System.Drawing.Point(687, 285);
            this.buttonGenerateDrawMap.Name = "buttonGenerateDrawMap";
            this.buttonGenerateDrawMap.Size = new System.Drawing.Size(100, 52);
            this.buttonGenerateDrawMap.TabIndex = 3;
            this.buttonGenerateDrawMap.Text = "generate\r\n+ draw";
            this.buttonGenerateDrawMap.UseVisualStyleBackColor = true;
            this.buttonGenerateDrawMap.Click += new System.EventHandler(this.buttonGenerateDrawMap_Click);
            // 
            // numericUpDownTilesX
            // 
            this.numericUpDownTilesX.Location = new System.Drawing.Point(687, 256);
            this.numericUpDownTilesX.Name = "numericUpDownTilesX";
            this.numericUpDownTilesX.Size = new System.Drawing.Size(64, 23);
            this.numericUpDownTilesX.TabIndex = 0;
            this.numericUpDownTilesX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownTilesY
            // 
            this.numericUpDownTilesY.Location = new System.Drawing.Point(758, 256);
            this.numericUpDownTilesY.Name = "numericUpDownTilesY";
            this.numericUpDownTilesY.Size = new System.Drawing.Size(64, 23);
            this.numericUpDownTilesY.TabIndex = 9;
            this.numericUpDownTilesY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownSizeMap
            // 
            this.numericUpDownSizeMap.Location = new System.Drawing.Point(829, 256);
            this.numericUpDownSizeMap.Name = "numericUpDownSizeMap";
            this.numericUpDownSizeMap.Size = new System.Drawing.Size(64, 23);
            this.numericUpDownSizeMap.TabIndex = 10;
            this.numericUpDownSizeMap.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(687, 343);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(206, 23);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(999, 579);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.numericUpDownSizeMap);
            this.Controls.Add(this.numericUpDownTilesY);
            this.Controls.Add(this.numericUpDownTilesX);
            this.Controls.Add(this.buttonGenerateDrawMap);
            this.Controls.Add(this.buttonDrawMap);
            this.Controls.Add(this.buttonGenerateMap);
            this.Controls.Add(this.panelMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGame";
            this.Text = "XmapXGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTilesX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTilesY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Button buttonGenerateMap;
        private System.Windows.Forms.Button buttonDrawMap;
        private System.Windows.Forms.Button buttonGenerateDrawMap;
        private System.Windows.Forms.NumericUpDown numericUpDownTilesX;
        private System.Windows.Forms.NumericUpDown numericUpDownTilesY;
        private System.Windows.Forms.NumericUpDown numericUpDownSizeMap;
        private System.Windows.Forms.Button buttonClear;
    }

}

