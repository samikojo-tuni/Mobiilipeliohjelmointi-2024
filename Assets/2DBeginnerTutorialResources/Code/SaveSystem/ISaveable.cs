using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
	public interface ISaveable
	{
		string ID { get; }
		void Save(GameData data);
		bool Load(GameData data);
	}
}
