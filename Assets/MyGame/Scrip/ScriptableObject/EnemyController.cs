using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Header("Data Reference")]
    public EnemyData data; 

    [Header("Runtime State (Read-Only in Inspector)")]
    [SerializeField] private float currentHealth; 

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        InitializeEnemy();
    }

    private void InitializeEnemy()
    {
        if (data == null)
        {
            Debug.LogError("Chưa gán EnemyData cho quái vật này!");
            return;
        }

        currentHealth = data.baseHealth;

        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            spriteRenderer.color = data.enemyColor;
        }

        gameObject.name = data.enemyName;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (data.deathVFX != null)
        {
            Instantiate(data.deathVFX, transform.position, Quaternion.identity);
        }
        
        Destroy(gameObject);
    }
}