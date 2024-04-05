using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Mobiiliesimerkki
{
	public class LevelManager : MonoBehaviour
	{
		[SerializeField] private AudioSource _musicSource = null;
		[SerializeField] private AudioMixer _mixer;
		[SerializeField] private string _musicVolumeName = "MusicVolume";
		[SerializeField] private string _sfxVolumeName = "SFXVolume";
		[SerializeField] private string _masterVolumeName = "MasterVolume";

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

			LoadVolumes();
		}

		private void LoadVolumes()
		{
			float dbMusicVolume = PlayerPrefs.GetFloat(_musicVolumeName, -6f);
			float dbSFXVolume = PlayerPrefs.GetFloat(_sfxVolumeName, -6f);
			float dbMasterVolume = PlayerPrefs.GetFloat(_masterVolumeName, -6f);

			_mixer.SetFloat(_musicVolumeName, dbMusicVolume);
			_mixer.SetFloat(_sfxVolumeName, dbSFXVolume);
			_mixer.SetFloat(_masterVolumeName, dbMasterVolume);
		}
	}
}
