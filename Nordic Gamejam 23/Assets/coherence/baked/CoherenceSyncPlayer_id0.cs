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

	public class Binding_a26d02a2f63fd174f8b2dce76dc412a9_50ca12a8_ee0c_438e_af08_c3e195235967 : FloatBinding
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
			get => (float)(System.Single)(CastedUnityComponent.currentHeat);
			set => CastedUnityComponent.currentHeat = (System.Single)(value);
		}

		protected override float ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_PlayerScript_6943692034615545658)coherenceComponent;
			return update.currentHeat;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_PlayerScript_6943692034615545658)coherenceComponent;
			update.currentHeat = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Player_id0_PlayerScript_6943692034615545658();
		}
	}

	public class Binding_a26d02a2f63fd174f8b2dce76dc412a9_40c11705_0906_4e79_8c09_15f33251cdc7 : FloatBinding
	{
		private PlayerScript CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (PlayerScript)UnityComponent;
		}
		public override string CoherenceComponentName => "Player_id0_PlayerScript_6943692034615545658";

		public override uint FieldMask => 0b00000000000000000000000000000010;

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

	public class Binding_a26d02a2f63fd174f8b2dce76dc412a9_210a7214_5506_4986_bf42_cba07389c73b : Vector2Binding
	{
		private UnityEngine.Rigidbody2D CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.Rigidbody2D)UnityComponent;
		}
		public override string CoherenceComponentName => "Player_id0_UnityEngine__char_46_Rigidbody2D_9221523111977080189";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override Vector2 Value
		{
			get => (Vector2)(UnityEngine.Vector2)(CastedUnityComponent.velocity);
			set => CastedUnityComponent.velocity = (UnityEngine.Vector2)(value);
		}

		protected override Vector2 ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_UnityEngine__char_46_Rigidbody2D_9221523111977080189)coherenceComponent;
			return update.velocity;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_UnityEngine__char_46_Rigidbody2D_9221523111977080189)coherenceComponent;
			update.velocity = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Player_id0_UnityEngine__char_46_Rigidbody2D_9221523111977080189();
		}
	}

	public class Binding_a26d02a2f63fd174f8b2dce76dc412a9_911f1a0f_9151_49b9_a648_b95e3177be63 : FloatBinding
	{
		private UnityEngine.Rigidbody2D CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.Rigidbody2D)UnityComponent;
		}
		public override string CoherenceComponentName => "Player_id0_UnityEngine__char_46_Rigidbody2D_9221523111977080189";

		public override uint FieldMask => 0b00000000000000000000000000000010;

		public override float Value
		{
			get => (float)(System.Single)(CastedUnityComponent.gravityScale);
			set => CastedUnityComponent.gravityScale = (System.Single)(value);
		}

		protected override float ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_UnityEngine__char_46_Rigidbody2D_9221523111977080189)coherenceComponent;
			return update.gravityScale;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_UnityEngine__char_46_Rigidbody2D_9221523111977080189)coherenceComponent;
			update.gravityScale = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Player_id0_UnityEngine__char_46_Rigidbody2D_9221523111977080189();
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
		private InputBuffer<Player> inputBuffer;
		private Player currentInput;
		private long lastAddedFrame = -1;
		private CoherenceInput coherenceInput;
		private long currentSimulationFrame => coherenceInput.CurrentSimulationFrame;

		private IClient client;
		private CoherenceMonoBridge monoBridge => coherenceSync.MonoBridge;

		protected void Awake()
		{
			coherenceSync = GetComponent<CoherenceSync>();
			coherenceSync.usingReflection = false;

			logger = coherenceSync.logger.With<CoherenceSyncPlayer_id0>();
			coherenceInput = coherenceSync.Input;
			inputBuffer = new InputBuffer<Player>(coherenceInput.InitialBufferSize, coherenceInput.InitialBufferDelay, coherenceInput.UseFixedSimulationFrames);
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
			if (coherenceSync.TryGetBindingByGuid("50ca12a8-ee0c-438e-af08-c3e195235967", "currentHeat", out Binding InternalPlayer_id0_PlayerScript_6943692034615545658_Player_id0_PlayerScript_6943692034615545658_currentHeat))
			{
				var clone = new Binding_a26d02a2f63fd174f8b2dce76dc412a9_50ca12a8_ee0c_438e_af08_c3e195235967();
				InternalPlayer_id0_PlayerScript_6943692034615545658_Player_id0_PlayerScript_6943692034615545658_currentHeat.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalPlayer_id0_PlayerScript_6943692034615545658_Player_id0_PlayerScript_6943692034615545658_currentHeat)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (PlayerScript).currentHeat");
			}
			if (coherenceSync.TryGetBindingByGuid("40c11705-0906-4e79-8c09-15f33251cdc7", "score", out Binding InternalPlayer_id0_PlayerScript_6943692034615545658_Player_id0_PlayerScript_6943692034615545658_score))
			{
				var clone = new Binding_a26d02a2f63fd174f8b2dce76dc412a9_40c11705_0906_4e79_8c09_15f33251cdc7();
				InternalPlayer_id0_PlayerScript_6943692034615545658_Player_id0_PlayerScript_6943692034615545658_score.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalPlayer_id0_PlayerScript_6943692034615545658_Player_id0_PlayerScript_6943692034615545658_score)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (PlayerScript).score");
			}
			if (coherenceSync.TryGetBindingByGuid("210a7214-5506-4986-bf42-cba07389c73b", "velocity", out Binding InternalPlayer_id0_UnityEngine__char_46_Rigidbody2D_9221523111977080189_Player_id0_UnityEngine__char_46_Rigidbody2D_9221523111977080189_velocity))
			{
				var clone = new Binding_a26d02a2f63fd174f8b2dce76dc412a9_210a7214_5506_4986_bf42_cba07389c73b();
				InternalPlayer_id0_UnityEngine__char_46_Rigidbody2D_9221523111977080189_Player_id0_UnityEngine__char_46_Rigidbody2D_9221523111977080189_velocity.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalPlayer_id0_UnityEngine__char_46_Rigidbody2D_9221523111977080189_Player_id0_UnityEngine__char_46_Rigidbody2D_9221523111977080189_velocity)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.Rigidbody2D).velocity");
			}
			if (coherenceSync.TryGetBindingByGuid("911f1a0f-9151-49b9-a648-b95e3177be63", "gravityScale", out Binding InternalPlayer_id0_UnityEngine__char_46_Rigidbody2D_9221523111977080189_Player_id0_UnityEngine__char_46_Rigidbody2D_9221523111977080189_gravityScale))
			{
				var clone = new Binding_a26d02a2f63fd174f8b2dce76dc412a9_911f1a0f_9151_49b9_a648_b95e3177be63();
				InternalPlayer_id0_UnityEngine__char_46_Rigidbody2D_9221523111977080189_Player_id0_UnityEngine__char_46_Rigidbody2D_9221523111977080189_gravityScale.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalPlayer_id0_UnityEngine__char_46_Rigidbody2D_9221523111977080189_Player_id0_UnityEngine__char_46_Rigidbody2D_9221523111977080189_gravityScale)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.Rigidbody2D).gravityScale");
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
		private void OnDestroy()
		{
			if (monoBridge != null)
			{
				monoBridge.OnLateFixedNetworkUpdate -= SendInputState;
			}
		}

		public override void Initialize(CoherenceSync sync, IClient client)
		{
			if (coherenceSync == null)
			{
				coherenceSync = sync;
			}
			this.client = client;
			sync.Input.internalSetButtonState = SetButtonState;
			sync.Input.internalSetButtonRangeState = SetButtonRangeState;
			sync.Input.internalSetAxisState = SetAxisState;
			sync.Input.internalSetStringState = SetStringState;
			sync.Input.internalGetButtonState = GetButtonState;
			sync.Input.internalGetButtonRangeState = GetButtonRangeState;
			sync.Input.internalGetAxisState = GetAxisState;
			sync.Input.internalGetStringState = GetStringState;
			sync.Input.internalRequestBuffer = () => inputBuffer;
			sync.Input.internalOnInputReceived += OnInput;
			sync.Input.internalRequestBuffer = () => inputBuffer;

			if (coherenceInput.UseFixedSimulationFrames)
			{
				sync.MonoBridge.OnLateFixedNetworkUpdate += SendInputState;
			}
		}

		public override void ReceiveCommand(IEntityCommand command)
		{
			switch(command)
			{
				default:
					logger.Warning($"[CoherenceSyncPlayer_id0] Unhandled command: {command.GetType()}.");
					break;
			}
		}

		private void SetButtonState(string name, bool value)
		{
			switch(name)
			{
				default:
					logger.Error($"No input button of name: {name}");
					break;
			}
		}

		private void SetButtonRangeState(string name, float value)
		{
			switch(name)
			{
			default:
				logger.Error($"No input button range of name: {name}");
				break;
			}
		}

		private void SetAxisState(string name, Vector2 value)
		{
			switch(name)
			{
			default:
				logger.Error($"No input axis of name: {name}");
				break;
			}
		}

		private void SetStringState(string name, string value)
		{
			switch(name)
			{
				default:
					logger.Error($"No input button of name: {name}");
					break;
			}
		}

		public override void SendInputState()
		{
			if (!coherenceInput.IsProducer || !coherenceInput.IsReadyToProcessInputs || !coherenceInput.IsInputOwner)
			{
				return;
			}

			if (lastAddedFrame != currentSimulationFrame)
			{
				inputBuffer.AddInput(currentInput, currentSimulationFrame);
				lastAddedFrame = currentSimulationFrame;
			}

			while (inputBuffer.DequeueForSending(currentSimulationFrame, out long frameToSend, out Player input, out bool differs))
			{
				coherenceInput.DebugOnInputSent(frameToSend, input);
				client.SendInput(input, frameToSend, coherenceSync.EntityID);
			}
		}

		private bool ShouldPollCurrentInput(long frame)
		{
			return coherenceInput.IsProducer && coherenceInput.Delay == 0 && frame == currentSimulationFrame;
		}

		private bool GetButtonState(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
				default:
					logger.Error($"No input button of name: {name}");
					break;
			}

			return false;
		}

		private float GetButtonRangeState(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
			default:
				logger.Error($"No input button range of name: {name}");
				break;
			}

			return 0f;
		}

		private Vector2 GetAxisState(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
			default:
				logger.Error($"No input axis of name: {name}");
				break;
			}

			return Vector2.zero;
		}

		private string GetStringState(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
				default:
					logger.Error($"No input button of name: {name}");
					break;
			}

			return null;
		}

		private void OnInput(IEntityInput entityInput, long frame)
		{
			var input = (Player)entityInput;
			coherenceInput.DebugOnInputReceived(frame, entityInput);
			inputBuffer.ReceiveInput(input, frame);
		}
	}
}
