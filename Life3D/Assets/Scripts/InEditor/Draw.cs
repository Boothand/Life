using UnityEngine;

public class Draw : MonoBehaviour
{
	public static void Debug_DrawBox(Vector3 origin, Vector3 halfExtents)
	{
		//Lower front left - lower front right
		Debug.DrawLine(new Vector3(origin.x + halfExtents.x, origin.y - halfExtents.y, origin.z + halfExtents.z), new Vector3(origin.x - halfExtents.x, origin.y - halfExtents.y, origin.z + halfExtents.z), Color.red);

		//Lower front left - upper front left
		Debug.DrawLine(new Vector3(origin.x + halfExtents.x, origin.y - halfExtents.y, origin.z + halfExtents.z), new Vector3(origin.x + halfExtents.x, origin.y + halfExtents.y, origin.z + halfExtents.z), Color.red);

		//Lower front left - lower back left
		Debug.DrawLine(new Vector3(origin.x + halfExtents.x, origin.y - halfExtents.y, origin.z + halfExtents.z), new Vector3(origin.x + halfExtents.x, origin.y - halfExtents.y, origin.z - halfExtents.z), Color.red);

		//Lower back left - lower back right
		Debug.DrawLine(new Vector3(origin.x + halfExtents.x, origin.y - halfExtents.y, origin.z - halfExtents.z), new Vector3(origin.x - halfExtents.x, origin.y - halfExtents.y, origin.z - halfExtents.z), Color.red);

		//Lower back left - upper back left
		Debug.DrawLine(new Vector3(origin.x + halfExtents.x, origin.y - halfExtents.y, origin.z - halfExtents.z), new Vector3(origin.x + halfExtents.x, origin.y + halfExtents.y, origin.z - halfExtents.z), Color.red);

		//Upper back left - upper front left
		Debug.DrawLine(new Vector3(origin.x + halfExtents.x, origin.y + halfExtents.y, origin.z - halfExtents.z), new Vector3(origin.x + halfExtents.x, origin.y + halfExtents.y, origin.z + halfExtents.z), Color.red);

		//Upper back left - upper back right
		Debug.DrawLine(new Vector3(origin.x + halfExtents.x, origin.y + halfExtents.y, origin.z - halfExtents.z), new Vector3(origin.x - halfExtents.x, origin.y + halfExtents.y, origin.z - halfExtents.z), Color.red);

		//Lower back right - upper back right
		Debug.DrawLine(new Vector3(origin.x - halfExtents.x, origin.y - halfExtents.y, origin.z - halfExtents.z), new Vector3(origin.x - halfExtents.x, origin.y + halfExtents.y, origin.z - halfExtents.z), Color.red);

		//Lower back right - lower front right
		Debug.DrawLine(new Vector3(origin.x - halfExtents.x, origin.y - halfExtents.y, origin.z - halfExtents.z), new Vector3(origin.x - halfExtents.x, origin.y - halfExtents.y, origin.z + halfExtents.z), Color.red);

		//Upper back right - upper front right
		Debug.DrawLine(new Vector3(origin.x - halfExtents.x, origin.y + halfExtents.y, origin.z - halfExtents.z), new Vector3(origin.x - halfExtents.x, origin.y + halfExtents.y, origin.z + halfExtents.z), Color.red);

		//Upper back right - upper front right
		Debug.DrawLine(new Vector3(origin.x - halfExtents.x, origin.y + halfExtents.y, origin.z - halfExtents.z), new Vector3(origin.x - halfExtents.x, origin.y + halfExtents.y, origin.z + halfExtents.z), Color.red);

		//Upper front right - upper front left
		Debug.DrawLine(new Vector3(origin.x - halfExtents.x, origin.y + halfExtents.y, origin.z + halfExtents.z), new Vector3(origin.x + halfExtents.x, origin.y + halfExtents.y, origin.z + halfExtents.z), Color.red);

		//Upper front right - lower front right
		Debug.DrawLine(new Vector3(origin.x - halfExtents.x, origin.y + halfExtents.y, origin.z + halfExtents.z), new Vector3(origin.x - halfExtents.x, origin.y - halfExtents.y, origin.z + halfExtents.z), Color.red);
	}

	//public static void Debug_DrawBox(Vector3 origin, Vector3 halfExtents, Vector3 direction, Quaternion rotation)
	//{
	//	Vector3 bottom = new Vector3(origin.x - halfExtents.x, origin.y - halfExtents.y, origin.z - halfExtents.z);

	//	//Debug.DrawRay(bottom, direction, Color.red);

	//	//Debug.DrawRay(new Vector3(origin.x + halfExtents.x + direction.x, origin.y - halfExtents.y + direction.y, origin.z + halfExtents.z + direction.z), dir);
	//	////Lower front left - lower front right
	//	//Debug.DrawLine(new Vector3(origin.x + halfExtents.x, origin.y - halfExtents.y, origin.z + halfExtents.z), new Vector3(origin.x - halfExtents.x, origin.y - halfExtents.y, origin.z + halfExtents.z), Color.red);

	//	////Lower front left - upper front left
	//	//Debug.DrawLine(new Vector3(origin.x + halfExtents.x, origin.y - halfExtents.y, origin.z + halfExtents.z), new Vector3(origin.x + halfExtents.x, origin.y + halfExtents.y, origin.z + halfExtents.z), Color.red);

	//	////Lower front left - lower back left
	//	//Debug.DrawLine(new Vector3(origin.x + halfExtents.x, origin.y - halfExtents.y, origin.z + halfExtents.z), new Vector3(origin.x + halfExtents.x, origin.y - halfExtents.y, origin.z - halfExtents.z), Color.red);

	//	////Lower back left - lower back right
	//	//Debug.DrawLine(new Vector3(origin.x + halfExtents.x, origin.y - halfExtents.y, origin.z - halfExtents.z), new Vector3(origin.x - halfExtents.x, origin.y - halfExtents.y, origin.z - halfExtents.z), Color.red);

	//	////Lower back left - upper back left
	//	//Debug.DrawLine(new Vector3(origin.x + halfExtents.x, origin.y - halfExtents.y, origin.z - halfExtents.z), new Vector3(origin.x + halfExtents.x, origin.y + halfExtents.y, origin.z - halfExtents.z), Color.red);

	//	////Upper back left - upper front left
	//	//Debug.DrawLine(new Vector3(origin.x + halfExtents.x, origin.y + halfExtents.y, origin.z - halfExtents.z), new Vector3(origin.x + halfExtents.x, origin.y + halfExtents.y, origin.z + halfExtents.z), Color.red);

	//	////Upper back left - upper back right
	//	//Debug.DrawLine(new Vector3(origin.x + halfExtents.x, origin.y + halfExtents.y, origin.z - halfExtents.z), new Vector3(origin.x - halfExtents.x, origin.y + halfExtents.y, origin.z - halfExtents.z), Color.red);

	//	////Lower back right - upper back right
	//	//Debug.DrawLine(new Vector3(origin.x - halfExtents.x, origin.y - halfExtents.y, origin.z - halfExtents.z), new Vector3(origin.x - halfExtents.x, origin.y + halfExtents.y, origin.z - halfExtents.z), Color.red);

	//	////Lower back right - lower front right
	//	//Debug.DrawRay(new Vector3(origin.x - (direction.x), origin.y - (direction.y), origin.z - (direction.z)), direction * (2 * halfExtents.y), Color.red);

	//	////Upper back right - upper front right
	//	//Debug.DrawLine(new Vector3(origin.x - halfExtents.x, origin.y + halfExtents.y, origin.z - halfExtents.z), new Vector3(origin.x - halfExtents.x, origin.y + halfExtents.y, origin.z + halfExtents.z), Color.red);

	//	////Upper back right - upper front right
	//	//Debug.DrawLine(new Vector3(origin.x - halfExtents.x, origin.y + halfExtents.y, origin.z - halfExtents.z), new Vector3(origin.x - halfExtents.x, origin.y + halfExtents.y, origin.z + halfExtents.z), Color.red);

	//	////Upper front right - upper front left
	//	//Debug.DrawLine(new Vector3(origin.x - halfExtents.x, origin.y + halfExtents.y, origin.z + halfExtents.z), new Vector3(origin.x + halfExtents.x, origin.y + halfExtents.y, origin.z + halfExtents.z), Color.red);

	//	////Upper front right - lower front right
	//	//Debug.DrawLine(new Vector3(origin.x - halfExtents.x, origin.y + halfExtents.y, origin.z + halfExtents.z), new Vector3(origin.x - halfExtents.x, origin.y - halfExtents.y, origin.z + halfExtents.z), Color.red);
	////}

}