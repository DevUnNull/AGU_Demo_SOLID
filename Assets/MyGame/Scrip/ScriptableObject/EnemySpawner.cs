using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Spawn Settings")]
    public GameObject enemyPrefab; 
    public EnemyData[] enemyTypes; 
    
    public int spawnAmount = 100;
    public float spawnRadius = 5f;

    void Start()
    {
        SpawnEnemies();
    }

    private void SpawnEnemies()
    {
        for (int i = 0; i < spawnAmount; i++)
        {
  
            Vector2 randomPos = (Vector2)transform.position + Random.insideUnitCircle * spawnRadius;

            GameObject newEnemy = Instantiate(enemyPrefab, randomPos, Quaternion.identity);

            EnemyController controller = newEnemy.GetComponent<EnemyController>();
            if (controller != null && enemyTypes.Length > 0)
            {
                int randomIndex = Random.Range(0, enemyTypes.Length);
                controller.data = enemyTypes[randomIndex];
            }
        }
    }
}