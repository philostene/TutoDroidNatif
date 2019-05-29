using Android.App;
using Android.Widget;
using Android.OS;
using FormationHulk.Resources;
using FormationHulk.Droid.Activities;
using FormationHulk.ViewModels;
using Android.Content;
using System;

namespace FormationHulk.Droid
{
    [Activity(Label = "FormationHulk", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : BaseActivity<MainViewModel>
    {
        protected override int Layout => Resource.Layout.Main;

        #region Controles
        private Button _startButton;
        public Button StartButton { get { return _startButton = _startButton ?? (_startButton = FindViewById<Button>(Resource.Id.startButton)); } }
        #endregion

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        protected override void SubscribeToViewModelEvents()
        {
            base.SubscribeToViewModelEvents();
            ViewModel.UserStoriesReverseCommand = new Toolkit.Commands.ReverseCommand(NavigateToUserStories);
        }

        protected override void SubscribeToViewEvents()
        {
            base.SubscribeToViewEvents();
            StartButton.Click += StartClick;
        }

        protected override void UnsubscribeFromViewEvents()
        {
            base.UnsubscribeFromViewEvents();
            StartButton.Click -= StartClick;
        }

        private void StartClick(object sender, EventArgs e)
        {
            ViewModel.StartCommand?.Execute();
        }

        private void NavigateToUserStories()
        {
            Intent intent = new Intent(this, typeof(UserStoriesActivity));
            StartActivity(intent);
        }
    }
}
