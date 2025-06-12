using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    public int numberToSpawn = 10;
    public Vector3 spawnAreaSize = new Vector3(10, 1, 10);

    public void SpawnObject()
    {
        for (int i = 0; i < numberToSpawn; i++)
        {
            SpawnRandomObject();
        }
    }

    void SpawnRandomObject()
    {
        if (objectsToSpawn.Length == 0) return;

        GameObject prefab = objectsToSpawn[Random.Range(0, objectsToSpawn.Length)];

        Vector3 randomPosition = transform.position + new Vector3(
            Random.Range(-spawnAreaSize.x / 2, spawnAreaSize.x / 2),
            Random.Range(-spawnAreaSize.y / 2, spawnAreaSize.y / 2),
            Random.Range(-spawnAreaSize.z / 2, spawnAreaSize.z / 2)
        );

        Instantiate(prefab, randomPosition, Quaternion.identity);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, spawnAreaSize);
    }
}
