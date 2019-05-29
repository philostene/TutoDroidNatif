using System;
using System.Threading;
using System.Threading.Tasks;
using Toolkit.ErrorManagement;
using Toolkit.ViewServices;
using Toolkit.Commands;

namespace FormationHulk.ViewModels
{
    public class UserStoriesViewModel : BaseViewModel
    {
        public UserStoriesViewModel(IDialogService dialogService,
                                IErrorHandler errorHandler) : base(dialogService, errorHandler)
        {

        }

        protected override async Task StartAsync(CancellationToken ct)
        {

        }
    }
}
