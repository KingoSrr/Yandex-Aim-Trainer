using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _spawnPoint;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        SpawnPlayer();
    }
    void SpawnPlayer()
    {
        GameObject player = Instantiate(_player, _spawnPoint.transform.position, Quaternion.identity);
    }
}
