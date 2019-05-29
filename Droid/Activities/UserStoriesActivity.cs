using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FormationHulk.ViewModels;

namespace FormationHulk.Droid.Activities
{
    [Activity(Label = "UserStoriesActivity")]
    public class UserStoriesActivity : BaseActivity<UserStoriesViewModel>
    {
        //Intialize ListView  
        ListView myList;
        protected override int Layout => Resource.Layout.UserStories;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource  
            SetContentView(Resource.Layout.UserStories);
            myList = FindViewById<ListView>(Resource.Id.listView);
            myList.Adapter = new MyCustomListAdapter(UserData.Users);
        }

        protected override void SetupControls()
        {
            base.SetupControls();

            //Button button = FindViewById<Button>(Resource.Id.startButton);

            //button.Text = Strings.HelloWorld;



        }
    }
}
