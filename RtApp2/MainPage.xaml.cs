using Microsoft.Maui.Controls;
using System;

namespace RtApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Evento para manejar el toque en la imagen
        private async void OnImageTapped(object sender, EventArgs e)
        {
            // Obtener la imagen que fue tocada
            var tappedImage = (Image)sender;
            var imageSource = tappedImage.Source.ToString(); // Obtener la ruta de la imagen

            // Mostrar la imagen completa en una ventana emergente
            await DisplayAlert("Vista Completa", $"Imagen: {imageSource}", "Cerrar");

            // Si quieres abrir la imagen en una nueva página modal o en una vista más grande
            // Puedes crear un método que muestre una nueva página con la imagen ampliada.
            var imagePage = new ContentPage
            {
                Content = new Image
                {
                    Source = imageSource,
                    Aspect = Aspect.AspectFit,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center
                }
            };

            // Mostrar la página de imagen
            await Navigation.PushModalAsync(imagePage);
        }
    }
}

