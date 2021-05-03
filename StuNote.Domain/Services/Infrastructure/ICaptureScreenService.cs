using System;
using System.Drawing;

namespace StuNote.Domain.Services.Infrastructure
{
    public interface ICaptureScreenService
    {
        Bitmap CaptureScreen(IntPtr WindowHandle);
    }
}
