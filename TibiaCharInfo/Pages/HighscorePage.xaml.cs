using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TibiaCharInfo.Models;

namespace TibiaCharInfo.Pages
{
    /// <summary>
    /// Interaction logic for HighscorePage.xaml
    /// </summary>
    public partial class HighscorePage : PageBase
    {
        public override PageId PageId => PageId.Highscore;
        public HighscorePage()
        {
            InitializeComponent();            
        }
    }
}
