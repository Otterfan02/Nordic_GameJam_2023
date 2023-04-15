// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using UnityEngine;
	using Coherence.Toolkit;
	using Coherence.Toolkit.Bindings;
	using Coherence.Entity;
	using Coherence.ProtocolDef;
	using Coherence.Brook;
	using Coherence.Toolkit.Bindings.ValueBindings;
	using Coherence.Toolkit.Bindings.TransformBindings;
	using Coherence.Connection;
	using Coherence.Log;
	using Logger = Coherence.Log.Logger;
	using UnityEngine.Scripting;

	public class Binding_a26d02a2f63fd174f8b2dce76dc412a9_cb3d3668_bcf8_4ed6_b786_d4bfab542896 : PositionBinding
	{
		public override string CoherenceComponentName => "WorldPosition";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override Vector3 Value
		{
			get => (Vector3)(UnityEngine.Vector3)(coherenceSync.coherencePosition);
			set => coherenceSync.coherencePosition = (UnityEngine.Vector3)(value);
		}

		protected override Vector3 ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (WorldPosition)coherenceComponent;
			return update.value;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (WorldPosition)coherenceComponent;
			update.value = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new WorldPosition();
		}
	}

	public class Binding_a26d02a2f63fd174f8b2dce76dc412a9_2123fbd0_5434_4d95_abe7_36d4b8f3c48c : RotationBinding
	{
		public override string CoherenceComponentName => "WorldOrientation";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override Quaternion Value
		{
			get => (Quaternion)(UnityEngine.Quaternion)(coherenceSync.coherenceRotation);
			set => coherenceSync.coherenceRotation = (UnityEngine.Quaternion)(value);
		}

		protected override Quaternion ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (WorldOrientation)coherenceComponent;
			return update.value;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (WorldOrientation)coherenceComponent;
			update.value = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new WorldOrientation();
		}
	}

	public class Binding_a26d02a2f63fd174f8b2dce76dc412a9_8f154625_edb0_4683_99df_09c9936bdb30 : FloatBinding
	{
		private PlayerScript CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (PlayerScript)UnityComponent;
		}
		public override string CoherenceComponentName => "Player_id0_PlayerScript_6943692034615545658";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override float Value
		{
			get => (float)(System.Single)(CastedUnityComponent.score);
			set => CastedUnityComponent.score = (System.Single)(value);
		}

		protected override float ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_PlayerScript_6943692034615545658)coherenceComponent;
			return update.score;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_PlayerScript_6943692034615545658)coherenceComponent;
			update.score = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Player_id0_PlayerScript_6943692034615545658();
		}
	}

	public class Binding_a26d02a2f63fd174f8b2dce76dc412a9_61787648_295c_40f5_9501_0b020b158aa3 : StringBinding
	{
		private PlayerScript CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (PlayerScript)UnityComponent;
		}
		public override string CoherenceComponentName => "Player_id0_PlayerScript_6943692034615545658";

		public override uint FieldMask => 0b00000000000000000000000000000010;

		public override string Value
		{
			get => (string)(System.String)(CastedUnityComponent.currentName);
			set => CastedUnityComponent.currentName = (System.String)(value);
		}

		protected override string ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_PlayerScript_6943692034615545658)coherenceComponent;
			return update.currentName;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_PlayerScript_6943692034615545658)coherenceComponent;
			update.currentName = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Player_id0_PlayerScript_6943692034615545658();
		}
	}

	public class Binding_a26d02a2f63fd174f8b2dce76dc412a9_7446d378_bd8d_47f8_bfaf_91eb8cdb7d5a : StringBinding
	{
		private TMPro.TextMeshPro CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (TMPro.TextMeshPro)UnityComponent;
		}
		public override string CoherenceComponentName => "Player_id0_TMPro__char_46_TextMeshPro_8736711127938106637";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override string Value
		{
			get => (string)(System.String)(CastedUnityComponent.text);
			set => CastedUnityComponent.text = (System.String)(value);
		}

		protected override string ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_TMPro__char_46_TextMeshPro_8736711127938106637)coherenceComponent;
			return update.text;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_TMPro__char_46_TextMeshPro_8736711127938106637)coherenceComponent;
			update.text = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Player_id0_TMPro__char_46_TextMeshPro_8736711127938106637();
		}
	}

	public class Binding_a26d02a2f63fd174f8b2dce76dc412a9_b3e7df05_2474_4f41_9985_f1a6df58df0e : DeepScaleBinding
	{
		private UnityEngine.Transform CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.Transform)UnityComponent;
		}
		public override string CoherenceComponentName => "Player_id0_UnityEngine__char_46_Transform_7700443003500183079";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override Vector3 Value
		{
			get => (Vector3)(UnityEngine.Vector3)(CastedUnityComponent.localScale);
			set => CastedUnityComponent.localScale = (UnityEngine.Vector3)(value);
		}

		protected override Vector3 ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_UnityEngine__char_46_Transform_7700443003500183079)coherenceComponent;
			return update.localScale;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_UnityEngine__char_46_Transform_7700443003500183079)coherenceComponent;
			update.localScale = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Player_id0_UnityEngine__char_46_Transform_7700443003500183079();
		}
	}


	[Preserve]
	[AddComponentMenu("coherence/Baked/Baked 'Player' (auto assigned)")]
	[RequireComponent(typeof(CoherenceSync))]
	public class CoherenceSyncPlayer_id0 : CoherenceSyncBaked
	{
		private CoherenceSync coherenceSync;
		private Logger logger;

		// Cached targets for commands		
		private PlayerScript Player_id0_PlayerScript__char_46_kill_f1269c51_4f2b_4e79_84a8_5f95b2752104_CommandTarget;

		private IClient client;
		private CoherenceMonoBridge monoBridge => coherenceSync.MonoBridge;

		protected void Awake()
		{
			coherenceSync = GetComponent<CoherenceSync>();
			coherenceSync.usingReflection = false;

			logger = coherenceSync.logger.With<CoherenceSyncPlayer_id0>();
			if (coherenceSync.TryGetBindingByGuid("f1269c51-4f2b-4e79-84a8-5f95b2752104", "kill", out Binding Player_id0_PlayerScript__char_46_kill_f1269c51_4f2b_4e79_84a8_5f95b2752104))
			{
				Player_id0_PlayerScript__char_46_kill_f1269c51_4f2b_4e79_84a8_5f95b2752104_CommandTarget = (PlayerScript)Player_id0_PlayerScript__char_46_kill_f1269c51_4f2b_4e79_84a8_5f95b2752104.UnityComponent;
				coherenceSync.AddCommandRequestDelegate("PlayerScript.kill", "()",
				SendCommand_Player_id0_PlayerScript__char_46_kill_f1269c51_4f2b_4e79_84a8_5f95b2752104, ReceiveLocalCommand_Player_id0_PlayerScript__char_46_kill_f1269c51_4f2b_4e79_84a8_5f95b2752104, MessageTarget.All, Player_id0_PlayerScript__char_46_kill_f1269c51_4f2b_4e79_84a8_5f95b2752104_CommandTarget,false);
			}
			else
			{
				logger.Error("Couldn't find command binding (kill)");
			}
			if (coherenceSync.TryGetBindingByGuid("cb3d3668-bcf8-4ed6-b786-d4bfab542896", "position", out Binding InternalWorldPosition_Translation_value))
			{
				var clone = new Binding_a26d02a2f63fd174f8b2dce76dc412a9_cb3d3668_bcf8_4ed6_b786_d4bfab542896();
				InternalWorldPosition_Translation_value.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalWorldPosition_Translation_value)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.Transform).position");
			}
			if (coherenceSync.TryGetBindingByGuid("2123fbd0-5434-4d95-abe7-36d4b8f3c48c", "rotation", out Binding InternalWorldOrientation_Rotation_value))
			{
				var clone = new Binding_a26d02a2f63fd174f8b2dce76dc412a9_2123fbd0_5434_4d95_abe7_36d4b8f3c48c();
				InternalWorldOrientation_Rotation_value.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalWorldOrientation_Rotation_value)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.Transform).rotation");
			}
			if (coherenceSync.TryGetBindingByGuid("8f154625-edb0-4683-99df-09c9936bdb30", "score", out Binding InternalPlayer_id0_PlayerScript_6943692034615545658_Player_id0_PlayerScript_6943692034615545658_score))
			{
				var clone = new Binding_a26d02a2f63fd174f8b2dce76dc412a9_8f154625_edb0_4683_99df_09c9936bdb30();
				InternalPlayer_id0_PlayerScript_6943692034615545658_Player_id0_PlayerScript_6943692034615545658_score.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalPlayer_id0_PlayerScript_6943692034615545658_Player_id0_PlayerScript_6943692034615545658_score)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (PlayerScript).score");
			}
			if (coherenceSync.TryGetBindingByGuid("61787648-295c-40f5-9501-0b020b158aa3", "currentName", out Binding InternalPlayer_id0_PlayerScript_6943692034615545658_Player_id0_PlayerScript_6943692034615545658_currentName))
			{
				var clone = new Binding_a26d02a2f63fd174f8b2dce76dc412a9_61787648_295c_40f5_9501_0b020b158aa3();
				InternalPlayer_id0_PlayerScript_6943692034615545658_Player_id0_PlayerScript_6943692034615545658_currentName.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalPlayer_id0_PlayerScript_6943692034615545658_Player_id0_PlayerScript_6943692034615545658_currentName)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (PlayerScript).currentName");
			}
			if (coherenceSync.TryGetBindingByGuid("7446d378-bd8d-47f8-bfaf-91eb8cdb7d5a", "text", out Binding InternalPlayer_id0_TMPro__char_46_TextMeshPro_8736711127938106637_Player_id0_TMPro__char_46_TextMeshPro_8736711127938106637_text))
			{
				var clone = new Binding_a26d02a2f63fd174f8b2dce76dc412a9_7446d378_bd8d_47f8_bfaf_91eb8cdb7d5a();
				InternalPlayer_id0_TMPro__char_46_TextMeshPro_8736711127938106637_Player_id0_TMPro__char_46_TextMeshPro_8736711127938106637_text.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalPlayer_id0_TMPro__char_46_TextMeshPro_8736711127938106637_Player_id0_TMPro__char_46_TextMeshPro_8736711127938106637_text)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (TMPro.TextMeshPro).text");
			}
			if (coherenceSync.TryGetBindingByGuid("b3e7df05-2474-4f41-9985-f1a6df58df0e", "localScale", out Binding InternalPlayer_id0_UnityEngine__char_46_Transform_7700443003500183079_Player_id0_UnityEngine__char_46_Transform_7700443003500183079_localScale))
			{
				var clone = new Binding_a26d02a2f63fd174f8b2dce76dc412a9_b3e7df05_2474_4f41_9985_f1a6df58df0e();
				InternalPlayer_id0_UnityEngine__char_46_Transform_7700443003500183079_Player_id0_UnityEngine__char_46_Transform_7700443003500183079_localScale.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalPlayer_id0_UnityEngine__char_46_Transform_7700443003500183079_Player_id0_UnityEngine__char_46_Transform_7700443003500183079_localScale)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.Transform).localScale");
			}
		}

		public override List<ICoherenceComponentData> CreateEntity()
		{
			if (coherenceSync.UsesLODsAtRuntime && (Archetypes.IndexForName.TryGetValue(coherenceSync.Archetype.ArchetypeName, out int archetypeIndex)))
			{
				var components = new List<ICoherenceComponentData>()
				{
					new ArchetypeComponent
					{
						index = archetypeIndex
					}
				};

				return components;
			}
			else
			{
				logger.Warning($"Unable to find archetype {coherenceSync.Archetype.ArchetypeName} in dictionary. Please, bake manually (coherence > Bake)");
			}

			return null;
		}

		public override void Initialize(CoherenceSync sync, IClient client)
		{
			if (coherenceSync == null)
			{
				coherenceSync = sync;
			}
			this.client = client;
		}
		void SendCommand_Player_id0_PlayerScript__char_46_kill_f1269c51_4f2b_4e79_84a8_5f95b2752104(MessageTarget target, object[] args)
		{
			var command = new Player_id0_PlayerScript__char_46_kill_f1269c51_4f2b_4e79_84a8_5f95b2752104();
			client.SendCommand(command, target, coherenceSync.EntityID);
		}

		void ReceiveLocalCommand_Player_id0_PlayerScript__char_46_kill_f1269c51_4f2b_4e79_84a8_5f95b2752104(MessageTarget target, object[] args)
		{
			var command = new Player_id0_PlayerScript__char_46_kill_f1269c51_4f2b_4e79_84a8_5f95b2752104();
			ReceiveCommand_Player_id0_PlayerScript__char_46_kill_f1269c51_4f2b_4e79_84a8_5f95b2752104(command);
		}

		void ReceiveCommand_Player_id0_PlayerScript__char_46_kill_f1269c51_4f2b_4e79_84a8_5f95b2752104(Player_id0_PlayerScript__char_46_kill_f1269c51_4f2b_4e79_84a8_5f95b2752104 command)
		{
			var target = Player_id0_PlayerScript__char_46_kill_f1269c51_4f2b_4e79_84a8_5f95b2752104_CommandTarget;
			target.kill();
		}

		public override void ReceiveCommand(IEntityCommand command)
		{
			switch(command)
			{
				case Player_id0_PlayerScript__char_46_kill_f1269c51_4f2b_4e79_84a8_5f95b2752104 castedCommand:
					ReceiveCommand_Player_id0_PlayerScript__char_46_kill_f1269c51_4f2b_4e79_84a8_5f95b2752104(castedCommand);
					break;
				default:
					logger.Warning($"[CoherenceSyncPlayer_id0] Unhandled command: {command.GetType()}.");
					break;
			}
		}
	}
}
