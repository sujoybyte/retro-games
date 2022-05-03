using UnityEngine;

public class Food : MonoBehaviour
{
	public void RespawnFood()
	{
		transform.position = 
			new Vector3(Random.Range(-6, 6) * 0.5f, Random.Range(-6, 6) * 0.5f, 0);
	}
}
