namespace Inicio_Y_Portal
{
    partial class TerminarAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminarAlta));
            lblPregunta = new Label();
            bttnSi = new Button();
            bttnNo = new Button();
            SuspendLayout();
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPregunta.Location = new Point(13, 84);
            lblPregunta.Margin = new Padding(4, 0, 4, 0);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(288, 22);
            lblPregunta.TabIndex = 0;
            lblPregunta.Text = "Quieres continuar dando de alta?";
            // 
            // bttnSi
            // 
            bttnSi.Cursor = Cursors.Hand;
            bttnSi.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnSi.Location = new Point(33, 154);
            bttnSi.Margin = new Padding(4, 3, 4, 3);
            bttnSi.Name = "bttnSi";
            bttnSi.Size = new Size(88, 27);
            bttnSi.TabIndex = 1;
            bttnSi.Text = "Si";
            bttnSi.UseVisualStyleBackColor = true;
            bttnSi.Click += bttnSi_Click;
            // 
            // bttnNo
            // 
            bttnNo.Cursor = Cursors.Hand;
            bttnNo.DialogResult = DialogResult.Cancel;
            bttnNo.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnNo.Location = new Point(192, 154);
            bttnNo.Margin = new Padding(4, 3, 4, 3);
            bttnNo.Name = "bttnNo";
            bttnNo.Size = new Size(88, 27);
            bttnNo.TabIndex = 2;
            bttnNo.Text = "No";
            bttnNo.UseVisualStyleBackColor = true;
            bttnNo.Click += bttnNo_Click;
            // 
            // TerminarAlta
            // 
            AcceptButton = bttnSi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            BackgroundImage = InmoSolution.Properties.Resources.Terminar_alta;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = bttnNo;
            ClientSize = new Size(317, 235);
            Controls.Add(bttnNo);
            Controls.Add(bttnSi);
            Controls.Add(lblPregunta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "TerminarAlta";
            Text = "Terminar Alta de Proyecto";
            Load += TerminarAlta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button bttnSi;
        private System.Windows.Forms.Button bttnNo;
    }
}