using UnityEngine;

public class VelocityCalc : MonoBehaviour
{
	public int iterations = 5;
	public Vector3 velocity;
	Vector3[] positions;
	int nextPosIterator;
	public bool debugRays;

	void Start ()
	{
		positions = new Vector3[iterations];
	}
	
	void Update ()
	{
		positions[nextPosIterator] = transform.position;
		nextPosIterator++;

		if (nextPosIterator == iterations)
		{
			nextPosIterator = 0;
		}

		Vector3 average = Vector3.zero;

		foreach (Vector3 pos in positions)
		{
			average += pos;
		}

		average /= iterations;

		velocity = transform.position - average;

		print(transform.position + " - " + average);

		if (debugRays)
		{
			Debug.DrawRay(transform.position, velocity * 5f);
		}
	}
}