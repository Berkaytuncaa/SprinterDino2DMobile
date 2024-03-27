using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    [SerializeField] private float spawnRate;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;
    public float moveSpeed;
    [SerializeField] private float destroyDelay;

    public GameManager gm;

    private void Start()
    {
        StartCoroutine(SpawnObject());
    }

    private IEnumerator SpawnObject()
    {
        while (true)
        {
            if (gm.score % 4 == 0 && gm.score < 17)
            {
                moveSpeed++;
            }

            float randomY = Random.Range(minY, maxY);


            GameObject spawnedObject = Instantiate(prefabToSpawn, new Vector2(transform.position.x, randomY), Quaternion.identity);


            Rigidbody2D rb = spawnedObject.AddComponent<Rigidbody2D>();
            rb.gravityScale = 0f;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;

            rb.velocity = new Vector2(-moveSpeed, 0f);

            Destroy(spawnedObject, destroyDelay);
            yield return new WaitForSeconds(spawnRate);
        }
    }
}
