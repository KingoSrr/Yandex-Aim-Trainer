using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject _gameController;
    [SerializeField] private TMP_Text _scoreTMP;
    [SerializeField] private TMP_Text _timerTMP;
    [SerializeField] private float _seconds;
    public int score;

    void Start()
    {
        _gameController = GameObject.FindGameObjectWithTag("GameController");
        _seconds = 60;
    }
    void Update()
    {
        CheckScore();
        CheckTimer();
    }
    void CheckTimer()
    {
        if(_seconds > 0)
        {
            _seconds = _seconds - 1 * Time.deltaTime;
            _timerTMP.text = string.Format("{0:00}", _seconds);
        }
        else
        {
            _gameController.GetComponent<GameController>().RestartScene();
        }

    }
    void CheckScore()
    {
        _scoreTMP.text = "Очки: " + score;
    }
}
