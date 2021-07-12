
namespace Gerando_QRCode2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDados = new System.Windows.Forms.TextBox();
            this.btnGerarQRCode = new System.Windows.Forms.Button();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o texto:";
            // 
            // txtDados
            // 
            this.txtDados.Location = new System.Drawing.Point(16, 30);
            this.txtDados.Name = "txtDados";
            this.txtDados.Size = new System.Drawing.Size(261, 20);
            this.txtDados.TabIndex = 1;
            // 
            // btnGerarQRCode
            // 
            this.btnGerarQRCode.Location = new System.Drawing.Point(16, 57);
            this.btnGerarQRCode.Name = "btnGerarQRCode";
            this.btnGerarQRCode.Size = new System.Drawing.Size(163, 48);
            this.btnGerarQRCode.TabIndex = 2;
            this.btnGerarQRCode.Text = "Gerar QRCode";
            this.btnGerarQRCode.UseVisualStyleBackColor = true;
            this.btnGerarQRCode.Click += new System.EventHandler(this.btnGerarQRCode_Click);
            // 
            // picQRCode
            // 
            this.picQRCode.Location = new System.Drawing.Point(16, 112);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(163, 171);
            this.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQRCode.TabIndex = 3;
            this.picQRCode.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 295);
            this.Controls.Add(this.picQRCode);
            this.Controls.Add(this.btnGerarQRCode);
            this.Controls.Add(this.txtDados);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDados;
        private System.Windows.Forms.Button btnGerarQRCode;
        private System.Windows.Forms.PictureBox picQRCode;
    }
}

