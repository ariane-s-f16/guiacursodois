namespace guiacursodois
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            InitializeComponent();

            MainPage = new Shell
            {
                Items =
                {
                    new ShellContent { Content = new MainPage() },
                   
                }
            };
        }
    }
}
