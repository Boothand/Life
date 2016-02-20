using UnityEngine;
using System.Collections.Generic;

public class Weapon : Item
{
	public List<CollisionHandler> weaponColliders;
	[HideInInspector]public Vector3 rotationOverridePoint;
	public bool colliding;
	public float collisionBladeHalfLength = 1f;
	public float collisionBladeHalfWidth = 0.05f;
	public Transform boxcast;
	[HideInInspector]public Vector3 rotationalVelocity;

	public LayerMask layer;


	void Start ()
	{

	}

	public bool IsCollidingPerPhysics()
	{
		foreach (CollisionHandler handler in weaponColliders)
		{
			if (handler.colliding)
			{
				return true;
			}
		}

		return false;
	}

	public bool IsCollidingPerFrame()
	{
		Vector3 boxcastSize = new Vector3(collisionBladeHalfWidth, collisionBladeHalfLength, collisionBladeHalfWidth);
		RaycastHit[] hit = Physics.BoxCastAll(boxcast.position, boxcastSize, -rotationalVelocity, boxcast.rotation, 0f, layer);

		foreach (RaycastHit h in hit)
		{
			//Ignore collisions from self
			if (h.transform.root.GetInstanceID() == transform.root.GetInstanceID())
			{
				continue;
			}
		}

		return false;
	}
	
	internal void BaseUpdate ()
	{
		//Rotational velocity
		rotationalVelocity = Vector3.zero;
		foreach (CollisionHandler handler in weaponColliders)
		{
			rotationalVelocity += handler.perFrameVelocity;
		}
		rotationalVelocity /= weaponColliders.Count;


	}
}