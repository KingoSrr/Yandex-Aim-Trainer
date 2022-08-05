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
        Cursor.lockState = CursorLockMode.Locked;
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
