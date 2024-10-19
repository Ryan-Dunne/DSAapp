namespace DSAapp;

public partial class AlgorithmsList : ContentPage
{
	public AlgorithmsList()
	{
		InitializeComponent();
	}

    private void OnLinearSearchClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new StructuresList();
    }

    private void OnFindFirstClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new FindFirst();
    }
}