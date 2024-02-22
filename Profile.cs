using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONAssignment
{
    public class Profile : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }
        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastName)));
            }
        }

        private string _email;
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
            }
        }

        private string _bio;

        public string Bio
        {
            get => _bio;
            set
            {
                _bio = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Bio)));
            }
        }
    }
}
