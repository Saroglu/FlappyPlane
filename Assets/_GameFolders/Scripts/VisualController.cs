using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualController : MonoBehaviour
{
    //bu yöntem en performanslý yöntemdir ancak inspector üzerinden sürükle býrak gereklidir.
    [SerializeField] SpriteRenderer _spriteRenderer;
    [SerializeField] float _speed= 1f;


    private void Update()
    {
        float y = _spriteRenderer.size.y;
        float x = _spriteRenderer.size.x + (Time.deltaTime * _speed);
        _spriteRenderer.size = new Vector2(x, y);
    }
}
