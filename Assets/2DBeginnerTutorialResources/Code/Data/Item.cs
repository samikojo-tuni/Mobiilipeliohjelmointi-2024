using UnityEngine;

namespace Mobiiliesimerkki
{
	[CreateAssetMenu(fileName = "NewItem", menuName = "Inventory/Item")]
	public class Item : ScriptableObject
	{
		[SerializeField] private ItemType _type = ItemType.None;
		[SerializeField] private int _value = 0;
		[SerializeField] private string _name = "";
		[SerializeField] private float _weight = 0;
		[SerializeField] private bool _isKeyItem = false;
		// Tätä käytetään UI:lla kuvaamaan objektia.
		[SerializeField] private Sprite _sprite = null;

		public ItemType Type => _type;

		public int Value
		{
			get { return _value; }
		}

		public string Name
		{
			get { return _name; }
		}

		public float Weight
		{
			get { return _weight; }
		}

		public bool IsKeyItem
		{
			get { return _isKeyItem; }
		}

		public Sprite Sprite
		{
			get { return _sprite; }
		}
	}
}