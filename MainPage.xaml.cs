using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace JSONAssignment
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        //private string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "profiles.txt");


        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            UserProfile = LoadFile();
            

        }

        #region Profile Data

        private Profile _profile;
        public Profile UserProfile 
        { 
            get => _profile; 
            set 
            {  _profile = value;
               OnPropertyChanged();           
            } 
        }  
        /*private string _name;
            public string Name
            {
            get => _name;
                set
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        private string _lastName;
            public string Lastname
            {
                get => _lastName;
                set
                {
                    _lastName = value;
                    OnPropertyChanged();
                }
            }

        private string _email;
            public string Email
            {
                get => _email;
                set
                {
                    _email = value;
                    OnPropertyChanged();
                }
            }

        private string _bio;
            public string Bio
            {
                get => _bio;
                set
                {
                    _bio = value;
                    OnPropertyChanged();
                }
            }*/

        public string json;

        //Profile profile = new Profile();

        #endregion

        #region Buttons

        public void SaveFile(Profile profile) 
        {
            string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "profiles.txt");
            json = JsonConvert.SerializeObject(profile);
            File.WriteAllText(_fileName, json);
        }

        public static Profile LoadFile() 
        {
            string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "profiles.txt");
            

            if (File.Exists(_fileName))
            {
                string profilecontent = File.ReadAllText(_fileName);
                Profile newprofile = JsonConvert.DeserializeObject<Profile>(profilecontent);
                return newprofile;
            }
            else 
            { 
                return new Profile();
            }
            
        }

        private void SaveBtn_Clicked(object sender, EventArgs e)
        {
            SaveFile(UserProfile);
        }

        private void LoadBtn_Clicked(object sender, EventArgs e)
        {
            UserProfile=LoadFile();
        }

        #endregion
    }

}
