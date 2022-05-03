using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    [SerializeField] private GameObject _snakeHead;
    [SerializeField] public List<GameObject> _snake = new List<GameObject>();
	private GameObject _bodyCopy = null;
	private float _bodyPosition = 0.5f;


	private void Awake()
	{
		_snake.Add(_snakeHead);
		GenerateBody(3);
	}

	public List<GameObject> SnakeBody { get { return _snake; } }

	private void GenerateBody(int bodyCount)
	{
		for (int i = 0; i < bodyCount; i++)
		{
			_bodyCopy = Instantiate(_snakeHead, new Vector3(_bodyPosition, 0, 0), Quaternion.identity);
			_bodyCopy.transform.parent = transform;
			_bodyCopy.name = "Body";
			_snake.Add(_bodyCopy);

			_bodyPosition += 0.5f;
		}
	}
}
