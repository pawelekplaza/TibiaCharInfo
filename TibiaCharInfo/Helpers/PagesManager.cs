using System.Collections.Generic;
using TibiaCharInfo.Pages;
using System.Linq;
using TibiaCharInfo.ViewModels;
using TibiaCharInfo.Models;

namespace TibiaCharInfo.Helpers
{
    public static class PagesManager
    {
        private static MainWindow _window;
        private static Dictionary<PageId, PageBase> _pagesCache;

        public static IList<PageBase> PagesStack { get; private set; } = new List<PageBase>();

        public static void Initialize(MainWindow mainWindow)
        {
            _window = mainWindow;
            _pagesCache = new Dictionary<PageId, PageBase>();
        }

        public static void Show(PageBase page, object viewModel = null)
        {
            AddToPagesCache(page);
            _window.mainFrame.Navigate(page);

            if (viewModel != null)
                page.DataContext = viewModel;

            if (page.DataContext is ViewModelBase pageViewModel)
                pageViewModel.RaiseAllPropertyChanged();

            PagesStack.Add(page);
        }

        public static void GoBack()
        {
            if (PagesStack.Count <= 1)
                return;

            PagesStack.RemoveAt(PagesStack.Count - 1);
            Show(PagesStack.Last());
        }

        private static void AddToPagesCache(PageBase page)
        {
            if (_pagesCache.ContainsKey(page.PageId))
                return;
            _pagesCache.Add(page.PageId, page);
        }
    }
}
