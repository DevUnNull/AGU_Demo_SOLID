// Interface "fat" — vi phạm ISP
using UnityEngine;

public interface IGameEntity
{
    int Health { get; set; }
    float Speed { get; set; }

    void Attack();
    void Patrol();
    void ChasePlayer();
}

// tách thành các interface nhỏ hơn để tuân thủ ISP
//public interface IAttribute
//{
//    int Health { get; set; }
//    float Speed { get; set; }
//}

//public interface IPatrol
//{
//    void Patrol();
//}

//public interface IAttackable
//{
//    void Attack();
//}
//public interface IChasePlayer
//{
//    void ChasePlayer();
//}