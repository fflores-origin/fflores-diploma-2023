using QRCoder;
using System.Drawing;

namespace PD.Services
{
    public static class QRCodeGeneratorService
    {
        public static Bitmap GenerateQR(string textoQR)
        {
            QRCodeGenerator qrGenerator = new();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(textoQR, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            return qrCodeImage;
        }
    }
}