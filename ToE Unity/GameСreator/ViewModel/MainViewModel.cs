using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using GameСreator.ToePac;
using System;
using System.Windows.Input;

namespace GameСreator.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        string CurrentPage = string.Empty;
         public PAC ThisPac { get; private set; }
        public ListItem Items { get => ThisPac.Items; }
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            Messenger.Default.Register<Item>(this, AddNewResourse);

            this.CreateNewPackage = new RelayCommand(CreateNewPackageAction, CreateNewPackageCanEx);
            this.OpenResources = new RelayCommand(OpenResourcesAction, OpenResourcesCanEx);
            this.CreateNewResourse = new RelayCommand(CreateNewResourseAction, CreateNewResourseCanEx);
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        private void AddNewResourse(Item obj)
        {
            Items.Add(obj);
            this.RaisePropertyChanged("Items");
        }





        /// <summary>
        /// Открыть поле русурсов 
        /// </summary>
        public ICommand OpenResources { get; }

        /// <summary>
        /// Создать новый паке
        /// </summary>
        public ICommand CreateNewPackage { get; }
        /// <summary>
        /// Создать новый ресурс
        /// </summary>
        public ICommand CreateNewResourse { get; }

        private  void CreateNewPackageAction()
        {
           if(this.ThisPac == null)
            {
                this.ThisPac = new PAC();
            }
          //  this.OpenResources.CanExecute(null);
        }
        private bool CreateNewPackageCanEx() => true;
        /// <summary>
        /// Открыть поле русурсов действие
        /// </summary>
        private void OpenResourcesAction()
        {
            CurrentPage = "ResourcesPage";
            Messenger.Default.Send<NavigatorPageMessege>(new NavigatorPageMessege("ResourcesPage"));
         //   Messenger.Default.Send<PAC>(this.ThisPac);

        }
        private bool OpenResourcesCanEx() => this.ThisPac != null;



        private bool CreateNewResourseCanEx() => this.ThisPac != null && this.CurrentPage == "ResourcesPage";
        private void CreateNewResourseAction()
        {
            Messenger.Default.Send<NavigatorPageMessege>(new NavigatorPageMessege("AddResourseWindowOpen"));
        }

    }
}