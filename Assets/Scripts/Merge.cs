using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Merge : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
    public GameObject fruitAfterMerging;
    private bool isReadyToMerge = true;
    public float mergeCooldown = 0.5f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isReadyToMerge || collision.gameObject.tag != gameObject.tag) return;
        if (gameObject.GetInstanceID() < collision.gameObject.GetInstanceID())
        {
            Vector3 spawnPosition = (transform.position + collision.transform.position) / 2;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            GameObject newFruit = Instantiate(fruitAfterMerging, spawnPosition, Quaternion.identity);
            newFruit.GetComponent<Merge>().StartMergeCooldown();
            score++;
        }
    }
    public void StartMergeCooldown()
    {
        StartCoroutine(MergeCooldownRoutine());
    }

    private IEnumerator MergeCooldownRoutine()
    {
        isReadyToMerge = false;
        yield return new WaitForSeconds(mergeCooldown);
        isReadyToMerge = true;
    }
    private void Update()
    {

    }
}

