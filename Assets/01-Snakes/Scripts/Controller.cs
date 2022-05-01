using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private GameObject _snake;
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
        _snake.transform.position += direction * _multiplier;
    }
}
