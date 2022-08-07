using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIGameoverController : MonoBehaviour
{
    [SerializeField] private TMP_Text _totalScoreTMP;
    [SerializeField] private UIGameController uiGameController;
    void Update()
    {
        CheckScore();
    }
    public void RestartBtn()
    {
        SceneManager.LoadScene("GameScene");
    }
    void CheckScore()
    {
        _totalScoreTMP.text = "Всего очков: " + uiGameController.score;
    }
}
