using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreTMP;
    [SerializeField] private TMP_Text _timerTMP;
    [SerializeField] private float _seconds;
    public int score;

    void Start()
    {
        _seconds = 60;
    }
    void Update()
    {
        CheckScore();
        CheckTimer();
    }
    void CheckScore()
    {
        _seconds = _seconds - 1 * Time.deltaTime;
        _timerTMP.text = string.Format("{0:00}", _seconds);
    }
    void CheckTimer()
    {
        _scoreTMP.text = "Очки: " + score;
    }
}
