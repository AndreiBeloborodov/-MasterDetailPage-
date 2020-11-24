using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailPage_Smirnov
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MasterDetailPage() => InitializeComponent();

        public bool IsPresented { get; private set; }

        void OnButtonClick(object sender, EventArgs e)
        {
            // hide master page
            this.IsPresented = false;
            // show master page
            this.IsPresented = true;
        }
    }