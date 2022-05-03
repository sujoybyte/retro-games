using UnityEngine;

public class Eat : MonoBehaviour
{
	[SerializeField] private Food _food;
	[SerializeField] private Snake _snake;


	private void OnTriggerEnter2D(Collider2D collision)
	{
		_snake.GenerateBody();
		_food.RespawnFood();
	}
}
