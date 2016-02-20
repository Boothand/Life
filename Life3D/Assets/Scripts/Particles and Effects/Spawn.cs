using UnityEngine;

public class Spawn : MonoBehaviour
{
	public static void SpawnObject(Object obj, Vector3 position, float lifeTime = -1f)
	{
		GameObject instanceObj = obj as GameObject;
		GameObject instance = Instantiate(obj, position, instanceObj.transform.rotation) as GameObject;

		instance.AddComponent(typeof(SpawnedObject));
		instance.GetComponent<SpawnedObject>().lifeTime = lifeTime;
	}

	public static void SpawnObject(Object obj, Vector3 position, Quaternion rotation, float lifeTime = -1f)
	{
		GameObject instance = Instantiate(obj, position, rotation) as GameObject;

		instance.AddComponent(typeof(SpawnedObject));
		instance.GetComponent<SpawnedObject>().lifeTime = lifeTime;
	}
}