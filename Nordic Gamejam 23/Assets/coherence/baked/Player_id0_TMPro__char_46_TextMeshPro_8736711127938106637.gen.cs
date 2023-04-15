// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
	using Coherence.ProtocolDef;
	using Coherence.Serializer;
	using Coherence.SimulationFrame;
	using Coherence.Entity;
	using Coherence.Utils;
	using Coherence.Brook;
	using Coherence.Toolkit;
	using UnityEngine;

	public struct Player_id0_TMPro__char_46_TextMeshPro_8736711127938106637 : ICoherenceComponentData
	{
		public string text;

		public override string ToString()
		{
			return $"Player_id0_TMPro__char_46_TextMeshPro_8736711127938106637(text: {text})";
		}

		public uint GetComponentType() => Definition.InternalPlayer_id0_TMPro__char_46_TextMeshPro_8736711127938106637;

		public const int order = 0;

		public int GetComponentOrder() => order;

		public AbsoluteSimulationFrame Frame;
	

		public void SetSimulationFrame(AbsoluteSimulationFrame frame)
		{
			Frame = frame;
		}

		public AbsoluteSimulationFrame GetSimulationFrame() => Frame;

		public ICoherenceComponentData MergeWith(ICoherenceComponentData data, uint mask)
		{
			var other = (Player_id0_TMPro__char_46_TextMeshPro_8736711127938106637)data;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				text = other.text;
			}
			mask >>= 1;
			return this;
		}

		public uint DiffWith(ICoherenceComponentData data)
		{
			throw new System.NotSupportedException($"{nameof(DiffWith)} is not supported in Unity");

		}

		public static void Serialize(Player_id0_TMPro__char_46_TextMeshPro_8736711127938106637 data, uint mask, IOutProtocolBitStream bitStream)
		{
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteShortString(data.text);
			}
			mask >>= 1;
		}

		public static (Player_id0_TMPro__char_46_TextMeshPro_8736711127938106637, uint, uint?) Deserialize(InProtocolBitStream bitStream)
		{
			var mask = (uint)0;
			var val = new Player_id0_TMPro__char_46_TextMeshPro_8736711127938106637();
	
			if (bitStream.ReadMask())
			{
				val.text = bitStream.ReadShortString();
				mask |= 0b00000000000000000000000000000001;
			}
			return (val, mask, null);
		}
		public static (Player_id0_TMPro__char_46_TextMeshPro_8736711127938106637, uint, uint?) DeserializeArchetypePlayer_a26d02a2f63fd174f8b2dce76dc412a9_Player_id0_TMPro__char_46_TextMeshPro_8736711127938106637_LOD0(InProtocolBitStream bitStream)
		{
			var mask = (uint)0;
			var val = new Player_id0_TMPro__char_46_TextMeshPro_8736711127938106637();
			if (bitStream.ReadMask())
			{
				val.text = bitStream.ReadShortString();
				mask |= 0b00000000000000000000000000000001;
			}

			return (val, mask, 0);
		}

		/// <summary>
		/// Resets byte array references to the local array instance that is kept in the lastSentData.
		/// If the array content has changed but remains of same length, the new content is copied into the local array instance.
		/// If the array length has changed, the array is cloned and overwrites the local instance.
		/// If the array has not changed, the reference is reset to the local array instance.
		/// Otherwise, changes to other fields on the component might cause the local array instance reference to become permanently lost.
		/// </summary>
		public void ResetByteArrays(ICoherenceComponentData lastSent, uint mask)
		{
			var last = lastSent as Player_id0_TMPro__char_46_TextMeshPro_8736711127938106637?;
	
		}
	}
}