using DevExpress.XtraGrid.Views.Tile;
using StuNote.Domain.Btos.Infrastructure;
using StuNote.Domain.Services.Infrastructure;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace StuNote.Student.UIControl
{
    public partial class FormWindowSelector : DevExpress.XtraEditors.XtraForm
    {
        private readonly IScreenSelectorService _screenSelectorService;
        private readonly ICaptureScreenService _captureScreenService;
        private ObservableCollection<WindowSelectorBto> OpenWindows;

        public FormWindowSelector(
            IScreenSelectorService screenSelectorService,
            ICaptureScreenService captureScreenService)
        {
            InitializeComponent();
            OpenWindows = new();
            OpenWindows.CollectionChanged += OpenWindows_CollectionChanged;
            _screenSelectorService = screenSelectorService;
            _captureScreenService = captureScreenService;
            gridControl1.DataSource = OpenWindows;
            
            FormClosing += (s, e) =>
            {
                OpenWindows.Clear();
                e.Cancel = true;
                Hide();
            };
            tileView1.ItemDoubleClick += (s, e) =>
             {
                 var row = tileView1.GetRow(e.Item.RowHandle)  as WindowSelectorBto;
                 _screenSelectorService.SelectedScreen = row;
                 Hide();
             };
        }

        private void OpenWindows_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                var window = e.NewItems[0] as WindowSelectorBto;
                var image = _captureScreenService.CaptureScreen(window.HandleWindow);
                window.Tile = image;
            } 
        }

        public async Task LoadOpenWindowsAsync()
        {
            OpenWindows.Clear();
            await foreach (var item in _screenSelectorService.GetOpenWindowsAsync())
            {
                OpenWindows.Add(item);
            }            
        }
    }
}