using System.ComponentModel;

namespace TibiaCharInfo.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public void RaiseAllPropertyChanged()
        {
            foreach (var property in GetType().GetProperties())
                RaisePropertyChanged(property.Name);
        }
    }
}
