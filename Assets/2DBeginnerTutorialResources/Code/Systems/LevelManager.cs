using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
	public class LevelManager : MonoBehaviour
	{
		[SerializeField] private AudioSource _musicSource = null;

		private void Awake()
		{
			if (_musicSource == null)
			{
				_musicSource = GetComponent<AudioSource>();
				_musicSource.loop = true; // Musiikki looppaa
			}
		}

		private void Start()
		{
			if (_musicSource != null && !_musicSource.isPlaying)
			{
				_musicSource.Play();
			}
		}
	}
}
