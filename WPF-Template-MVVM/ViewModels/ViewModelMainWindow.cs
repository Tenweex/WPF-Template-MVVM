using System.Collections.ObjectModel;
using System.Windows.Input;
using WPF_Template_MVVM.Models;
using WPF_Template_MVVM.Utilities;

namespace WPF_Template_MVVM.ViewModels
{
    public class ViewModelMainWindow : ViewModelBase
    {
        #region Fields
        private string _name = "";
        private string _firstname = "";
        #endregion

        #region Properties
        public ObservableCollection<User> Users { get; set; }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged(nameof(Name));
                NotifyPropertyChanged(nameof(Fullname));
            }
        }

        public string Firstname
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
                NotifyPropertyChanged(nameof(Firstname));
                NotifyPropertyChanged(nameof(Fullname));
            }
        }

        public string Fullname
        {
            get { return "Add " + Name + " " + Firstname; }
        }

        public ICommand CommandClick_AddUser { get; set; }
        #endregion


        #region Constructor
        public ViewModelMainWindow()
        {
            CommandClick_AddUser = new RelayCommand(AddUser, AddUserCanExecute);

            Users = new ObservableCollection<User>();
        }
        #endregion


        #region Events
        private bool AddUserCanExecute(object obj)
        {
            return !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Firstname);
        }

        private void AddUser(object obj)
        {
            Users.Add(new User(Name, Firstname));
            Name = "";
            Firstname = "";
        }
        #endregion
    }
}
