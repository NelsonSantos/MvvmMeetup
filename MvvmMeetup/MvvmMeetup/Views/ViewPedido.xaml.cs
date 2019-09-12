using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmMeetup.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewPedido : ContentPage
    {
        public ViewPedido()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.ViewModelPedido();
        }
    }
}