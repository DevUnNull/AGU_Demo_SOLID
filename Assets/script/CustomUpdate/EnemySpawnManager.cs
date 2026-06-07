using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    private void Start()
    {
        SpawnEnemy();
    }

    private void SpawnEnemy()
    {
        for (int i = 0; i < 2000; i++)
        {
            Instantiate(enemyPrefab, transform.position + new Vector3(i * 2, 0, 0), Quaternion.identity);
        }
    }
}
