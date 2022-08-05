using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootController : MonoBehaviour
{
    [SerializeField] private Camera _playerCamera;
    [SerializeField] private GameObject spawnTargetController;
    void Start()
    {
        spawnTargetController = GameObject.FindGameObjectWithTag("SpawnTargetController");
    }
    void Update()
    {
        Shoot();
    }
    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 point = new Vector3(_playerCamera.pixelWidth / 2, _playerCamera.pixelHeight / 2, 0.0f);
            Ray ray = _playerCamera.ScreenPointToRay(point); // Из камеры направляется луч в точку
            RaycastHit hit; // Сохранить первую информацию о столкновении
            if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("Target"))
            {
                Destroy(hit.collider.gameObject);
                spawnTargetController.GetComponent<SpawnTargetController>().Respawn();
            }
        }
    }
}
