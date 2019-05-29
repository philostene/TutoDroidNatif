using System;
using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using FormationHulk.IOC;
using FormationHulk.iOS.Services;
using Toolkit.ViewServices;

namespace FormationHulk.iOS.IOC
{
    public class Bootstrap : BootstrapBase
    {
        private readonly ISimpleIoc _simpleIoc;

        public Bootstrap(ISimpleIoc simpleIoc)
        {
            _simpleIoc = simpleIoc;
            ServiceLocator.SetLocatorProvider(() => simpleIoc);
        }

        public override void Start()
        {
            Setup(_simpleIoc);
        }

        protected override void Setup(ISimpleIoc simpleIoc)
        {
            simpleIoc.Register<IDialogService, DialogService>();

            base.Setup(simpleIoc);
        }
    }
}
