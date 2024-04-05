using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Mobiiliesimerkki
{
	public class UIOptionsWindow : MonoBehaviour
	{
		[SerializeField] private AudioMixer _audioMixer;
		[SerializeField] private UIVolumeControl _masterVolumeControl;
		[SerializeField] private UIVolumeControl _musicVolumeControl;
		[SerializeField] private UIVolumeControl _sfxVolumeControl;
		[SerializeField] private string _masterVolumeName = "MasterVolume";
		[SerializeField] private string _musicVolumeName = "MusicVolume";
		[SerializeField] private string _sfxVolumeName = "SFXVolume";
		[SerializeField] private Button _okButton;
		[SerializeField] private Button _cancelButton;

		private void Start()
		{
			_masterVolumeControl.Setup(_audioMixer, _masterVolumeName);
			_musicVolumeControl.Setup(_audioMixer, _musicVolumeName);
			_sfxVolumeControl.Setup(_audioMixer, _sfxVolumeName);
		}

		private void OnEnable()
		{
			// OK-nappi tallentaa äänenvoimakkuudet ja sulkee ikkunan
			_okButton.onClick.AddListener(Save);
			_okButton.onClick.AddListener(Close);

			// Cancel-nappi sulkee ikkunan
			_cancelButton.onClick.AddListener(Close);
		}

		private void OnDisable()
		{
			_okButton.onClick.RemoveListener(Save);
			_okButton.onClick.RemoveListener(Close);

			_cancelButton.onClick.RemoveListener(Close);
		}

		public void Save()
		{
			_masterVolumeControl.SaveVolume();
			_musicVolumeControl.SaveVolume();
			_sfxVolumeControl.SaveVolume();

			SaveVolume(_masterVolumeName);
			SaveVolume(_musicVolumeName);
			SaveVolume(_sfxVolumeName);
		}

		private void SaveVolume(string volumeName)
		{
			if (_audioMixer.GetFloat(volumeName, out float dbVolume))
			{
				PlayerPrefs.SetFloat(volumeName, dbVolume);
			}
		}

		public void Close()
		{
			LevelLoader.CloseOptions();
		}
	}
}
