namespace DeberFiguras
{
    partial class FrmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHomework = new Label();
            picFigures = new PictureBox();
            lblName = new Label();
            lblDate = new Label();
            lblNrc = new Label();
            ((System.ComponentModel.ISupportInitialize)picFigures).BeginInit();
            SuspendLayout();
            // 
            // lblHomework
            // 
            lblHomework.AutoSize = true;
            lblHomework.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHomework.Location = new Point(-1, 17);
            lblHomework.Name = "lblHomework";
            lblHomework.Size = new Size(388, 40);
            lblHomework.TabIndex = 7;
            lblHomework.Text = "Deber Figuras Geométricas";
            // 
            // picFigures
            // 
            picFigures.Location = new Point(181, 60);
            picFigures.Name = "picFigures";
            picFigures.Size = new Size(399, 273);
            picFigures.TabIndex = 11;
            picFigures.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(510, 336);
            lblName.Name = "lblName";
            lblName.Size = new Size(278, 30);
            lblName.TabIndex = 8;
            lblName.Text = "Nombre: Carlos Hernández";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(510, 366);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(183, 30);
            lblDate.TabIndex = 10;
            lblDate.Text = "Fecha: 11/5/2025";
            // 
            // lblNrc
            // 
            lblNrc.AutoSize = true;
            lblNrc.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNrc.Location = new Point(510, 396);
            lblNrc.Name = "lblNrc";
            lblNrc.Size = new Size(129, 30);
            lblNrc.TabIndex = 9;
            lblNrc.Text = "NRC: 23299";
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHomework);
            Controls.Add(picFigures);
            Controls.Add(lblName);
            Controls.Add(lblDate);
            Controls.Add(lblNrc);
            Name = "FrmInicio";
            Text = "FrmInicio";
            Load += FrmInicio_Load;
            ((System.ComponentModel.ISupportInitialize)picFigures).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHomework;
        private PictureBox picFigures;
        private Label lblName;
        private Label lblDate;
        private Label lblNrc;
    }
}