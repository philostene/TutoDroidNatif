using System;
using Android.App;
using Android.OS;
using GalaSoft.MvvmLight.Ioc;
using FormationHulk.Droid.ViewServices;
using Toolkit.ViewServices;
using Java.Lang;
using Android.Runtime;
using FormationHulk.Droid.IOC;

namespace FormationHulk.Droid
{
    [Application]
    public class FormationHulkApplication : Application, Application.IActivityLifecycleCallbacks
    {
        public FormationHulkApplication(IntPtr handle, JniHandleOwnership ownerShip) : base(handle, ownerShip)
        {
        }

        public override void OnCreate()
        {
            var bootstrap = new Bootstrap(GalaSoft.MvvmLight.Ioc.SimpleIoc.Default);
            bootstrap.Start();

            RegisterActivityLifecycleCallbacks(this);
            base.OnCreate();
        }

        public void OnActivityCreated(Activity activity, Bundle savedInstanceState)
        {
            ((DialogService)SimpleIoc.Default.GetInstance<IDialogService>()).Context = activity;
        }

        public void OnActivityDestroyed(Activity activity)
        {
        }

        public void OnActivityPaused(Activity activity)
        {
        }

        public void OnActivityResumed(Activity activity)
        {
            ((DialogService)SimpleIoc.Default.GetInstance<IDialogService>()).Context = activity;
        }

        public void OnActivitySaveInstanceState(Activity activity, Bundle outState)
        {
        }

        public void OnActivityStarted(Activity activity)
        {
            ((DialogService)SimpleIoc.Default.GetInstance<IDialogService>()).Context = activity;
        }

        public void OnActivityStopped(Activity activity)
        {
        }
    }
}
