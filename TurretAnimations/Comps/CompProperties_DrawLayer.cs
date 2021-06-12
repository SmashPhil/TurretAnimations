﻿using System;
using System.Collections.Generic;
using System.Linq;
using Verse;
using SmashTools;

namespace TurretAnimations
{
	public class CompProperties_DrawLayer : CompProperties
	{
		public List<GraphicData> graphicDatas;

		public CompProperties_DrawLayer()
		{
			compClass = typeof(CompDrawLayer);
		}

		public override IEnumerable<string> ConfigErrors(ThingDef parentDef)
		{
			foreach (string error in base.ConfigErrors(parentDef))
			{
				yield return error;
			}

			if (graphicDatas.NullOrEmpty())
			{
				yield return "<field>graphicDatas</field> must be populated.".ConvertRichText();
			}
		}
	}
}
