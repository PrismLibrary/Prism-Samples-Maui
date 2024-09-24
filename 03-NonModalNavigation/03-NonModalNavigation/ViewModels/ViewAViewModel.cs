using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_NonModalNavigation.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;

        public ViewAViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateToViewBCommand = new DelegateCommand(async () => await NavigateToViewB());
        }

        public DelegateCommand NavigateToViewBCommand { get; }

        private async Task NavigateToViewB()
        {
            await _navigationService.NavigateAsync("ViewB");
        }
    }
}
