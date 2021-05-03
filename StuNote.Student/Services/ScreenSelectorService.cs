using StuNote.Domain.Btos.Infrastructure;
using StuNote.Domain.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace StuNote.Student.Services
{
    public class ScreenSelectorService : IScreenSelectorService , INotifyPropertyChanged
    {
        private WindowSelectorBto _selectedScreen;
        public WindowSelectorBto SelectedScreen
        {
            get => _selectedScreen;
            set
            {
                _selectedScreen = value;
                NotifyPropertyChanged();
                OnSelectedScreenChanged?.Invoke(this, value);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<WindowSelectorBto> OnSelectedScreenChanged;

        public async IAsyncEnumerable<WindowSelectorBto> GetOpenWindowsAsync()
        {            
            Process[] processlist = Process.GetProcesses();            
            foreach (Process process in processlist)
            {                
                if (!string.IsNullOrEmpty(process.MainWindowTitle))
                {
                    await Task.CompletedTask;
                    yield return new()
                    {
                        Id = process.Id,
                        Title = process.MainWindowTitle,
                        HandleWindow = process.MainWindowHandle
                    };
                }
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
