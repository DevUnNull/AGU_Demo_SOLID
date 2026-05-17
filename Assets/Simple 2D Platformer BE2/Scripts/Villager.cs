using UnityEngine;

// Villager buộc phải implement Attack() và ChasePlayer() dù không cần
public class Villager : MonoBehaviour, IGameEntity
{
    public int Health { get; set; } = 100;
    public float Speed { get; set; } = 2f;

    private void Update()
    {
        Patrol();

        // Nhấn A để test Attack()
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Đã bấm nút A");
            Attack();
        }

        // Nhấn C để test ChasePlayer()
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Đã bấm nút C");
            ChasePlayer();
        }
    }

    public void Patrol()
    {
        //Debug.Log("Villager is patrolling...");
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