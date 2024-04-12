using System;
using System.IO;
using UnityEngine;

namespace Mobiiliesimerkki
{
	// TODO: Generalisoi tämä siten, luokka voidaan helposti korvata toisella.
	public class DataStorage
	{
		private const string c_gameName = "Mobiiliesimerkki";

		public string SaveDirectory { get; }
		public string FileExtension => ".json";
		public string SaveFolder => "Save";

		public DataStorage()
		{
			string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			SaveDirectory = Path.Combine(myDocuments, c_gameName, SaveFolder);
		}

		public void Save(string saveSlot, GameData data)
		{
			// TODO: Tämä vaatii oikeasti enemmän virhetarkasteluja, mm. onko meillä oikeutta
			// kirjoittaa tiedostoon.
			if (!Directory.Exists(SaveDirectory))
			{
				Directory.CreateDirectory(SaveDirectory);
			}
			string savePath = GetSavePath(saveSlot);

			// Datan serialisointi. HUOM! Json.NET on tässä parempi kuin Unityn JsonUtility.
			string json = JsonUtility.ToJson(data);

			File.WriteAllText(savePath, json);
		}

		public GameData Load(string saveSlot)
		{
			string savePath = GetSavePath(saveSlot);
			if (!File.Exists(savePath))
			{
				// Jos tallennettua tiedostoa ei ole, palautetaan null
				// virheen merkiksi.
				return null;
			}

			// Luetaan tiedoston sisältö stringinä. Tiedosto on JSON-muodossa.
			string json = File.ReadAllText(savePath);

			// Deserialisoidaan JSON-muotoinen data ja palautetaan
			// deserialisoitu olio.
			GameData data = JsonUtility.FromJson<GameData>(json);
			return data;
		}

		private string GetSavePath(string saveSlot)
		{
			return Path.Combine(SaveDirectory, saveSlot + FileExtension);
		}
	}
}