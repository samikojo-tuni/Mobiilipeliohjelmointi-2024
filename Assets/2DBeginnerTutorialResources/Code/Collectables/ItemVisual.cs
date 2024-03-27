using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
	public class ItemVisual : MonoBehaviour
	{
		// Viittaus Item-ScriptableObjectiin projektissa.
		[SerializeField] private Item _item = null;
		[SerializeField] private ParticleSystem _collectEffectPrefab = null;

		private AudioSource _collectSFX = null;
		private Renderer _renderer = null;
		private Collider2D _collider = null;

		public Item Item => _item;

		private void Awake()
		{
			_collectSFX = GetComponent<AudioSource>();
			_renderer = GetComponent<Renderer>();
			_collider = GetComponent<Collider2D>();
		}

		public void Collect()
		{
			_renderer.enabled = false;
			_collider.enabled = false;

			float delay = 0;
			if (_collectSFX != null)
			{
				_collectSFX.Play();
				delay = _collectSFX.clip.length;
			}

			if (_collectEffectPrefab != null)
			{
				ParticleSystem effect = Instantiate(_collectEffectPrefab, transform.position, Quaternion.identity);
				delay = Mathf.Max(delay, effect.main.duration);
				effect.Play(withChildren: true);
				Destroy(effect.gameObject, delay); // Muista tuhota myös efekti.
			}

			// Tuhotaan kerättävä esine.
			Destroy(gameObject, delay);
		}
	}
}
