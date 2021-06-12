﻿using UnityEngine;
using Verse;

namespace TurretAnimations
{
	public class MoteThrownExpand : MoteThrown
	{
		public float growthRate;

		public override void Tick()
		{
			base.Tick();
			exactScale += new Vector3(growthRate, 0, growthRate);
		}
	}
}
