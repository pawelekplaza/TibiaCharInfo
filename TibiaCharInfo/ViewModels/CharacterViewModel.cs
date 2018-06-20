using TibiaCharInfo.Models;

namespace TibiaCharInfo.ViewModels
{
    public class CharacterViewModel : ViewModelBase
    {
        private Character _model;

        public string Name => _model.Data.Name;
        public int Level => _model.Data.Level;

        public CharacterViewModel(Character model)
        {
            _model = model;
        }
    }
}
