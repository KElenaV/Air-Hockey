using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(AudioSource))]
public class Puck : MonoBehaviour
{
    [SerializeField] private float _deceleration;

    private Rigidbody _rigidbody;
    private AudioSource _audio;
    private float _startPositionX = 1.75f;

    public event UnityAction<float> InGate;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _audio = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity *= _deceleration;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out Gate gate))
        {
            float gatePositionX = transform.position.x;

            ResetPosition(gatePositionX);
            InGate?.Invoke(gatePositionX);
        }

        _audio.Play();
    }

    private void ResetPosition(float lastPositionX)
    {
        float resetPositionX = lastPositionX > 0 ? _startPositionX : -_startPositionX;
        transform.position = Vector3.right * resetPositionX;
        _rigidbody.velocity = Vector3.zero;
    }
}
