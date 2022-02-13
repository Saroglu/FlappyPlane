using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Rigidbody2D _rigidbody;

    [SerializeField] float _moveSpeed=2f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _rigidbody.velocity = Vector2.left * _moveSpeed;
    }
}
