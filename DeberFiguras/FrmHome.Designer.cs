namespace DeberFiguras
{
    partial class FrmHome
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
            menuStrip1 = new MenuStrip();
            poligonosToolStripMenuItem = new ToolStripMenuItem();
            cuadrilaterosToolStripMenuItem = new ToolStripMenuItem();
            romboToolStripMenuItem = new ToolStripMenuItem();
            deltoideToolStripMenuItem = new ToolStripMenuItem();
            romboideToolStripMenuItem = new ToolStripMenuItem();
            curvasToolStripMenuItem = new ToolStripMenuItem();
            circulosToolStripMenuItem = new ToolStripMenuItem();
            elipseToolStripMenuItem = new ToolStripMenuItem();
            ovaloToolStripMenuItem = new ToolStripMenuItem();
            paralelogramosToolStripMenuItem = new ToolStripMenuItem();
            cuadradoToolStripMenuItem = new ToolStripMenuItem();
            rectanguloToolStripMenuItem = new ToolStripMenuItem();
            trapeciosToolStripMenuItem = new ToolStripMenuItem();
            trapecioToolStripMenuItem = new ToolStripMenuItem();
            trapecioIsolToolStripMenuItem = new ToolStripMenuItem();
            triangulosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { poligonosToolStripMenuItem, cuadrilaterosToolStripMenuItem, curvasToolStripMenuItem, paralelogramosToolStripMenuItem, trapeciosToolStripMenuItem, triangulosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(852, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menu";
            // 
            // poligonosToolStripMenuItem
            // 
            poligonosToolStripMenuItem.Name = "poligonosToolStripMenuItem";
            poligonosToolStripMenuItem.Size = new Size(72, 20);
            poligonosToolStripMenuItem.Text = "Polígonos";
            poligonosToolStripMenuItem.Click += poligonosToolStripMenuItem_Click;
            // 
            // cuadrilaterosToolStripMenuItem
            // 
            cuadrilaterosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { romboToolStripMenuItem, deltoideToolStripMenuItem, romboideToolStripMenuItem });
            cuadrilaterosToolStripMenuItem.Name = "cuadrilaterosToolStripMenuItem";
            cuadrilaterosToolStripMenuItem.Size = new Size(89, 20);
            cuadrilaterosToolStripMenuItem.Text = "Cuadriláteros";
            // 
            // romboToolStripMenuItem
            // 
            romboToolStripMenuItem.Name = "romboToolStripMenuItem";
            romboToolStripMenuItem.Size = new Size(129, 22);
            romboToolStripMenuItem.Text = "Rombo";
            romboToolStripMenuItem.Click += romboToolStripMenuItem_Click;
            // 
            // deltoideToolStripMenuItem
            // 
            deltoideToolStripMenuItem.Name = "deltoideToolStripMenuItem";
            deltoideToolStripMenuItem.Size = new Size(129, 22);
            deltoideToolStripMenuItem.Text = "Deltoide";
            deltoideToolStripMenuItem.Click += deltoideToolStripMenuItem_Click;
            // 
            // romboideToolStripMenuItem
            // 
            romboideToolStripMenuItem.Name = "romboideToolStripMenuItem";
            romboideToolStripMenuItem.Size = new Size(129, 22);
            romboideToolStripMenuItem.Text = "Romboide";
            romboideToolStripMenuItem.Click += romboideToolStripMenuItem_Click;
            // 
            // curvasToolStripMenuItem
            // 
            curvasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { circulosToolStripMenuItem, elipseToolStripMenuItem, ovaloToolStripMenuItem });
            curvasToolStripMenuItem.Name = "curvasToolStripMenuItem";
            curvasToolStripMenuItem.Size = new Size(55, 20);
            curvasToolStripMenuItem.Text = "Curvas";
            // 
            // circulosToolStripMenuItem
            // 
            circulosToolStripMenuItem.Name = "circulosToolStripMenuItem";
            circulosToolStripMenuItem.Size = new Size(112, 22);
            circulosToolStripMenuItem.Text = "Círculo";
            circulosToolStripMenuItem.Click += circulosToolStripMenuItem_Click;
            // 
            // elipseToolStripMenuItem
            // 
            elipseToolStripMenuItem.Name = "elipseToolStripMenuItem";
            elipseToolStripMenuItem.Size = new Size(112, 22);
            elipseToolStripMenuItem.Text = "Elipse";
            elipseToolStripMenuItem.Click += elipseToolStripMenuItem_Click;
            // 
            // ovaloToolStripMenuItem
            // 
            ovaloToolStripMenuItem.Name = "ovaloToolStripMenuItem";
            ovaloToolStripMenuItem.Size = new Size(112, 22);
            ovaloToolStripMenuItem.Text = "Óvalo";
            ovaloToolStripMenuItem.Click += ovaloToolStripMenuItem_Click;
            // 
            // paralelogramosToolStripMenuItem
            // 
            paralelogramosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cuadradoToolStripMenuItem, rectanguloToolStripMenuItem });
            paralelogramosToolStripMenuItem.Name = "paralelogramosToolStripMenuItem";
            paralelogramosToolStripMenuItem.Size = new Size(101, 20);
            paralelogramosToolStripMenuItem.Text = "Paralelogramos";
            // 
            // cuadradoToolStripMenuItem
            // 
            cuadradoToolStripMenuItem.Name = "cuadradoToolStripMenuItem";
            cuadradoToolStripMenuItem.Size = new Size(134, 22);
            cuadradoToolStripMenuItem.Text = "Cuadrado";
            cuadradoToolStripMenuItem.Click += cuadradoToolStripMenuItem_Click;
            // 
            // rectanguloToolStripMenuItem
            // 
            rectanguloToolStripMenuItem.Name = "rectanguloToolStripMenuItem";
            rectanguloToolStripMenuItem.Size = new Size(134, 22);
            rectanguloToolStripMenuItem.Text = "Rectángulo";
            rectanguloToolStripMenuItem.Click += rectanguloToolStripMenuItem_Click;
            // 
            // trapeciosToolStripMenuItem
            // 
            trapeciosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { trapecioToolStripMenuItem, trapecioIsolToolStripMenuItem });
            trapeciosToolStripMenuItem.Name = "trapeciosToolStripMenuItem";
            trapeciosToolStripMenuItem.Size = new Size(69, 20);
            trapeciosToolStripMenuItem.Text = "Trapecios";
            // 
            // trapecioToolStripMenuItem
            // 
            trapecioToolStripMenuItem.Name = "trapecioToolStripMenuItem";
            trapecioToolStripMenuItem.Size = new Size(163, 22);
            trapecioToolStripMenuItem.Text = "Trapecio";
            trapecioToolStripMenuItem.Click += trapecioToolStripMenuItem_Click;
            // 
            // trapecioIsolToolStripMenuItem
            // 
            trapecioIsolToolStripMenuItem.Name = "trapecioIsolToolStripMenuItem";
            trapecioIsolToolStripMenuItem.Size = new Size(163, 22);
            trapecioIsolToolStripMenuItem.Text = "Trapecio Isóceles";
            trapecioIsolToolStripMenuItem.Click += trapecioIsolToolStripMenuItem_Click;
            // 
            // triangulosToolStripMenuItem
            // 
            triangulosToolStripMenuItem.Name = "triangulosToolStripMenuItem";
            triangulosToolStripMenuItem.Size = new Size(69, 20);
            triangulosToolStripMenuItem.Text = "Triángulo";
            triangulosToolStripMenuItem.Click += triangulosToolStripMenuItem_Click;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 518);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.Desktop;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmHome";
            Text = "Figuras";
            Load += FrmHome_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem poligonosToolStripMenuItem;
        private ToolStripMenuItem cuadrilaterosToolStripMenuItem;
        private ToolStripMenuItem romboToolStripMenuItem;
        private ToolStripMenuItem deltoideToolStripMenuItem;
        private ToolStripMenuItem romboideToolStripMenuItem;
        private ToolStripMenuItem curvasToolStripMenuItem;
        private ToolStripMenuItem circulosToolStripMenuItem;
        private ToolStripMenuItem elipseToolStripMenuItem;
        private ToolStripMenuItem ovaloToolStripMenuItem;
        private ToolStripMenuItem paralelogramosToolStripMenuItem;
        private ToolStripMenuItem cuadradoToolStripMenuItem;
        private ToolStripMenuItem rectanguloToolStripMenuItem;
        private ToolStripMenuItem trapeciosToolStripMenuItem;
        private ToolStripMenuItem trapecioToolStripMenuItem;
        private ToolStripMenuItem trapecioIsolToolStripMenuItem;
        private ToolStripMenuItem triangulosToolStripMenuItem;
    }
}
