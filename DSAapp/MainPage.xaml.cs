namespace DSAapp;
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnEnterClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new AlgoStructureMenu();
        }
    }

