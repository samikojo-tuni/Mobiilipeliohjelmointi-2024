using UnityEngine;

// Rajapinnan tiedoston (ja itse rajapinnan) nimi alkaa 
// aina isolla I kirjaimella.
namespace Mobiiliesimerkki
{
	/// <summary>
	/// Määrittelee liikkumisen rajapinnan.
	/// </summary>
	public interface IMover
	{
		/// <summary>
		/// Liikkumisnopeus.
		/// </summary>
		float Speed { get; }

		/// <summary>
		/// Liikuttaa peliobjektia annettuun suuntaan.
		/// </summary>
		/// <param name="direction">Liikkumissuunta.</param>
		void Move(Vector2 direction);
	}
}