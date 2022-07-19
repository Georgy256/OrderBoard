using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OrderBoard.AppHelpers
{
    public abstract class Notifier : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string props = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(props));
        }
    }
}
