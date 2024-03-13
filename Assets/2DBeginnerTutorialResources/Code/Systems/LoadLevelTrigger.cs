using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
	public class LoadLevelTrigger : MonoBehaviour
	{
		[SerializeField, Tooltip("Tason nimi, joka ladataan")]
		private string _levelName = "Level1";

		private void OnTriggerEnter2D(Collider2D collision)
		{
			// Tarkistetaan, että törmääjä on pelaaja
			if (collision.CompareTag("Player"))
			{
				// Ladataan uusi taso
				LevelLoader.LoadLevel(_levelName);
			}
		}
	}
}
