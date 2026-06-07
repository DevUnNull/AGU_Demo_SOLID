using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemyData", menuName = "BrainRot/Enemy Data")]
public class EnemyData : ScriptableObject
{
    [Header("General Info")]
    public string enemyName;
    public string description;

    [Header("Combat Stats")]
    public float baseHealth;
    public float baseDamage;
    public float moveSpeed;
    [Header("Visuals")]
    public Color enemyColor = Color.white;
    public GameObject deathVFX;
}
