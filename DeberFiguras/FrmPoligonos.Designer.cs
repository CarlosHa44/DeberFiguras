namespace DeberFiguras
{
    partial class FrmPoligonos
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
            grbInputs = new GroupBox();
            txtLenght = new TextBox();
            txtSizes = new TextBox();
            label2 = new Label();
            label1 = new Label();
            grbProcess = new GroupBox();
            btnExit = new Button();
            btnReset = new Button();
            btnCalculate = new Button();
            grbOutputs = new GroupBox();
            txtArea = new TextBox();
            txtPerimeter = new TextBox();
            lblPerimeter = new Label();
            lblArea = new Label();
            grbGraphic = new GroupBox();
            picImg = new PictureBox();
            grbInputs.SuspendLayout();
            grbProcess.SuspendLayout();
            grbOutputs.SuspendLayout();
            grbGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImg).BeginInit();
            SuspendLayout();
            // 
            // grbInputs
            // 
            grbInputs.Controls.Add(txtLenght);
            grbInputs.Controls.Add(txtSizes);
            grbInputs.Controls.Add(label2);
            grbInputs.Controls.Add(label1);
            grbInputs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbInputs.Location = new Point(11, 11);
            grbInputs.Name = "grbInputs";
            grbInputs.Size = new Size(296, 154);
            grbInputs.TabIndex = 0;
            grbInputs.TabStop = false;
            grbInputs.Text = "Entradas";
            // 
            // txtLenght
            // 
            txtLenght.Location = new Point(120, 101);
            txtLenght.Name = "txtLenght";
            txtLenght.Size = new Size(170, 29);
            txtLenght.TabIndex = 3;
            // 
            // txtSizes
            // 
            txtSizes.Location = new Point(120, 42);
            txtSizes.Name = "txtSizes";
            txtSizes.Size = new Size(170, 29);
            txtSizes.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 109);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 1;
            label2.Text = "Longitud:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 50);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 0;
            label1.Text = "Nro de lados:";
            // 
            // grbProcess
            // 
            grbProcess.Controls.Add(btnExit);
            grbProcess.Controls.Add(btnReset);
            grbProcess.Controls.Add(btnCalculate);
            grbProcess.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbProcess.Location = new Point(11, 171);
            grbProcess.Name = "grbProcess";
            grbProcess.Size = new Size(296, 105);
            grbProcess.TabIndex = 1;
            grbProcess.TabStop = false;
            grbProcess.Text = "Proceso";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(187, 44);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(87, 30);
            btnExit.TabIndex = 2;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(96, 44);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(85, 30);
            btnReset.TabIndex = 1;
            btnReset.Text = "Resetear";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(13, 42);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(78, 32);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // grbOutputs
            // 
            grbOutputs.Controls.Add(txtArea);
            grbOutputs.Controls.Add(txtPerimeter);
            grbOutputs.Controls.Add(lblPerimeter);
            grbOutputs.Controls.Add(lblArea);
            grbOutputs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbOutputs.Location = new Point(15, 288);
            grbOutputs.Name = "grbOutputs";
            grbOutputs.Size = new Size(292, 150);
            grbOutputs.TabIndex = 2;
            grbOutputs.TabStop = false;
            grbOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            txtArea.Enabled = false;
            txtArea.Location = new Point(116, 34);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(170, 29);
            txtArea.TabIndex = 3;
            // 
            // txtPerimeter
            // 
            txtPerimeter.Enabled = false;
            txtPerimeter.ImeMode = ImeMode.NoControl;
            txtPerimeter.Location = new Point(116, 81);
            txtPerimeter.Name = "txtPerimeter";
            txtPerimeter.Size = new Size(170, 29);
            txtPerimeter.TabIndex = 2;
            // 
            // lblPerimeter
            // 
            lblPerimeter.AutoSize = true;
            lblPerimeter.Location = new Point(16, 89);
            lblPerimeter.Name = "lblPerimeter";
            lblPerimeter.Size = new Size(94, 21);
            lblPerimeter.TabIndex = 1;
            lblPerimeter.Text = "Perímetro :";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(57, 42);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(53, 21);
            lblArea.TabIndex = 0;
            lblArea.Text = "Área :";
            // 
            // grbGraphic
            // 
            grbGraphic.Controls.Add(picImg);
            grbGraphic.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbGraphic.Location = new Point(316, 11);
            grbGraphic.Name = "grbGraphic";
            grbGraphic.Size = new Size(472, 427);
            grbGraphic.TabIndex = 3;
            grbGraphic.TabStop = false;
            grbGraphic.Text = "Grafico";
            // 
            // picImg
            // 
            picImg.Location = new Point(8, 24);
            picImg.Name = "picImg";
            picImg.Size = new Size(458, 391);
            picImg.TabIndex = 0;
            picImg.TabStop = false;
            // 
            // FrmPoligonos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbGraphic);
            Controls.Add(grbOutputs);
            Controls.Add(grbProcess);
            Controls.Add(grbInputs);
            Name = "FrmPoligonos";
            Text = "Poligonos";
            Load += FrmPoligonos_Load;
            grbInputs.ResumeLayout(false);
            grbInputs.PerformLayout();
            grbProcess.ResumeLayout(false);
            grbOutputs.ResumeLayout(false);
            grbOutputs.PerformLayout();
            grbGraphic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbInputs;
        private GroupBox grbProcess;
        private GroupBox grbOutputs;
        private GroupBox grbGraphic;
        private PictureBox picImg;
        private Label lblArea;
        private Label lblPerimeter;
        private TextBox txtArea;
        private TextBox txtPerimeter;
        private Button btnCalculate;
        private Button btnExit;
        private Button btnReset;
        private Label label2;
        private Label label1;
        private TextBox txtLenght;
        private TextBox txtSizes;
    }
}