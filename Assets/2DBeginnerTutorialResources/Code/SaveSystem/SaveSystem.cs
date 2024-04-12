using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;

namespace Mobiiliesimerkki
{
	public class SaveSystem : MonoBehaviour
	{
		private const string c_quickSaveSlot = "QuickSave";

		public static SaveSystem Current { get; private set; }

		[SerializeField]
		private ItemDatabase _itemDatabase = null;

		private Inputs _inputs;
		private DataStorage _dataStorage;

		public ItemDatabase ItemDatabase => _itemDatabase;

		private void Awake()
		{
			Current = this;

			_inputs = new Inputs();
			_dataStorage = new DataStorage();
		}

		private void OnEnable()
		{
			_inputs.Save.Enable();
			_inputs.Save.QuickSave.performed += OnQuickSave;
			_inputs.Save.QuickLoad.performed += OnQuickLoad;
		}

		private void OnDisable()
		{
			_inputs.Save.Disable();
			_inputs.Save.QuickSave.performed -= OnQuickSave;
			_inputs.Save.QuickLoad.performed -= OnQuickLoad;
		}

		private void OnQuickLoad(InputAction.CallbackContext context)
		{
			Load(c_quickSaveSlot);
		}

		private void OnQuickSave(InputAction.CallbackContext context)
		{
			Save(c_quickSaveSlot);
		}

		public void Save(string saveSlot)
		{
			ISaveable[] saveables = GetSaveables();

			GameData data = new GameData();
			foreach (ISaveable saveable in saveables)
			{
				saveable.Save(data);
			}

			_dataStorage.Save(saveSlot, data);
		}

		public bool Load(string saveSlot)
		{
			GameData data = _dataStorage.Load(saveSlot);
			if (data == null)
			{
				Debug.LogWarning($"Save slot {saveSlot} not found.");
				return false;
			}

			bool result = true;

			ISaveable[] saveables = GetSaveables();
			foreach (ISaveable saveable in saveables)
			{
				if (!saveable.Load(data))
				{
					result = false;
					Debug.LogWarning($"Failed to load data for {saveable.ID}");
					// TODO: Lataa olion oletusarvot!
				}
			}

			// Palautetaan false, jos yhdenkin olion lataus epäonnistui.
			return result;
		}

		private static ISaveable[] GetSaveables()
		{
			// TODO: Tehokkuuden kannalta ei paras ratkaisu, mutta toimii
			// tässä esimerkissä.
			ISaveable[] saveables =
				GameObject.FindObjectsOfType<MonoBehaviour>()
				.OfType<ISaveable>()
				.ToArray();

			return saveables;
		}
	}
}
