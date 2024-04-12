using System;
using UnityEngine;

namespace Mobiiliesimerkki
{

	// Pelaajan tiedot
	[Serializable]
	public class PlayerData
	{
		public string ID; // GUID
		public Vector3 Position;
		public InventoryData InventoryData;
	}
}