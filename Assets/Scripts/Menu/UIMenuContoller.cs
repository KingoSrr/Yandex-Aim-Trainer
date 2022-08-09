using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIMenuContoller : MonoBehaviour
{
    [SerializeField] private Slider _sliderSensetivity;
    public void PlayBtn()
    {
        SceneManager.LoadScene("GameScene");
    }
}
