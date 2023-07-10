using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _playerMovement;

    private float _horizontal;
    private float _vertical;

    private Rigidbody2D _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(_horizontal, _vertical ) * _playerMovement * Time.deltaTime;
    }
}
