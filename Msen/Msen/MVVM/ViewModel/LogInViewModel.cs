using Msen.Core;
using System.Diagnostics;

namespace Msen.MVVM.ViewModel
{
    public class LogInViewModel : ObservableObject
    {
		public RelayCommand LogInCommand { get; set; }

		private string _email = "";

		public string Email
		{
			get { return _email; }
			set 
			{ 
				_email = value;
				OnPropertyChanged();
            }
		}

		private string _password = "";

		public string Password
		{
			get { return _password; }
			set 
			{ 
				_password = value;
				OnPropertyChanged();
			}
		}

        public LogInViewModel()
        {
			LogInCommand = new RelayCommand(o =>
			{
				Debug.WriteLine($"{Email} + {Password}");
			});
        }
    }
}
