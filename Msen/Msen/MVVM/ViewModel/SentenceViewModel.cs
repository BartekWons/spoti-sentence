using Msen.Core;
using System.Diagnostics;
using System.Windows.Data;

namespace Msen.MVVM.ViewModel
{
    public class SentenceViewModel : ObservableObject
    {
		public RelayCommand CreatePlaylistCommand { get; private set; }

		private string _playlistName;

		public string PlaylistName
		{
			get { return _playlistName; }
			set 
			{ 
				_playlistName = value;
				OnPropertyChanged();
			}
		}

		private string _sentence;

		public string Sentence
		{
			get { return _sentence; }
			set 
			{ 
				_sentence = value; 
				OnPropertyChanged();
			}
		}

        public SentenceViewModel()
        {
			CreatePlaylistCommand = new RelayCommand(o =>
			{
				Debug.WriteLine($"{PlaylistName} + {Sentence}");
			});
        }
    }
}
