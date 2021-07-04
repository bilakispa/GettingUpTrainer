
using System.Collections.Generic;
using System.Configuration;

namespace GettingUpTrainer
{
	[SettingsSerializeAs(SettingsSerializeAs.Xml)]
	public class PlayerPosition
	{
		public string Name { get; set; }
		public string PositionX { get; set; }
		public string PositionY { get; set; }
		public string PositionZ { get; set; }
	}

	[SettingsSerializeAs(SettingsSerializeAs.Xml)]
	public class PlayerPositionCollection
	{
		public List<PlayerPosition> PlayerPositions { get; set; }
		public PlayerPositionCollection()
		{
			PlayerPositions = new List<PlayerPosition>();
		}
	}
}
