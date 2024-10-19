namespace DSAapp;
public partial class AlgoStructureMenu : ContentPage
{
	public AlgoStructureMenu()
	{
        InitializeComponent();
	}

    private void OnAlgoMenuClicked(object sender, EventArgs e)
	{ 
        Application.Current.MainPage = new AlgorithmsList();
    }

    private void OnStructureMenuClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new StructuresList();
    }
}