using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
	/// <summary>
	/// Hallinnoi pelihahmoa. Riippuvuudet: InputReader ja Mover.
	/// </summary>
	[RequireComponent(typeof(InputReader))]
	public class PlayerControl : MonoBehaviour
	{
		// Vakiot, näiden arvoa ei voi muuttaa ajon aikana.
		private const string SpeedAnimationParameter = "Speed";
		private const string DirectionXAnimationParameter = "DirectionX";
		private const string DirectionYAnimationParameter = "DirectionY";

		private InputReader _inputReader = null;
		private IMover _mover = null;
		private Animator _animator = null;
		// Piirtää hahmon näytölle.
		private SpriteRenderer _spriteRenderer = null;

		private void Awake()
		{
			// Alustetaan InputReader ja Mover Awake-metodissa.
			_inputReader = GetComponent<InputReader>();
			_mover = GetComponent<IMover>();
			_animator = GetComponent<Animator>();
			_spriteRenderer = GetComponent<SpriteRenderer>();
		}

		private void Update()
		{
			// Luetaan käyttäjä syöte
			Vector2 movement = _inputReader.Movement;
			_mover.Move(movement);
			UpdateAnimator(movement);
		}

		private void UpdateAnimator(Vector2 movement)
		{
			_animator.SetFloat(DirectionXAnimationParameter, movement.x);
			_animator.SetFloat(DirectionYAnimationParameter, movement.y);
			_animator.SetFloat(SpeedAnimationParameter, movement.sqrMagnitude);

			// Käännetään hahmoa, jos se liikkuu oikealle.
			bool lookRight = movement.x > 0;
			// Oikealle liikkuessa lookRight on true, jolloin voimme flipata
			// hahmon spriten x-akselin suhteen.
			_spriteRenderer.flipX = lookRight;
		}
	}
}
