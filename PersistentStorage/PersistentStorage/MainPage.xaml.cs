using GoogleGson;
using Java.Security;
using PersistentStorage.Models;
using System.Formats.Asn1;
using System.IO;
using System.Text.Json;

namespace PersistentStorage;

public partial class MainPage : ContentPage
{
	int count = 0;
	public HelloClicker hc = new();
	private string _fileName = FileSystem.AppDataDirectory + "/HelloClicker.json";

	public async void WriteToFile()
	{
		var writeData = JsonSerializer.Serialize(hc);
		File.WriteAllText(_fileName, writeData);
	}

	public async void ReadFromFile()
	{
		HelloClicker readHC = new();
		if(File.Exists(this._fileName) == false)
		{
			//no file
			return;
		}
		var rawData = File.ReadAllText(_fileName);
		readHC = JsonSerializer.Deserialize<HelloClicker>(rawData);

		hc.Total = readHC.Total;
		hc.Last = readHC.Current;
		hc.Current = 0;

		CounterBtn.Text = $"Clicked {hc.Total} times";
		CurrentClickLabel.Text = hc.Current.ToString();
		LasClickLabel.Text = hc.Last.ToString();

    }

	public MainPage()
	{
		InitializeComponent();
		ReadFromFile();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		//count++;
		hc.Current++;
		hc.Total ++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {hc.Total} time";
		else
			CounterBtn.Text = $"Clicked {hc.Total} times";

		CurrentClickLabel.Text = hc.Current.ToString();

		SemanticScreenReader.Announce(CounterBtn.Text);
		WriteToFile();
	}
}

