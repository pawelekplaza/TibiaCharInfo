using TibiaCharInfo.Models;

namespace TibiaCharInfo.Pages
{
    /// <summary>
    /// Interaction logic for CharacterPage.xaml
    /// </summary>
    public partial class CharacterPage : PageBase
    {
        public override PageId PageId => PageId.Character;
        public CharacterPage()
        {
            InitializeComponent();
        }
    }
}
