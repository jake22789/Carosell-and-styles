using Carosell_and_styles.Models;
using Carosell_and_styles.PageModels;

namespace Carosell_and_styles.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}