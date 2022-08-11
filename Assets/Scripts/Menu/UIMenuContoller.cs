using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIMenuContoller : MonoBehaviour
{
    [SerializeField] private Slider _sliderSensetivity;
    void Start()
    {
        _sliderSensetivity.value = PlayerPrefs.GetFloat("sensetivitySave") / 10f;
    }
    void Update()
    {
        _sliderSensetivity.onValueChanged.AddListener(delegate { SliderChanged(); });
    }
    void SliderChanged()
    {
        PlayerPrefs.SetFloat("sensetivitySave", _sliderSensetivity.value * 10f);
    }
    public void PlayBtn()
    {
        SceneManager.LoadScene("GameScene");
    }
    
}
