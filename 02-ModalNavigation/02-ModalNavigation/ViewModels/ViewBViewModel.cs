using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ModalNavigation.ViewModels
{
    public class ViewBViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;

        public ViewBViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            CloseCommand = new DelegateCommand(async () => await Close());
        }

        public DelegateCommand CloseCommand { get; }

        private async Task Close()
        {
            await _navigationService.GoBackAsync();
        }
    }
}
