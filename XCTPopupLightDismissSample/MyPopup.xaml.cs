using System;
using System.Collections.Generic;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace XCTPopupLightDismissSample
{
    public partial class MyPopup : Popup
    {
        public MyPopup()
        {
            InitializeComponent();
        }

        protected override object GetLightDismissResult()
        {
            return "Closed by light dismiss";
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Dismiss("Closed by button");
        }
    }
}
