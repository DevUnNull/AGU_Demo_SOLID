using UnityEngine;

// Villager buộc phải implement Attack() và ChasePlayer() dù không cần
public class Villager : MonoBehaviour, IGameEntity
{
    public int Health { get; set; } = 100;
    public float Speed { get; set; } = 2f;

    public void Start()
    {
        Patrol();
    }

    private void Update()
    {
        // Nhấn A để test Attack()
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Bấm A");
            Attack();
        }

        // Nhấn C để test ChasePlayer()
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Bấm C");
            ChasePlayer();
        }
    }

    public void Patrol()
    {
        Debug.Log("Villager is patrolling...");
    }

    public void Attack()
    {
        // Vi phạm ISP:
        throw new System.NotImplementedException("Villager does not support Attack()");
    }

    public void ChasePlayer()
    {
        // Vi phạm ISP:
        throw new System.NotImplementedException("Villager does not support ChasePlayer()");
    }
}

// ✅ Villager chỉ implement những gì cần
//public class Villager : MonoBehaviour, IAttribute, IPatrol
//{
//    public int Health { get; set; } = 100;
//    public float Speed { get; set; } = 2f;

//    public void Patrol()
//    {
//        Debug.Log("Villager patrolling...");
//        transform.Translate(Vector3.right * Speed * Time.deltaTime);
//    }
//}