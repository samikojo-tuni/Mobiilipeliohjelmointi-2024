using System;
using System.Collections.Generic;

namespace Mobiiliesimerkki
{
	[Serializable]
	public class SpawnerData
	{
		public string ID;
		public float SpawnTimer;
		public int SpawnedItemCount;
		public List<ItemData> SpawnedItems = new List<ItemData>();
	}
}