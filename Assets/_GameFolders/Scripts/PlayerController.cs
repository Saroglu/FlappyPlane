using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rigidbody;

    [Range(7000f, 15000f)]
    [SerializeField] float  forcePower=250f;
    [SerializeField] float  _angle=30f;
    private bool  _isJump=false;

    [Header("Child Objects")]
    [SerializeField] Transform _bodyTransform;

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            _isJump = true;
            _bodyTransform.eulerAngles = Vector3.forward * _angle;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //yeni input sistemi
        

        if (_isJump)
        {
            _rigidbody.velocity = Vector2.zero;

            //rigidbody.AddForce(new Vector2(0f, forcePower));
            _rigidbody.AddForce(Vector2.up * forcePower* Time.fixedDeltaTime);
            _isJump = false;
        }

        //GetComponent<Rigidbody2D>();
    }

    private void LateUpdate()
    {
            _bodyTransform.eulerAngles += Vector3.forward * -30f * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Game Over");

        //Time.timeScale = 0f;

        GameManager.Instance.GameOver();
    }
}
