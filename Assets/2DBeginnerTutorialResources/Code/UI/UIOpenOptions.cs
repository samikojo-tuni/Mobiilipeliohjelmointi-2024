using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Mobiiliesimerkki
{
	public class UIOpenOptions : MonoBehaviour
	{
		private Button _openButton;

		private void Awake()
		{
			_openButton = GetComponent<Button>();
		}

		private void OnEnable()
		{
			if (_openButton != null)
			{
				_openButton.onClick.AddListener(OpenOptions);
			}
		}

		private void OnDisable()
		{
			if (_openButton != null)
			{
				_openButton.onClick.RemoveListener(OpenOptions);
			}
		}

		private void OpenOptions()
		{
			LevelLoader.OpenOptions();
		}
	}
}
