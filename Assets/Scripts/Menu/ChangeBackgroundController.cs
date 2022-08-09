using UnityEngine;

public class ChangeBackgroundController : MonoBehaviour
{
    [SerializeField] private GameObject _currentBackground;
    [SerializeField] private Sprite[] _backgrounds;
    void Start()
    {
        SpriteRenderer sprite = _currentBackground.GetComponent<SpriteRenderer>();
        sprite.sprite = _backgrounds[Random.Range(0, _backgrounds.Length)];
    }
}
