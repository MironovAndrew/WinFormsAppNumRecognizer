namespace WinFormsAppNumRecognizer
{
    partial class FormMain
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
            buttonPredict = new Button();
            label1 = new Label();
            panelMain = new Panel();
            DrawingArea = new PictureBox();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DrawingArea).BeginInit();
            SuspendLayout();
            // 
            // buttonPredict
            // 
            buttonPredict.BackColor = SystemColors.ActiveCaption;
            buttonPredict.FlatAppearance.BorderSize = 0;
            buttonPredict.FlatStyle = FlatStyle.Flat;
            buttonPredict.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPredict.Location = new Point(13, 337);
            buttonPredict.Name = "buttonPredict";
            buttonPredict.Size = new Size(300, 34);
            buttonPredict.TabIndex = 1;
            buttonPredict.Text = "Угадать";
            buttonPredict.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 12F);
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(300, 18);
            label1.TabIndex = 2;
            label1.Text = "Нарисуйте цифру";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(DrawingArea);
            panelMain.Controls.Add(buttonPredict);
            panelMain.Controls.Add(label1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(327, 379);
            panelMain.TabIndex = 3;
            // 
            // DrawingArea
            // 
            DrawingArea.BackColor = Color.White;
            DrawingArea.BorderStyle = BorderStyle.FixedSingle;
            DrawingArea.Location = new Point(12, 33);
            DrawingArea.Name = "DrawingArea";
            DrawingArea.Size = new Size(298, 298);
            DrawingArea.TabIndex = 0;
            DrawingArea.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(327, 379);
            Controls.Add(panelMain);
            MaximizeBox = false;
            MaximumSize = new Size(343, 414);
            MinimumSize = new Size(343, 414);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DrawingArea).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonPredict;
        private Label label1;
        private Panel panelMain;
        private PictureBox DrawingArea;
    }
}
