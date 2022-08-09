using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject _playerPrefab;
    public GameObject firstSpawnPoint;
    public GameObject secondSpawnPoint;
    public GameObject thridSpawnPoint;
    public static int asf;
    void Start()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SpawnPlayer();
    }
    void SpawnPlayer()
    {
        Instantiate(_playerPrefab, firstSpawnPoint.transform.position, Quaternion.identity);
    }
    public void RestartScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
