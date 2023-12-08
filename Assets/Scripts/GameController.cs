using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class GameController : MonoBehaviour
{
    [SerializeField] private Puck _puck;
    [SerializeField] private TMP_Text _score;
    [SerializeField] private TMP_Text _timer;
    [SerializeField] private float _gameDuration = 60;

    private int _firstPlayerScore;
    private int _secondPlayerScore;
    private float _restartDelay = 3f;
    private AudioSource _audio;

    private void Start()
    {
        _audio = GetComponent<AudioSource>();
        _audio.Play();
    }

    private void OnEnable()
        => _puck.InGate += OnInGate;

    private void OnDisable()
        => _puck.InGate -= OnInGate;

    private void Update()
    {
        if (_gameDuration > 0)
        {
            _gameDuration -= Time.deltaTime;
            _timer.text = _gameDuration.ToString("f0");
        }
        else
        {
            ShowWinner();
            StartCoroutine(RestartGame());
        }
    }

    private void OnInGate(float gatePositionX)
    {
        if (gatePositionX > 0)
            _firstPlayerScore++;
        else if (gatePositionX < 0)
            _secondPlayerScore++;

        _score.text = $"{_firstPlayerScore} : {_secondPlayerScore}";
    }

    private void ShowWinner()
    {
        if (_firstPlayerScore == _secondPlayerScore)
        {
            _score.text = "Friendship won";
        }
        else
        {
            int winPlayerNumber = _firstPlayerScore > _secondPlayerScore ? 1 : 2;
            _score.text = $"Player {winPlayerNumber} win!";
        }

        _puck.gameObject.SetActive(false);
    }

    private IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(_restartDelay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
