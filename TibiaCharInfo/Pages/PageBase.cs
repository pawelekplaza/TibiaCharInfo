using System.Windows.Controls;
using TibiaCharInfo.Models;

namespace TibiaCharInfo.Pages
{
    public class PageBase : Page
    {
        virtual public PageId PageId { get; protected set; }
        public void SetViewModel(object viewModel)
        {
            DataContext = viewModel;
        }
    }
}
