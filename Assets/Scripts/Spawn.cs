using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public int score;
    public GameObject[] fruits;
    public float spawnY;
    int randomFruit;
    public TextMeshProUGUI upNext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();

        if (randomFruit == 0)
        {
            upNext.text = "Red";
            
        }
        if (randomFruit == 1)
        {
            upNext.text = "Blue";
        }
        if (randomFruit == 2)
        {
            upNext.text = "Green";
        }
        if (randomFruit == 3)
        {
            upNext.text = "Purple";
        }




        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SpawnMechanic();
            Reroll();
        }
    }
    public void Reroll()
    {
        randomFruit = Random.Range(0, fruits.Length);
    }
    public void SpawnMechanic()
    {
        score++;
        Vector2 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spawnPosition.y = spawnY;

        
        GameObject fruit = fruits[randomFruit];

        Instantiate(fruit, spawnPosition, Quaternion.identity);
    }
}
