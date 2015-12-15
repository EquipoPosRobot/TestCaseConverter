namespace TestCaseConverter
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SourceTb = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenSourceBtn = new System.Windows.Forms.Button();
            this.OpenDestBtn = new System.Windows.Forms.Button();
            this.DestTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SourceTb
            // 
            this.SourceTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceTb.Enabled = false;
            this.SourceTb.Location = new System.Drawing.Point(60, 12);
            this.SourceTb.Name = "SourceTb";
            this.SourceTb.Size = new System.Drawing.Size(349, 20);
            this.SourceTb.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "*.script";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "iscript";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original";
            // 
            // OpenSourceBtn
            // 
            this.OpenSourceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenSourceBtn.Location = new System.Drawing.Point(415, 10);
            this.OpenSourceBtn.Name = "OpenSourceBtn";
            this.OpenSourceBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenSourceBtn.TabIndex = 2;
            this.OpenSourceBtn.Text = "Examinar";
            this.OpenSourceBtn.UseVisualStyleBackColor = true;
            this.OpenSourceBtn.Click += new System.EventHandler(this.OpenSourceBtn_Click);
            // 
            // OpenDestBtn
            // 
            this.OpenDestBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenDestBtn.Location = new System.Drawing.Point(415, 36);
            this.OpenDestBtn.Name = "OpenDestBtn";
            this.OpenDestBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenDestBtn.TabIndex = 3;
            this.OpenDestBtn.Text = "Examinar";
            this.OpenDestBtn.UseVisualStyleBackColor = true;
            this.OpenDestBtn.Click += new System.EventHandler(this.OpenDestBtn_Click);
            // 
            // DestTb
            // 
            this.DestTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestTb.Enabled = false;
            this.DestTb.Location = new System.Drawing.Point(60, 38);
            this.DestTb.Name = "DestTb";
            this.DestTb.Size = new System.Drawing.Size(349, 20);
            this.DestTb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destino";
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertBtn.Location = new System.Drawing.Point(415, 84);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(75, 23);
            this.ConvertBtn.TabIndex = 6;
            this.ConvertBtn.Text = "Convertir";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 119);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DestTb);
            this.Controls.Add(this.OpenDestBtn);
            this.Controls.Add(this.OpenSourceBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SourceTb);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 158);
            this.MinimumSize = new System.Drawing.Size(518, 158);
            this.Name = "Form1";
            this.Text = "TestCase Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SourceTb;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenSourceBtn;
        private System.Windows.Forms.Button OpenDestBtn;
        private System.Windows.Forms.TextBox DestTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConvertBtn;
    }
}

