using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
	public bool colliding;
	public Transform collisionTransform;
	public ContactPoint[] collisionContact;
	public CollisionHandler lastCollidedWith;
	public VelocityCalc velCalc;
	[HideInInspector]public Vector3 perFrameVelocity;
	Vector3 lastPosition;

	void Start ()
	{
		velCalc = GetComponent<VelocityCalc>();

		if (!collisionTransform)
		{
			if (transform.childCount > 0)
			{
				collisionTransform = transform.GetChild(0);
			}
		}
	}

	void OnCollisionEnter(Collision col)
	{
		//If not colliding with self
		if (transform.root.GetInstanceID() != col.transform.root.GetInstanceID())
		{
			colliding = true;

			if (collisionTransform)
			{
				//Set collision transform to the position where the weapons collided
				//collisionTransform.position = col.contacts[0].point;
				collisionContact = col.contacts;

				//lastCollidedWith = col.transform.GetComponent<CollisionHandler>();
			}
		}
	}

	void OnCollisionStay(Collision col)
	{
		//If not colliding with self
		if (transform.root.GetInstanceID() != col.transform.root.GetInstanceID())
		{
			colliding = true;
			collisionContact = col.contacts;

		}
	}

	void OnCollisionExit(Collision col)
	{
		//If not colliding with self
		if (transform.root.GetInstanceID() != col.transform.root.GetInstanceID())
		{
			colliding = false;
		}
	}

	void Update ()
	{
		perFrameVelocity = transform.position - lastPosition;
		lastPosition = transform.position;
	}
}