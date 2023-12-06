using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class Paddle : MonoBehaviour
{
    [SerializeField] private float _speed = 10;

    private Rigidbody _rigidbody;
    private Vector2 _direction;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_direction.x, 0, _direction.y) * _speed;
    }

    public void OnMove(InputAction.CallbackContext context) 
        => _direction = context.ReadValue<Vector2>();
}
