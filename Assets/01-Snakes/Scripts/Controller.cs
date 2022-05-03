using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private GameObject _snake;
    private List<GameObject> snakeChildren;
    //private Snake _snakeObject;

    private float _multiplier = 0.5f;


	private void Start()
	{
        //snakeChildren = new List<Transform>(_snake.transform.GetComponentsInChildren<Transform>());
        snakeChildren = _snake.GetComponent<Snake>().SnakeBody;
    }

	private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            MoveSnake(Vector3.left);
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            MoveSnake(Vector3.right);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            MoveSnake(Vector3.up);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            MoveSnake(Vector3.down);
    }

    private void MoveSnake(Vector3 direction)
	{
        var oldPosition = snakeChildren[0].transform.position;
        snakeChildren[0].transform.position += direction * _multiplier;

        for (int i = 1; i < _snake.transform.childCount; i++)
		{
            var tempPosition = snakeChildren[i].transform.position;
            snakeChildren[i].transform.position = oldPosition;
            oldPosition = tempPosition;
        }
    }
}
