using System;
using System.Collections.Generic;

namespace Mobiiliesimerkki
{

	[Serializable]
	public class GameData
	{
		// TODO: Määritä kaikki tallennettava data tänne
		// Pelaajan tiedot. Jos pelaajia olisi enemmän, tässä olisi lista.
		public PlayerData PlayerData;

		// Item Spawnereiden tiedot. Sisältävät myös tiedon kaikista spawnatuista itemeistä.
		public List<SpawnerData> SpawnerData = new List<SpawnerData>();
	}
}