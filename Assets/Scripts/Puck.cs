using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Puck : MonoBehaviour
{
    [SerializeField] private float _deceleration;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity *= _deceleration;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out Gate gate))
        {
            Debug.Log("Goal");
        }
    }
}
