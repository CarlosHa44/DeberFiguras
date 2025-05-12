namespace DeberFiguras
{
    partial class FrmTrapecio
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
            grbGraphic = new GroupBox();
            picImg = new PictureBox();
            grbOutputs = new GroupBox();
            txtArea = new TextBox();
            txtPerimeter = new TextBox();
            lblPerimeter = new Label();
            lblArea = new Label();
            grbProcess = new GroupBox();
            btnExit = new Button();
            btnReset = new Button();
            btnCalculate = new Button();
            grbInputs = new GroupBox();
            txtAltura = new TextBox();
            txtBaseMenor = new TextBox();
            txtBaseMayor = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grbGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImg).BeginInit();
            grbOutputs.SuspendLayout();
            grbProcess.SuspendLayout();
            grbInputs.SuspendLayout();
            SuspendLayout();
            // 
            // grbGraphic
            // 
            grbGraphic.Controls.Add(picImg);
            grbGraphic.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbGraphic.Location = new Point(317, 12);
            grbGraphic.Name = "grbGraphic";
            grbGraphic.Size = new Size(472, 427);
            grbGraphic.TabIndex = 7;
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
            // grbOutputs
            // 
            grbOutputs.Controls.Add(txtArea);
            grbOutputs.Controls.Add(txtPerimeter);
            grbOutputs.Controls.Add(lblPerimeter);
            grbOutputs.Controls.Add(lblArea);
            grbOutputs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbOutputs.Location = new Point(16, 289);
            grbOutputs.Name = "grbOutputs";
            grbOutputs.Size = new Size(292, 150);
            grbOutputs.TabIndex = 6;
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
            // grbProcess
            // 
            grbProcess.Controls.Add(btnExit);
            grbProcess.Controls.Add(btnReset);
            grbProcess.Controls.Add(btnCalculate);
            grbProcess.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbProcess.Location = new Point(12, 172);
            grbProcess.Name = "grbProcess";
            grbProcess.Size = new Size(296, 105);
            grbProcess.TabIndex = 5;
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
            // grbInputs
            // 
            grbInputs.Controls.Add(txtAltura);
            grbInputs.Controls.Add(txtBaseMenor);
            grbInputs.Controls.Add(txtBaseMayor);
            grbInputs.Controls.Add(label3);
            grbInputs.Controls.Add(label2);
            grbInputs.Controls.Add(label1);
            grbInputs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbInputs.Location = new Point(12, 12);
            grbInputs.Name = "grbInputs";
            grbInputs.Size = new Size(296, 154);
            grbInputs.TabIndex = 4;
            grbInputs.TabStop = false;
            grbInputs.Text = "Entradas";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(120, 95);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(170, 29);
            txtAltura.TabIndex = 5;
            // 
            // txtBaseMenor
            // 
            txtBaseMenor.Location = new Point(120, 57);
            txtBaseMenor.Name = "txtBaseMenor";
            txtBaseMenor.Size = new Size(170, 29);
            txtBaseMenor.TabIndex = 4;
            // 
            // txtBaseMayor
            // 
            txtBaseMayor.Location = new Point(120, 17);
            txtBaseMayor.Name = "txtBaseMayor";
            txtBaseMayor.Size = new Size(170, 29);
            txtBaseMayor.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 103);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 2;
            label3.Text = "Altura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 65);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 1;
            label2.Text = "Base Menor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 25);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 0;
            label1.Text = "Base Mayor:";
            // 
            // FrmTrapecio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbGraphic);
            Controls.Add(grbOutputs);
            Controls.Add(grbProcess);
            Controls.Add(grbInputs);
            Name = "FrmTrapecio";
            Text = "Trapecio";
            Load += FrmTrapecio_Load;
            grbGraphic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImg).EndInit();
            grbOutputs.ResumeLayout(false);
            grbOutputs.PerformLayout();
            grbProcess.ResumeLayout(false);
            grbInputs.ResumeLayout(false);
            grbInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbGraphic;
        private PictureBox picImg;
        private GroupBox grbOutputs;
        private TextBox txtArea;
        private TextBox txtPerimeter;
        private Label lblPerimeter;
        private Label lblArea;
        private GroupBox grbProcess;
        private Button btnExit;
        private Button btnReset;
        private Button btnCalculate;
        private GroupBox grbInputs;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAltura;
        private TextBox txtBaseMenor;
        private TextBox txtBaseMayor;
    }
}