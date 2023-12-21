namespace NotepadApp.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public static string Greeting => "Welcome to Avalonia!";
        public static string ButtonAddClicked => "Add " + IncrementValue;
        public static int IncrementValue => 2;
    }
}