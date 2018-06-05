using Terraria.ModLoader;

namespace Uselessmod
{
	class Uselessmod : Mod
	{
		public Uselessmod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
