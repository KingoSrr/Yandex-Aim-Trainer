using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleportController : MonoBehaviour
{
    [SerializeField] private GameObject _gameController;

    void Start()
    {
        _gameController = GameObject.FindGameObjectWithTag("GameController");
    }

    void FixedUpdate()
    {
        Teleport();
    }
    void Teleport()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("1");
            transform.position = _gameController.GetComponent<GameController>().firstSpawnPoint.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.position = _gameController.GetComponent<GameController>().secondSpawnPoint.transform.position; ;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            transform.position = _gameController.GetComponent<GameController>().thridSpawnPoint.transform.position;
        }
    }
}
