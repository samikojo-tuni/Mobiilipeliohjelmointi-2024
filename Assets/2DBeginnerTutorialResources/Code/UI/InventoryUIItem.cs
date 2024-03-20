using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Mobiiliesimerkki.UI
{
	public class InventoryUIItem : MonoBehaviour
	{
		// Viittaus kuvakkeesseen
		private Image _image = null;
		// Viittaus tekstiin
		private TMP_Text _text = null;
		// Viittaus Itemiin
		private Item _item = null;

		private void Awake()
		{
			_image = GetComponent<Image>();
			_text = GetComponentInChildren<TMP_Text>(includeInactive: true);
			_text.gameObject.SetActive(false);
		}

		public void SetItem(Item item, uint amount)
		{
			_text.gameObject.SetActive(true);
			_item = item;
			_image.sprite = item.Sprite;
			_text.text = amount.ToString();
		}

		public Item GetItem()
		{
			return _item;
		}

		public ItemType GetItemType()
		{
			return _item.Type;
		}
	}
}
