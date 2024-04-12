using System;
using System.Collections.Generic;

namespace Mobiiliesimerkki
{
	[Serializable]
	public class InventoryData
	{
		public List<ItemType> ItemTypes = new List<ItemType>();
		public List<uint> ItemCounts = new List<uint>();
	}
}