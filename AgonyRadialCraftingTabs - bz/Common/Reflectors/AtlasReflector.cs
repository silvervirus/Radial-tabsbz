// Decompiled with JetBrains decompiler
// Type: Agony.Common.Reflectors.AtlasReflector
// Assembly: AgonyRadialCraftingTabs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08DEA013-3B49-433F-9CD8-15D25EADC5F0
// Assembly location: C:\Users\pred1\Desktop\RadialTabs\AgonyRadialCraftingTabs.dll

using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Agony.Common.Reflectors
{
	// Token: 0x02000008 RID: 8
	internal static class AtlasReflector
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002385 File Offset: 0x00000585
		public static string GetAtlasname( Sprite sprite)
		{
			if (sprite == null)
			{
				throw new ArgumentNullException("sprite is null");
			}
			return (string)AtlasReflector.nameFieldInfo.GetValue(sprite);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000023AB File Offset: 0x000005AB
		public static List<SerialData> GetSerialData(Sprite sprite)
		{
			if (sprite == null)
			{
				throw new ArgumentNullException("atlas is null");
			}
			return (List<SerialData>)AtlasReflector.serialDataFieldInfo.GetValue(sprite);
		}

		// Token: 0x04000001 RID: 1
		private static readonly FieldInfo serialDataFieldInfo = typeof(Sprite).GetField("serialData", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x04000002 RID: 2
		private static readonly FieldInfo nameFieldInfo = typeof(Sprite).GetField("atlasName", BindingFlags.Instance | BindingFlags.NonPublic);
	}
}
