using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
	/// <summary>
	/// Tämä skripti vaihtaa spriten väriä.
	/// </summary>
	public class ColourChanger : MonoBehaviour
	{
		// Luokan jäsenmuuttujat

		// Kurssin nimeämiskäytännön mukaisesti jäsenmuuttujat merkataan alaviivalla _.
		// Viittaus SpriteRenderer-komponenttiin.
		private SpriteRenderer _spriteRenderer;

		/// <summary>
		/// SerializeField-attribuuttia käyttämällä muuttujan arvo voidaan asettaa Unityssä.
		/// Taulukko [] sisältää useita arvoja. Tässä tapauksessa kunkin arvon tyyppi on Color.
		/// </summary>
		[SerializeField]
		private Color[] _colours;

		/// <summary>
		/// Start-metodia kutsutaan, kun peliobjekti luodaan (juuri ennen ensimmäistä Update-kutsua).
		/// Sitä voidaan käyttää rakentajan tapaan olion alustamiseen.
		/// </summary>
		void Start()
		{
			// Haetaan viittaus SpriteRenderer-komponenttiin.
			// GetCompoment palauttaa tässä GameObjectissa olevan SpriteRenderer-komponentin.
			// Jos GameObjectissa ei ole SpriteRenderer-komponenttia, palautetaan null.
			_spriteRenderer = GetComponent<SpriteRenderer>();

			// Asettaa listan ensimmäisen värin aloitusväriksi.
			_spriteRenderer.color = _colours[0];
		}

		/// <summary>
		/// Update-metodia kutsutaan kerran framea kohti. Pelilogiikka toteutetaan pääasiassa Update-metodien
		/// avulla. Update-metodi kutsutaan aina ennen kuin piirretään uusi frame. Esimerkiksi olioiden
		/// liikuttaminen voidaan toteuttaa Updatessa.
		/// </summary>
		void Update()
		{
			// Vaihdetaan väriä sekunnin välein. Tähän voidaan käyttää jakojäännöstä (% eli modulo-operaattori).
			// Jakojäännös palauttaa jakolaskun jäljelle jäävän osan.
			// Esimerkiksi 5 % 2 = 1, koska 5 / 2 = 2 ja 1 jää jäljelle.

			// Asetetaan uusi väri. Väri valitaan taulukosta käyttämällä jakojäännöstä Time.time-muuttujasta.
			// Jakojäännös palauttaa arvon 0, 1 tai 2. Taulukon indeksit alkavat nollasta, joten
			// taulukon arvot ovat 0, 1 ja 2.

			int index = (int)(Time.time % _colours.Length);
			_spriteRenderer.color = _colours[index];
		}
	}
}