using System;
using System.Drawing;

namespace StuNote.Domain.Btos.Infrastructure
{
    public record WindowSelectorBto : BtoBase
    {
        public string Title { get; set; }

        public Bitmap Tile { get; set; }

        public IntPtr HandleWindow { get; set; }
    }
}
