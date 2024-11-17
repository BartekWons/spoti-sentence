using Msen.Core;
using Msen.MVVM.Model;
using Msen.MVVM.View;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Windows;

namespace Msen.MVVM.ViewModel
{
    public class MainWindowViewModel : ObservableObject
    {
        public RelayCommand MinimizeCommand { get; private set; }
        public RelayCommand CloseCommand { get; private set; }
        public RelayCommand DragToMoveCommand { get; private set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }


        //switch views commands
        public RelayCommand SwitchToHomeViewCommand { get; private set; }
        public RelayCommand SwitchToHistoryViewCommand { get; private set; }
        public RelayCommand SwitchToLogInCommand { get; private set; }

        public MainWindowViewModel()
        {
            CurrentView = ViewFactory.CreateView("SentenceView");

            MinimizeCommand = new RelayCommand(o =>
            {
                Application.Current.MainWindow.WindowState = WindowState.Minimized;
            });

            CloseCommand = new RelayCommand(o =>
            {
                Application.Current.MainWindow.Close();
            });

            DragToMoveCommand = new RelayCommand(o =>
            {
                Application.Current.MainWindow.DragMove();
            });

            try
            {
                SwitchToHomeViewCommand = new RelayCommand(o =>
                {
                    CurrentView = ViewFactory.CreateView("SentenceView");
                });

                SwitchToHistoryViewCommand = new RelayCommand(o =>
                {
                    CurrentView = ViewFactory.CreateView("HistoryView");
                });

                SwitchToLogInCommand = new RelayCommand(o =>
                {
                    CurrentView = ViewFactory.CreateView("LogInView");
                });
            }
            catch (Exception ex)
            {

            }
        }
    }
}
