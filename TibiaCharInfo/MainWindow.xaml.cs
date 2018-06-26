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
using TibiaCharInfo.Controllers;
using TibiaCharInfo.Helpers;
using TibiaCharInfo.Models;

namespace TibiaCharInfo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += (s, e) =>
            {
                PagesManager.Initialize(this);
            };
        }

        public async void ShowSomePage()
        {
            var highscoreController = new HighscoreController();
            PagesManager.Show(PageId.Highscore, await highscoreController.GetHighscore("Vunira"));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowSomePage();
        }
    }
}
