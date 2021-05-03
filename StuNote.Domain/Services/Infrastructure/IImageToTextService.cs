using System.Drawing;

namespace StuNote.Domain.Services.Infrastructure
{
    public interface IImageToTextService
    {
        string ReadText(Image Image);
    }
}
