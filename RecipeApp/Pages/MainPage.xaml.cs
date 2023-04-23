using Microsoft.Maui.Controls;
using RecipeApp.Pages;
using System;

namespace RecipeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Title = "Retseptid";

            // Dynamically add the recipe images to the grid
            for (int i = 1; i <= 5; i++)
            {
                var imageButton = new ImageButton
                {
                    Source = $"recipe{i}.jpg",
                    Aspect = Aspect.AspectFill,
                    HeightRequest = 300,
                    CornerRadius = 15,
                    Margin = (10)
                };

                int index = i;
                imageButton.Clicked += (sender, e) =>
                {
                    // Navigate to the recipe details page for the clicked recipe
                    switch (index)
                    {
                        case 1:
                            Navigation.PushAsync(new RecipeDetailPage1());
                            break;
                        case 2:
                            Navigation.PushAsync(new RecipeDetailPage2());
                            break;
                        case 3:
                            Navigation.PushAsync(new RecipeDetailPage3());
                            break;
                        case 4:
                            Navigation.PushAsync(new RecipeDetailPage4());
                            break;
                        case 5:
                            Navigation.PushAsync(new RecipeDetailPage5());
                            break;
                    }
                };

                recipeStackLayout.Children.Add(imageButton);
            }
        }
    }
}