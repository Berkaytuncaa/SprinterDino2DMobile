using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// being used for visual purposes, it spawns clouds :)
/// </summary>
public class CloudSpawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    [SerializeField] private float spawnRate;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float destroyDelay;

    private void Start()
    {
        StartCoroutine(SpawnObject());
    }

    private IEnumerator SpawnObject()
    {
        while (true)
        {
            float randomY = Random.Range(minY, maxY);

            
            GameObject spawnedObject = Instantiate(prefabToSpawn, new Vector2(transform.position.x, randomY), Quaternion.identity);

            
            Rigidbody2D rb = spawnedObject.AddComponent<Rigidbody2D>();
            rb.gravityScale = 0f;

            
            rb.velocity = new Vector2(-moveSpeed, 0f);

            Destroy(spawnedObject, destroyDelay);
            
            yield return new WaitForSeconds(spawnRate);
        }
    }
}
