using GalaSoft.MvvmLight.Ioc;
using FormationHulk.Services;
using FormationHulk.ViewModels;
using Toolkit.ErrorManagement;
using Toolkit.ViewServices;

namespace FormationHulk.IOC
{
    public abstract class BootstrapBase
    {
        public abstract void Start();

        protected virtual void Setup(ISimpleIoc simpleIoc)
        {
            simpleIoc.Register<IErrorHandler, ErrorHandler>();

            simpleIoc.Register<MainViewModel>();
            simpleIoc.Register<UserStoriesViewModel>();
        }
    }
}
