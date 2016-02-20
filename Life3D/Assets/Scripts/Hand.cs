using UnityEngine;

public class Hand : MonoBehaviour
{
	public Item heldObject;
	Vector3 animRotation;
	Vector3 colRotation;
	bool hasCollidedPerPhysics;

	float lerpIterator;
	public float lerpSpeed = 2f;
	Vector3 newRot;

	void Start ()
	{

	}

	void Update()
	{
		Weapon wp = heldObject.GetComponent<Weapon>();
		//Draw.Debug_DrawBox(boxcast.position, boxcastSize, -boxcast.up, boxcast.rotation);

		//foreach (RaycastHit h in hit)
		//{
		//	if (h.transform.root.GetInstanceID() != transform.root.GetInstanceID())
		//	{
		//		print("Hit " + h.transform.name);
		//	}
		//}

	}

	void LateUpdate ()
	{
		if (heldObject.GetComponent<Weapon>())
		{
			animRotation = transform.right;

			Weapon wp = heldObject.GetComponent<Weapon>();
			//Vector3 reflectedDir;

			Debug.DrawRay(wp.weaponColliders[2].transform.position, wp.weaponColliders[2].GetComponent<Rigidbody>().velocity * 5f, Color.green);

			//If OnCollision detected a collision
			if (!hasCollidedPerPhysics && wp.IsCollidingPerPhysics())
			{
				//hasCollidedPerPhysics = true;

				//While there still is a collision, rotate the sword towards the reflected vector until there is no collision
				foreach (CollisionHandler handler in wp.weaponColliders)
				{
					if (handler.colliding)
					{
						//print("Colliding");
						//reflectedDir = Vector3.Reflect(handler.perFrameVelocity, handler.collisionContact[0].normal);
						foreach (ContactPoint cp in handler.collisionContact)
						{
							Debug.DrawRay(cp.point, Vector3.Reflect(handler.velCalc.velocity * 5f, cp.normal), Color.green);
							Debug.DrawRay(cp.point, cp.normal, Color.blue);
							Debug.DrawRay(cp.point, handler.perFrameVelocity * 5f, Color.red);
						}
					}
				}
			}
			else
			{
				if (hasCollidedPerPhysics)
				{
					//transform.right = Vector3.Lerp(colRotation, animRotation, lerpIterator);

					//if (lerpIterator < 1)
					//{
					//	lerpIterator += Time.deltaTime * lerpSpeed;
					//}
					//else
					//{
					//	hasCollided = false;
					//	lerpIterator = 0f;
					//}
				}
			}
		}
	}
}