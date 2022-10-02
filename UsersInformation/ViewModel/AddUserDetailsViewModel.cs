using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Windows;
using UsersInformation.Models;

namespace UsersInformation.ViewModel
{
    public class AddUserDetailsViewModel: ViewModelBase
    {

        //Properties 

        private ObservableCollection<PersonDetails>? _listOfPersonDetails;
        public ObservableCollection<PersonDetails> ListOfPersonDetails
        {
            get { return _listOfPersonDetails; }
            set 
            {
                _listOfPersonDetails = value;
                NotifyPropertyChanged("ListOfPersonDetails");
            }
        }

        private PersonDetails? _PersonDetails;

        public PersonDetails? PersonDetails
        {
            get
            {
                return _PersonDetails;
            }
            set
            {
                _PersonDetails = value;
                NotifyPropertyChanged("PersonDetails");
            }
        }

        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Age { get; set; }
        public string? Qualification { get; set; }


        //RelayCommands 
        public RelayCommand? OnSubmitClickCommand { get; set; }


        public AddUserDetailsViewModel()
        {
            PersonDetails = new PersonDetails();
            ListOfPersonDetails = new ObservableCollection<PersonDetails>();
            ListOfPersonDetails.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(Students_CollectionChanged);
            OnSubmitClickCommand = new RelayCommand(OnSubmitClickCommandHandler);

        }

        void Students_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged("ListOfPersonDetails");
        }

        private void OnSubmitClickCommandHandler()
        {
            try
            {
                AddUser();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }

        }

        private void AddUser()
        {
            ListOfPersonDetails.Add(new PersonDetails()
            {
                Name = Name,
                Email = Email,
                Age = Age,
                Qualification = Qualification
            });
        }
    }
}
