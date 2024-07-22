using System.Drawing;
using QRCoder;

namespace PD.Services
{
    public static class QRCodeGeneratorService
    {
        public static Bitmap GenerateQR(string textoQR)
        {
            using QRCodeGenerator qrGenerator = new();
            using QRCodeData qrCodeData = qrGenerator.CreateQrCode(textoQR, QRCodeGenerator.ECCLevel.Q);
            using var qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrAsBytes = qrCode.GetGraphic(20);
            using var ms = new MemoryStream(qrAsBytes);
            return new Bitmap(stream: ms);
        }
    }
}