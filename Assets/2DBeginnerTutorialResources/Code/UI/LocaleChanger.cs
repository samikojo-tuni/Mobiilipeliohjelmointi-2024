using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

namespace Mobiiliesimerkki.UI
{
	public class LocaleChanger : MonoBehaviour
	{
		[SerializeField] private Locale _locale = null;

		public void Apply()
		{
			if (_locale != null)
			{
				LocalizationSettings.SelectedLocale = _locale;
			}
		}
	}
}
