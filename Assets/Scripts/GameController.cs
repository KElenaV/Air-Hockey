using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Puck _puck;

    [SerializeField] private int _firstPlayerScore;
    [SerializeField] private int _secondPlayerScore;

    private void OnEnable()
    {
        _puck.InGate += OnInGate;
    }

    private void OnDisable()
    {
        _puck.InGate -= OnInGate;
    }

    private void OnInGate(float gatePositionX)
    {
        if (gatePositionX > 0)
            _firstPlayerScore++;
        else if (gatePositionX < 0)
            _secondPlayerScore++;
    }
}
