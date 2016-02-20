using UnityEngine;

public class TestBoxCast : MonoBehaviour
{
	public LayerMask allowedCollisions;
	
	void Start ()
	{
		
	}

	void OnCollisionStay(Collision col)
	{
		//print("Colliding");
		//Debug.DrawRay(col.contacts[0].point, col.contacts[0].normal, Color.red);
	}
	
	void Update ()
	{
		RaycastHit[] hits = Physics.BoxCastAll(transform.position, Vector3.one / 3, -Vector3.right, transform.rotation, 1f, allowedCollisions);
		Draw.Debug_DrawBox(transform.position + -Vector3.right, Vector3.one / 3);
		foreach (RaycastHit rayhit in hits)
		{
			//Ignore any self collision
			if (rayhit.transform.root.GetInstanceID() == transform.root.GetInstanceID())
			{
				continue;
			}

			Debug.DrawRay(rayhit.point, Vector3.up, Color.red);
			print("Collided with " + rayhit.transform.name);
			print("Point: " + rayhit.point);
		}
	}
}