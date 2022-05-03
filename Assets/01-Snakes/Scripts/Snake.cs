using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    [SerializeField] private GameObject _snakeHead;
	[SerializeField] private GameObject _snakeBody;

    private List<Transform> _snake = new List<Transform>();
	private GameObject _bodyCopy = null;
	private Vector3 _bodyPosition;


	private void Awake()
	{
		_snake.Add(_snakeHead.transform);
		_snake.Add(_snakeBody.transform);
	}

	public void MoveBody(Vector3 oldPosition)
	{
		for (int i = 1; i < _snake.Count; i++)
		{
			(oldPosition, _snake[i].position) = (_snake[i].position, oldPosition);
		}

		_bodyPosition = oldPosition;
	}

	public void GenerateBody()
	{
		_bodyCopy = Instantiate(_snakeBody, _bodyPosition, Quaternion.identity);
		_bodyCopy.transform.parent = transform;
		_bodyCopy.name = "Body";
		_snake.Add(_bodyCopy.transform);
	}
}
