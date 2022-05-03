using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private GameObject _snakeHead;
    [SerializeField] private Snake _snake;

    private float _multiplier = 0.5f;


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
        Vector3 oldPosition = _snakeHead.transform.position;
        _snakeHead.transform.position += direction * _multiplier;

        _snake.MoveBody(oldPosition);
    }
}
