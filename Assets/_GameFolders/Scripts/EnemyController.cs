using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Rigidbody2D _rigidbody;

    [SerializeField] float _moveSpeed=2f;
    [SerializeField] float _deadCounterSpeed=1f;
    [SerializeField] float _maxDeadCounterTime=10f;

    float _counter;
    private void Awake()
    {
        _counter = 0f;
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _rigidbody.velocity = Vector2.left * _moveSpeed;
    }
    private void Update()
    {
        _counter += Time.deltaTime * _deadCounterSpeed;

        if (_counter >_maxDeadCounterTime)
        {
            //enemyDead
            Destroy(this.gameObject);
        }
    }
}
