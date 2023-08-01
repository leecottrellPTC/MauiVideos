namespace BindingVideos;
using BindingVideos.Models;
using BindingVideos.Data;
using System.Collections.ObjectModel;

public partial class MainPage : ContentPage
{
	public DataClass database = new();
	//List, Collection, ObservableCollection
	public ObservableCollection<Conversions> DataList { get; set; } = new();

	public MainPage()
	{
		InitializeComponent();
		foreach(Conversions conv in database.DataRay)
		{
			DataList.Add(conv);
		}
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
	}
}

