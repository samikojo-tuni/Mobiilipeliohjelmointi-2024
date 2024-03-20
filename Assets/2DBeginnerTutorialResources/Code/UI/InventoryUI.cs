using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;

namespace Mobiiliesimerkki.UI
{
	public class InventoryUI : MonoBehaviour
	{
		[SerializeField] private InventoryUIItem _inventoryUIItemPrefab = null;

		[SerializeField] private int _slots = 8;

		// Transform, jonka alle InventoryUIItemit luodaan
		[SerializeField] private Transform _contentParent = null;
		[SerializeField] private LocalizeStringEvent[] _localizedStrings = null;

		private InventoryUIItem[] _inventoryUIItems = null;
		private Inventory _inventory = null;

		public float Weight
		{
			get
			{
				if (_inventory != null)
				{
					return _inventory.GetWeight();
				}
				return 0;
			}
		}

		public float MaxWeight
		{
			get
			{
				if (_inventory != null)
				{
					return _inventory.MaxWeight;
				}
				return 0;
			}
		}

		public float Value
		{
			get
			{
				if (_inventory != null)
				{
					return _inventory.GetValue();
				}
				return 0;
			}
		}

		private void Awake()
		{
			// Jos toteuttaisimme sivutuksen, tämä voisi olla toteutettu toisin
			_inventoryUIItems = new InventoryUIItem[_slots];
			for (int i = 0; i < _slots; i++)
			{
				_inventoryUIItems[i] = Instantiate(_inventoryUIItemPrefab, _contentParent);
			}

			_localizedStrings = GetComponentsInChildren<LocalizeStringEvent>(includeInactive: true);
		}

		public void SetInventory(Inventory inventory)
		{
			_inventory = inventory;
			UpdateUI();
		}

		public void UpdateUI()
		{
			foreach ((Item item, uint count) inventoryItem in _inventory.GetItems())
			{
				InventoryUIItem uiItem = GetItem(inventoryItem.item.Type);
				if (uiItem != null)
				{
					uiItem.SetItem(inventoryItem.item, inventoryItem.count);
				}
			}

			foreach (LocalizeStringEvent localizeEvent in _localizedStrings)
			{
				localizeEvent.RefreshString();
			}
		}

		private InventoryUIItem GetItem(ItemType itemType)
		{
			foreach (InventoryUIItem uiItem in _inventoryUIItems)
			{
				Item item = uiItem.GetItem();
				if (item != null && item.Type == itemType)
				{
					return uiItem;
				}
			}

			// Parametria vastaavaa itemiä ei löydy UI:lta, palautetaan ensimmäinen tyhjä
			// InventoryUIItem-olio.
			foreach (InventoryUIItem uIItem in _inventoryUIItems)
			{
				if (uIItem.GetItem() == null)
				{
					return uIItem;
				}
			}

			// InventoryUI on täynnä.
			return null;
		}
	}
}
