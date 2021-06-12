using System;
using System.Collections.Generic;
using Verse;
using RimWorld;
using RimWorld.Planet;

namespace TurretAnimations
{
	public class Building_RecoiledTurret : Building_Artillery
	{
		public Building_RecoiledTurret()
		{
			top = (TurretTop)Activator.CreateInstance(typeof(TurretTop_Recoiled), new object[] { this });
		}

		protected TurretTop_Recoiled TopRecoiled => top as TurretTop_Recoiled;

		public virtual void Notify_Recoiled() => TopRecoiled.Notify_TurretRecoil();
	}
}
