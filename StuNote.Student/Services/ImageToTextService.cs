using StuNote.Domain.Services.Infrastructure;
using System;
using System.Drawing;

namespace StuNote.Student.Services
{
    public class ImageToTextService : IImageToTextService
    {
        public string ReadText(Image Image)
        {
            var text = new IronOcr.IronTesseract().Read(Image).Text;
            return text;
        }
    }
}
