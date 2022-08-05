using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTargetController : MonoBehaviour
{
    [SerializeField] private float posX;
    [SerializeField] private float posY;
    [SerializeField] private float posZ;
    public GameObject targetPlace;
    public GameObject target;

    void Start()
    {
        Spawn();
    }
    void Spawn()
    {
        for (int i = 0; i < 5; i++)
        {
            posX = 2f;
            posY = Random.Range(-0.4f, 0.4f);
            posZ = Random.Range(-0.4f, 0.4f);

            GameObject go = Instantiate(target);

            go.transform.SetParent(targetPlace.transform);
            go.transform.localPosition = new Vector3(posX, posY, posZ);
        }
    }
    public void Respawn()
    {
        posX = 2f;
        posY = Random.Range(-0.3f, 0.3f);
        posZ = Random.Range(-0.3f, 0.3f);

        GameObject go = Instantiate(target);

        go.transform.SetParent(targetPlace.transform);
        go.transform.localPosition = new Vector3(posX, posY, posZ);
    }
}
