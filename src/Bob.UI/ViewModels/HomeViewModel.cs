﻿using Bob.UI.Common;
using Okra.Core;
using Okra.Navigation;
using System.Composition;

namespace Bob.UI.ViewModels
{
    [ViewModelExport(SpecialPageNames.Home)]
    public class HomeViewModel
    {
        private readonly INavigationManager _navigationManager;

        [ImportingConstructor]
        public HomeViewModel(INavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
            NumericTextBoxCommand = new DelegateCommand(() => navigationManager.NavigateTo(PageNames.NumericTextBox));
        }

        public DelegateCommand NumericTextBoxCommand { get; set; }

        public void NavigateToDayMonthYearSelectorDemo()
        {
            _navigationManager.NavigateTo(typeof(DayMonthYearSelectorDemoViewModel));
        }

        public void NavigateToConstrainedImageDemo()
        {
            _navigationManager.NavigateTo(typeof(ConstrainedImageDemoViewModel));
        }
    }
}
