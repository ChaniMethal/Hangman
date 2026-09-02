using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HangmanSystem
{
    public class Letter : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        string _lettervalue = "";
        bool _isenabled = true;

        public string LetterValue
        {
            get => _lettervalue;
            set
            {
                _lettervalue = value;
                this.InvokePropertyChanged();
            }
        }
        public bool IsEnabled
        {
            get => _isenabled;
            set
            {
                _isenabled = value;
                this.InvokePropertyChanged(); 
            }
        }
        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
