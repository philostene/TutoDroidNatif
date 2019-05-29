using System;
using System.Threading;
using System.Threading.Tasks;
using Toolkit.Commands;
using Toolkit.ErrorManagement;
using Toolkit.ViewServices;

namespace FormationHulk.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ReverseCommand UserStoriesReverseCommand { get; set; }
        private SyncCommand _startCommand;
        public SyncCommand StartCommand
        {
            get => _startCommand;
            set => Set(ref _startCommand, value);
        }


        public MainViewModel(IDialogService dialogService,
                                IErrorHandler errorHandler) : base(dialogService, errorHandler)
        {
            StartCommand = new SyncCommand(NavigateToUserStories);
        }

        protected override async Task StartAsync(CancellationToken ct)
        {
        }

        private void NavigateToUserStories()
        {
            UserStoriesReverseCommand?.Execute();
        }
    }
}
