using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
	public class Mover : MonoBehaviour
	{
		[SerializeField]
		private float _speed = 1.0f;

		public void Move(Vector2 direction)
		{
			// transform on oikotie tämän GameObjectin Transform-komponenttiin.
			// transform.position kuvaa peliobjektin sijaintia pelimaailmassa.
			// Sijainnin ovat aina kolmeuloitteisia, vaikka peli olisi
			// kaksiulotteinen.
			Vector3 position = transform.position;
			position += new Vector3(direction.x, direction.y, 0) * _speed * Time.deltaTime;
			transform.position = position;
		}
	}
}
