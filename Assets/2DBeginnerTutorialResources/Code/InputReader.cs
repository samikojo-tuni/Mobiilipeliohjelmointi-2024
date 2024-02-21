using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
	public class InputReader : MonoBehaviour
	{
		public enum InputType
		{
			VirtualJoystick,
			Touch
		}

		[SerializeField] private InputType _inputType = InputType.VirtualJoystick;

		private Inputs _inputs = null;
		private Vector2 _movementInput = Vector2.zero;
		private bool _interactInput = false;

		// Tappauksen sijainti maailman koordinaatistossa.
		private Vector3 _tapWorldPosition = Vector3.zero;

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
			if (_inputType == InputType.Touch)
			{
				_inputs.TapControl.Enable();
			}
		}

		private void OnDisable()
		{
			// Deaktivoidaan input OnDisablessa, eli kun objekti deaktivoituu
			_inputs.Game.Disable();
			if (_inputType == InputType.Touch)
			{
				_inputs.TapControl.Disable();
			}
		}

		// Luetaan inputin arvo jokaisella framella
		private void Update()
		{
			switch (_inputType)
			{
				case InputType.VirtualJoystick:
					_movementInput = _inputs.Game.Move.ReadValue<Vector2>();
					break;
				case InputType.Touch:
					if (_inputs.TapControl.Move.WasPerformedThisFrame())
					{
						// 1. Lue tappauksen koordinaatti näytön koordinaatistossa.
						Vector2 tapPosition = _inputs.TapControl.Move.ReadValue<Vector2>();

						// 2. Muunna luettu koordinaatti pelimaailman koordinaatistoon.
						_tapWorldPosition = Camera.main.ScreenToWorldPoint(tapPosition);
						_tapWorldPosition.z = 0;
					}

					// 3. Laske suuntavektori tappauksen ja hahmon välillä.
					Vector3 toTarget = _tapWorldPosition - transform.position;
					if (toTarget.sqrMagnitude < 0.1f) // TODO: Taikanumero, korjaa tämä!
					{
						_movementInput = Vector2.zero;
					}
					else
					{
						_movementInput = toTarget.normalized;
					}
					break;
			}
		}
	}
}