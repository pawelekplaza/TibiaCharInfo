using System.Collections.Generic;
using TibiaCharInfo.Pages;
using System.Linq;
using TibiaCharInfo.ViewModels;
using TibiaCharInfo.Models;
using System;

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

        public static void Show(PageId pageId, object viewModel = null)
        {
            var page = GetPage(pageId);
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

        private static void Show(PageBase page)
        {
            _window.mainFrame.Navigate(page);
            PagesStack.Add(page);
        }

        private static void AddToPagesCache(PageBase page)
        {
            if (_pagesCache.ContainsKey(page.PageId))
                return;
            _pagesCache.Add(page.PageId, page);
        }

        private static PageBase GetPage(PageId pageId)
        {
            if (_pagesCache.ContainsKey(pageId))
                return _pagesCache[pageId];

            var page = GetCorrectPageBase(pageId);
            AddToPagesCache(page);
            return page;
        }

        private static PageBase GetCorrectPageBase(PageId pageId)
        {
            switch (pageId)
            {
                case PageId.Base: return new PageBase();
                case PageId.Character: return new CharacterPage();
                case PageId.Highscore: return new HighscorePage();
                default:
                    throw new NotImplementedException($"Page with id '{ pageId }' not found.");
            }
        }
    }
}
