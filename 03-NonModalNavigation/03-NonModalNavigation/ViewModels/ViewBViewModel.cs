using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_NonModalNavigation.ViewModels
{
    public class ViewBViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;

        public ViewBViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            BackCommand = new DelegateCommand(async () => await GoBack());
        }

        public DelegateCommand BackCommand { get; }

        private async Task GoBack()
        {
            await _navigationService.GoBackAsync();
        }
    }
}
