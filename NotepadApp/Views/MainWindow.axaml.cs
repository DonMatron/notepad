using Avalonia.Controls;
using Avalonia.Interactivity;
using NotepadApp.ViewModels;

namespace NotepadApp.Views
{
    public partial class MainWindow : Window
    {
        private int count = 0;

        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Width = 400;
            Height = 700;
            MinWidth = Width;
            MinHeight = 400;
        }

        public void ClickHandler(object sender, RoutedEventArgs args)
        {
            
        }
    }
}