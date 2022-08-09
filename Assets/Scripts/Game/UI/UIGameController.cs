using UnityEngine;
using TMPro;

public class UIGameController : MonoBehaviour
{
    [SerializeField] private GameObject _gameController;
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private TMP_Text _scoreTMP;
    [SerializeField] private TMP_Text _timerTMP;
    [SerializeField] private float _seconds;
    public int score;

    void Start()
    {
        _gameController = GameObject.FindGameObjectWithTag("GameController");
        _seconds = 6;///////////////
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
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _gameOverPanel.SetActive(true);
        }

    }
    void CheckScore()
    {
        _scoreTMP.text = "Очки: " + score;
    }
}
