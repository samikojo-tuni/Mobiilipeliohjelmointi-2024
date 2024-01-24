using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
	/// <summary>
	/// Hallinnoi pelihahmoa. Riippuvuudet: InputReader ja Mover.
	/// </summary>
	[RequireComponent(typeof(InputReader), typeof(Mover))]
	public class PlayerControl : MonoBehaviour
	{
		private InputReader _inputReader = null;
		private Mover _mover = null;

		private void Awake()
		{
			// Alustetaan InputReader ja Mover Awake-metodissa.
			_inputReader = GetComponent<InputReader>();
			_mover = GetComponent<Mover>();
		}

		private void Update()
		{
			// Luetaan käyttäjä syöte
			Vector2 movement = _inputReader.Movement;
			_mover.Move(movement);
		}
	}
}
