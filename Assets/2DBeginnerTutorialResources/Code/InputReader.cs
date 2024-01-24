using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
	public class InputReader : MonoBehaviour
	{
		private Inputs _inputs = null;
		private Vector2 _movementInput = Vector2.zero;
		private bool _interactInput = false;

		/// <summary>
		/// C#:n properetyt korvaavat mm. Javan getterit ja setterit.
		/// Property näyttää käyttäjälle muuttujalta, mutta se käyttäytyy
		/// kuin get ja set metodit.
		/// </summary>
		public Vector2 Movement
		{
			get { return _movementInput; }
		}

		private void Awake()
		{
			// Alustetaan Inputs-olio Awakessa luomalla new:llä uusi Inputs-olio.
			_inputs = new Inputs();
		}

		private void OnEnable()
		{
			// Aktivoidaan input OnEnablessa, eli kun objekti aktivoituu
			_inputs.Game.Enable();
		}

		private void OnDisable()
		{
			// Deaktivoidaan input OnDisablessa, eli kun objekti deaktivoituu
			_inputs.Game.Disable();
		}

		// Luetaan inputin arvo jokaisella framella
		private void Update()
		{
			_movementInput = _inputs.Game.Move.ReadValue<Vector2>();

			// TODO: Lue interaktio-inputin arvo (eventti)
		}
	}
}