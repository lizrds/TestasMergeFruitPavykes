using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge : MonoBehaviour
{

    public GameObject fruitAfterMerging;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == gameObject.tag)
        {
            Vector3 spawnPosition = (transform.position + collision.transform.position) / 2;

            Destroy(collision.gameObject);
            Destroy(gameObject);
            Instantiate(fruitAfterMerging, spawnPosition, Quaternion.identity);
        }
    }


}
