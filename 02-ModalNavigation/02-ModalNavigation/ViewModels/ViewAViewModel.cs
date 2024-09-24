using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ModalNavigation.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;

        public ViewAViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            OpenViewBCommand = new DelegateCommand(async () => await OpenViewB());
        }

        public DelegateCommand OpenViewBCommand { get; }

        private async Task OpenViewB()
        {
            await _navigationService.NavigateAsync("ViewB");
        }
    }
}
