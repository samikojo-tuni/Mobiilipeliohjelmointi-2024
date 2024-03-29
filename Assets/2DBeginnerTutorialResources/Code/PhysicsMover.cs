using UnityEngine;

namespace Mobiiliesimerkki
{
	public class PhysicsMover : MonoBehaviour, IMover
	{
		[SerializeField]
		private float _speed = 1;

		private Rigidbody2D _rigidbody2D = null;

		public float Speed => _speed;

		private void Awake()
		{
			_rigidbody2D = GetComponent<Rigidbody2D>();
		}

		public void Move(Vector2 direction)
		{
			_rigidbody2D.velocity = direction * _speed;
		}
	}
}