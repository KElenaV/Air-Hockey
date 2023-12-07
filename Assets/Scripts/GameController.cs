using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Puck _puck;
    [SerializeField] private TMP_Text _score;

    private int _firstPlayerScore;
    private int _secondPlayerScore;

    private void OnEnable() 
        => _puck.InGate += OnInGate;

    private void OnDisable() 
        => _puck.InGate -= OnInGate;

    private void OnInGate(float gatePositionX)
    {
        if (gatePositionX > 0)
            _firstPlayerScore++;
        else if (gatePositionX < 0)
            _secondPlayerScore++;

        _score.text = $"{_firstPlayerScore} : {_secondPlayerScore}";
    }
}
