using System.Drawing;
using MessagingToolkit.QRCode.Codec;
using System.Windows.Forms;
using System;

namespace Gerando_QRCode2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGerarQRCode_Click(object sender, System.EventArgs e)
        {
            try
            {
                QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
                qrCodeEncoder.QRCodeBackgroundColor = System.Drawing.Color.Yellow;
                qrCodeEncoder.QRCodeForegroundColor = System.Drawing.Color.Green;
                qrCodeEncoder.CharacterSet = "UTF-8";
                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                qrCodeEncoder.QRCodeScale = 6;
                qrCodeEncoder.QRCodeVersion = 0;
                qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;

                Image imageQRCode;
                //string a ser gerada
                String dados = txtDados.Text;
                imageQRCode = qrCodeEncoder.Encode(dados);
                picQRCode.Image = imageQRCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
