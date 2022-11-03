using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YouTubeViewers.Models;

namespace YouTubeViewers.ViewModels
{
    public class YouTubeViewersListingItemViewModel : ViewModelBase
    {
        public YouTubeViewer YouTubeViewer { get;}

        //public YouTubeViewersListingItemViewModel(string username)
        //{
        //    Username = username;
        //}

        public YouTubeViewersListingItemViewModel(YouTubeViewer youTubeViewer)
        {
            YouTubeViewer = youTubeViewer;
        }

        public string Username => YouTubeViewer.Username;
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
    }
}
