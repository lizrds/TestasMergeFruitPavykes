using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject[] fruits;
    public float spawnY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            SpawnMechanic();
        }
    }

    public void SpawnMechanic()
    {
        Vector2 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spawnPosition.y = spawnY;

        int randomFruit = Random.Range(0, fruits.Length);
        GameObject fruit = fruits[randomFruit];

        Instantiate(fruit, spawnPosition, Quaternion.identity);
    }
}
