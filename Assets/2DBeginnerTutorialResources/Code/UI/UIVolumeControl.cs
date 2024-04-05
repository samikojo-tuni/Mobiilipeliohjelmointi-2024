using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Audio;

namespace Mobiiliesimerkki
{
	public class UIVolumeControl : MonoBehaviour
	{
		[SerializeField] private TMP_Text _volumeText;
		[SerializeField] private Slider _volumeSlider;

		private AudioMixer _audioMixer; // Viittaus AudioMixeriin
		private string _volumeControlName;

		private void Awake()
		{
			if (_volumeSlider == null)
			{
				_volumeSlider = GetComponentInChildren<Slider>();
			}
		}

		private void OnEnable()
		{
			if (_volumeSlider != null)
			{
				_volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
			}
		}

		private void OnDisable()
		{
			if (_volumeSlider != null)
			{
				_volumeSlider.onValueChanged.RemoveListener(OnVolumeChanged);
			}
		}

		private void OnVolumeChanged(float linearVolume)
		{
			_volumeText.text = $"{Mathf.RoundToInt(linearVolume * 100)}%";
			// TODO: Pitäisikö äänenvoimakkuus asettaa jo tässä vaiheessa?
		}

		private float ToDB(float linearVolume)
		{
			return linearVolume <= 0 ? -80f : 20 * Mathf.Log10(linearVolume);
		}

		private float ToLinear(float dbVolume)
		{
			return Mathf.Clamp01(Mathf.Pow(10, dbVolume / 20f));
		}

		public void Setup(AudioMixer audioMixer, string volumeControlName)
		{
			_audioMixer = audioMixer;
			_volumeControlName = volumeControlName;

			if (_audioMixer.GetFloat(_volumeControlName, out float dbVolume))
			{
				// Muunnetaan äänenvoimakkuus decibeli-asteikolta lineaariseksi ja asetetaan arvo
				// sliderille.
				float linearVolume = ToLinear(dbVolume);
				_volumeSlider.value = linearVolume;
			}
		}

		public void SaveVolume()
		{
			float linearVolume = _volumeSlider.value;
			float dbVolume = ToDB(linearVolume);
			_audioMixer.SetFloat(_volumeControlName, dbVolume);
		}
	}
}
