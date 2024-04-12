using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
	[CreateAssetMenu(fileName = "ItemDatabase",
		menuName = "Mobiiliesimerkki/ItemDatabase")]
	public class ItemDatabase : ScriptableObject
	{
		[SerializeField]
		private Item[] _items = null;

		public Item GetItem(ItemType type)
		{
			foreach (Item item in _items)
			{
				if (item.Type == type)
				{
					return item;
				}
			}

			return null;
		}
	}
}
