using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Wrox.ProCSharp.Async
{
    public class BindableBase : INotifyPropertyChanged
    {
        protected void SetProperty<T>(ref T prop, T value, [CallerMemberName] string callerName = "")
        {
            if (!EqualityComparer<T>.Default.Equals(prop, value)) // Default checks whether T is IEquatable, if not returns result of .Equals()
            {
                prop = value;
                OnPropertyChanged(callerName);
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
