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
        }

        public void ClickHandler(object sender, RoutedEventArgs args)
        {
            count += MainWindowViewModel.IncrementValue;
            Message.Text = count.ToString();
        }
    }
}