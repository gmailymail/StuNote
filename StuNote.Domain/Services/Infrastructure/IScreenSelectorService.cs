using StuNote.Domain.Btos.Infrastructure;
using System;
using System.Collections.Generic;

namespace StuNote.Domain.Services.Infrastructure
{
    public interface IScreenSelectorService
    {
        event EventHandler<WindowSelectorBto> OnSelectedScreenChanged;

        IAsyncEnumerable<WindowSelectorBto> GetOpenWindowsAsync();

        public WindowSelectorBto SelectedScreen { get; set; }
    }
}
