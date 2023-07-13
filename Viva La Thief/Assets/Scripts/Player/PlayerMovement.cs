using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _playerMovementSpeed;
    [SerializeField] private float _playerSprintSpeed;

    private float _horizontal;
    private float _vertical;

    private float _defaultSpeed;

    private Rigidbody2D _rigidbody;

    void Start()
    {
        _defaultSpeed = _playerMovementSpeed;

        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.LeftShift))
            _playerMovementSpeed = _playerSprintSpeed;
        else
            _playerMovementSpeed = _defaultSpeed;
    }

    void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(_horizontal, _vertical ) * _playerMovementSpeed * Time.deltaTime;
    }
}
