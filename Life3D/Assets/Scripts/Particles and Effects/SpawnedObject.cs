using UnityEngine;

public class SpawnedObject : MonoBehaviour
{
	public float lifeTime = -1;
	float timer;

	void Start ()
	{
		
	}
	
	void Update ()
	{
		if (lifeTime > -1f)
		{
			timer += Time.deltaTime;

			if (timer > lifeTime)
			{
				Destroy(gameObject);
			}
		}
	}
}