﻿using StandardAssets.Characters.Common;
using UnityEngine;

namespace StandardAssets.Characters.Effects
{
	/// <inheritdoc />
	[RequireComponent(typeof(Collider))]
	public class TriggerMovementZone : MovementZone
	{
		/// <summary>
		/// Change the movement event library on trigger enter
		/// </summary>
		/// <param name="other"></param>
		void OnTriggerEnter(Collider other)
		{
			CharacterBrain brain = other.GetComponent<CharacterBrain>();
			if (brain != null)
			{
				Trigger(brain.movementEventHandler);
			}
		}
		
		/// <summary>
		/// Change the movement event library back to default/starting
		/// </summary>
		/// <param name="other"></param>
		private void OnTriggerExit(Collider other)
		{
			CharacterBrain brain = other.GetComponent<CharacterBrain>();
			if (brain != null)
			{
				ExitTrigger(brain.movementEventHandler);
			}
		}
	}
}