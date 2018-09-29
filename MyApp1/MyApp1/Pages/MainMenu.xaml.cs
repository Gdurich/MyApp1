using System;
using System.Collections.Generic;
using Xamarin.Forms;
using MyApp1.Models;


namespace MyApp1.Pages
{
    public partial class MainMenu : MasterDetailPage
    {
        public List<MainMenuItem> MainMenuItems { get; set; }

        public MainMenu()
        {
            // Set the binding context to this code behind.
            BindingContext = this;
            // Build the Menu
            MainMenuItems = new List<MainMenuItem>()
            {
                new MainMenuItem() { Title = "Map", Icon = "Map.png", TargetType = typeof(Map) },
                new MainMenuItem() { Title = "Google Search",Icon = "Google.png",  TargetType = typeof(GoogleSearch) },
                new MainMenuItem() { Title = "Пункт 1", TargetType = typeof(GoogleSearch) },
                new MainMenuItem() { Title = "Пункт 2", TargetType = typeof(GoogleSearch) },
                new MainMenuItem() { Title = "Пункт 3", TargetType = typeof(GoogleSearch) },
                new MainMenuItem() { Title = "Пункт 4", TargetType = typeof(GoogleSearch) }
            };

            // Set the default page, this is the "home" page.
            Detail = new NavigationPage(new GoogleSearch());

            InitializeComponent();
        }

        // When a MenuItem is selected.
        public void MainMenuItem_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MainMenuItem;
            if (item != null)
            {
                if (item.Title.Equals("Map"))
                {
                    Detail = new NavigationPage(new Map());
                }
                else if (item.Title.Equals("Google Search"))
                {
                    Detail = new NavigationPage(new GoogleSearch());
                }

                MenuListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
