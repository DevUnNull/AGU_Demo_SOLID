using UnityEngine;

public class Enemy : MonoBehaviour, IGameEntity
{
    public int Health { get; set; } = 100;
    public float Speed { get; set; } = 2f;
    public void Patrol()
    {
        Debug.Log("Enemy is patrolling...");
        // di chuyển qua lại
    }

    public void Attack()
    {
        Debug.Log("Enemy is attacking!");
    }

    public void ChasePlayer()
    {
        Debug.Log("Enemy is Chasing Player");
    }
}

// ✅ Enemy implement đầy đủ những gì nó cần
//public class Enemy : MonoBehaviour, IAttribute, IAttackable, IPatrol, IChasePlayer
//{
//    public int Health { get; set; } = 80;
//    public float Speed { get; set; } = 4f;

//    public void Patrol() => Debug.Log("Enemy patrolling...");

//    public void Attack() => Debug.Log("Enemy attacking!");

//    public void ChasePlayer()
//    {
//        Debug.Log("Enemy chasing player!");
//        // di chuyển về phía player
//    }
//}
