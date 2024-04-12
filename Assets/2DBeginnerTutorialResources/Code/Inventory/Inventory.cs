using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
	public class Inventory
	{
		// Sisältää avain-arvopareja. Kunkin avaimen on oltava uniikki.
		// Avain: Item, Arvo: Määrä (uint)
		// uint: unsigned integer, ei voi olla negatiivinen
		private Dictionary<Item, uint> _items = new Dictionary<Item, uint>();

		public float MaxWeight { get; }

		public Inventory(float maxWeight)
		{
			// Auto-propertyn arvon, jolla ei ole set-määrettä, voi asettaa vain konstruktorissa.
			MaxWeight = maxWeight;
		}

		public bool Add(Item item, uint amount)
		{
			// Tarkista, ylittyykö inventorion maksimipaino
			if (GetWeight() + item.Weight * amount > MaxWeight)
			{
				return false;
			}

			if (item.IsKeyItem)
			{
				_items.Add(item, amount);
				return true;
			}

			// Tarkista, onko tavara jo inventoriossa
			bool exists = _items.ContainsKey(item);

			if (exists)
			{
				_items[item] += amount;
			}
			else
			{
				_items.Add(item, amount);
			}

			Debug.Log($"Lisättiin esine {item.Name}, määrä: {amount}.");
			Debug.Log($"Esineiden {item.Name} kokonaismäärä: {_items[item]}.");

			return true;
		}

		public bool Remove(Item item, uint amount)
		{
			if (!_items.ContainsKey(item) || _items[item] < amount)
			{
				return false;
			}

			if (_items[item] == amount)
			{
				_items.Remove(item);
			}
			else
			{
				_items[item] -= amount;
			}

			return true;
		}

		/// <summary>
		/// Palauttaa inventorion kokonaispainon.
		/// </summary>
		/// <returns></returns>
		public float GetWeight()
		{
			// Laske inventorion kokonaispaino
			float weight = 0;
			foreach (KeyValuePair<Item, uint> item in _items)
			{
				weight += item.Key.Weight * item.Value;
			}

			return weight;
		}

		public float GetValue()
		{
			// Laske inventorion kokonaisarvo
			float value = 0;
			foreach (KeyValuePair<Item, uint> item in _items)
			{
				value += item.Key.Value * item.Value;
			}

			return value;
		}

		public void Clear()
		{
			_items.Clear();
		}

		/// <summary>
		/// Palauttaa inventorion tavaroista ja niiden määristä koostuvan listan.
		/// </summary>
		/// <returns>Lista, jossa ensimmäisenä arvona on itse tavara ja toisena arvona
		/// niiden lukumäärä.</returns>
		public List<(Item, uint)> GetItems()
		{
			// Palauta lista inventorion tavaroista ja niiden määristä
			List<(Item, uint)> items = new List<(Item, uint)>();
			foreach (KeyValuePair<Item, uint> item in _items)
			{
				items.Add((item.Key, item.Value));
			}

			return items;
		}

		public InventoryData GetSaveData()
		{
			InventoryData data = new InventoryData();
			foreach (KeyValuePair<Item, uint> item in _items)
			{
				data.ItemTypes.Add(item.Key.Type);
				data.ItemCounts.Add(item.Value);
			}

			return data;
		}

		public bool Load(InventoryData data)
		{
			bool result = true;
			Clear();

			for (int i = 0; i < data.ItemTypes.Count; i++)
			{
				Item item = SaveSystem.Current.ItemDatabase.GetItem(data.ItemTypes[i]);
				if (item != null)
				{
					_items.Add(item, data.ItemCounts[i]);
				}
				else
				{
					// Esinettä ei löytynyt tietokannasta.
					result = false;
				}
			}

			return result;
		}

		// Toiminnallisuus:
		// 1. Lisääminen
		// 2. Poistaminen
		// 3. Tavaran haku
		// 3.1 Onko tavara olemassa
		// 4. Kokonaispaino
		// 5. Kokonaisarvo
	}
}
