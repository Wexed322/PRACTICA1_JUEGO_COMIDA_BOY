using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallManager : MonoBehaviour
{
    [SerializeField]
    List<GameObject> enemies;

    [SerializeField] Vector2 rangeIns;
    [SerializeField] Vector2 rangeCooldown;

    [SerializeField]
    float contador;

    public int coolDownSpawn;
    void Start()
    {

    }

    void Update()
    {
        contador += Time.deltaTime;
        if (contador > coolDownSpawn) 
        {
            CreateObject();
            contador = 0;
        }
    }

    void CreateObject() 
    {
        float range = Random.Range(rangeIns.x, rangeIns.y);
        Instantiate(enemies[Random.Range(0,enemies.Count)], new Vector3(transform.position.x + range, transform.position.y, 0), Quaternion.identity);
        coolDownSpawn = (int)Random.Range(rangeCooldown.x, rangeCooldown.y);
    }
}
