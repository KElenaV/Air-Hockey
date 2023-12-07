using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private Puck _puck;
    [SerializeField] private TMP_Text _score;

    private int _firstPlayerScore;
    private int _secondPlayerScore;
    private bool _isGameOver = false;
    private float _restartDelay = 3f;

    private void OnEnable() 
        => _puck.InGate += OnInGate;

    private void OnDisable() 
        => _puck.InGate -= OnInGate;

    private void Update()
    {
        if (_isGameOver)
            StartCoroutine(RestartGame());
    }

    private void OnInGate(float gatePositionX)
    {
        if (gatePositionX > 0)
            _firstPlayerScore++;
        else if (gatePositionX < 0)
            _secondPlayerScore++;

        _score.text = $"{_firstPlayerScore} : {_secondPlayerScore}";

        if (_firstPlayerScore == 3)
            ShowWinner(1);
        if (_secondPlayerScore == 3)
            ShowWinner(2);
    }

    private void ShowWinner(int winPlayerNumber)
    {
        _score.text = $"Player {winPlayerNumber} win!";
        _puck.gameObject.SetActive(false);
        _isGameOver = true;
    }

    private IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(_restartDelay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
