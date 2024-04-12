using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Mobiiliesimerkki
{
	public class ItemSpawner : MonoBehaviour, ISaveable
	{
		// Kuinka usein uusi esine luodaan (sekunteina)
		[SerializeField, Tooltip("Kuinka usein esineitä luodaan (sekunteina)")]
		private float _spawnInterval = 1;

		[SerializeField, Tooltip("Satunnaisaika, joka lisätään spawn rateen")]
		private float _randomInterval = 0.5f;

		[SerializeField, Tooltip("Maksimimäärä spawnattavia esineitä")]
		private int _maxItems = 10;

		[SerializeField, Tooltip("Luotavan esineen sijainnin määrittävän ympyrän säde")]
		private float _spawnRadius = 5;

		[SerializeField, Tooltip("Esineen prefab")]
		private ItemVisual _itemPrefab = null;

		[SerializeField, Tooltip("Debug väri")]
		private Color _debugColor = Color.yellow;

		private float _spawnTimer = 0;
		private int _spawnedItemCount = 0;

		// Sisältää viittauksen kaikkiin spawnattuihin esineisiin.
		private List<ItemVisual> _spawnedItems = new List<ItemVisual>();

		[SerializeField]
		private string _id = null;

		public bool IsTimerRunning => _spawnTimer > 0;

		public string ID => _id;

		#region Unity Methods

		private void Start()
		{
			// Asetetaan ensimmäinen spawn timer.
			SetSpawnTimer();
		}

		private void Update()
		{
			if (IsTimerRunning)
			{
				// Päivitetään ajastin
				_spawnTimer -= Time.deltaTime;
				if (_spawnTimer <= 0)
				{
					// Ajastin nollautunut, luodaan uusi esine.
					SpawnItem();
					SetSpawnTimer();
				}
			}
		}

		private void OnDrawGizmos()
		{
			Gizmos.color = _debugColor;
			Gizmos.DrawWireSphere(transform.position, _spawnRadius);
		}

		#endregion Unity Methods

#if UNITY_EDITOR
		[ContextMenu("Generate ID")]
		private void GenerateID()
		{
			if (string.IsNullOrEmpty(_id))
			{
				_id = Guid.NewGuid().ToString();
			}
		}
#endif

		private ItemVisual SpawnItem()
		{
			// Määritetään esineelle sijainti
			Vector3 spawnPosition = transform.position + (Vector3)Random.insideUnitCircle * _spawnRadius;
			spawnPosition.z = 0; // Jos spawnerilla olikin z-koordinaatti

			// Varsinainen esineen luominen.
			// Quaternion.identity kappaletta ei ole rotatoitu.
			ItemVisual item = Instantiate(_itemPrefab, spawnPosition, Quaternion.identity);

			_spawnedItems.Add(item);
			item.SetSpawner(this);

			_spawnedItemCount++;

			return item;
		}

		private bool SetSpawnTimer()
		{
			if (_spawnedItemCount >= _maxItems)
			{
				// Maksimimäärä esineitä luotu, ei jatketa enää.
				return false;
			}

			_spawnTimer = _spawnInterval + Random.Range(-_randomInterval, _randomInterval);
			return true;
		}

		public void Save(GameData data)
		{
			List<ItemData> itemDatas = new List<ItemData>();
			foreach (ItemVisual itemVisual in _spawnedItems)
			{
				ItemData itemData = new ItemData()
				{
					Position = itemVisual.transform.position,
				};

				itemDatas.Add(itemData);
			}

			SpawnerData spawnerData = new SpawnerData()
			{
				ID = ID,
				SpawnTimer = _spawnTimer,
				SpawnedItemCount = _spawnedItemCount,
				SpawnedItems = itemDatas,
			};

			data.SpawnerData.Add(spawnerData);
		}

		public bool Load(GameData data)
		{
			// Poistetaan spawnarin luomat itemit scenestä ennen latausta.
			foreach (ItemVisual itemVisual in _spawnedItems)
			{
				Destroy(itemVisual.gameObject);
			}

			_spawnedItems.Clear();

			foreach (SpawnerData spawnerData in data.SpawnerData)
			{
				if (spawnerData.ID == ID)
				{
					_spawnTimer = spawnerData.SpawnTimer;

					foreach (ItemData itemData in spawnerData.SpawnedItems)
					{
						ItemVisual itemVisual = SpawnItem();
						itemVisual.transform.position = itemData.Position;
					}

					// TODO: Tämä ei ehkä ole siistein tapa toteuttaa ominaisuus.
					// Erillinen LoadItem, joka spawnaa ladatun itemin kasvattamatta _spawnedItemCount:ia
					// olisi parempi.
					_spawnedItemCount = spawnerData.SpawnedItemCount;
					return true;
				}
			}

			return false;
		}

		public void ItemCollected(ItemVisual itemVisual)
		{
			// Poistetaan kerätty esine listasta, jotta se ei tule tallennetuksi.
			_spawnedItems.Remove(itemVisual);
		}
	}
}
