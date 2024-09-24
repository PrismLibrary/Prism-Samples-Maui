using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_PrismNavigation.ViewModels
{
    public class SecondPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;

        public DelegateCommand GoBackCommand { get; }

        public SecondPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            GoBackCommand = new DelegateCommand(GoBack);
        }

        private async void GoBack()
        {
            await _navigationService.GoBackAsync();
        }
    }
}
