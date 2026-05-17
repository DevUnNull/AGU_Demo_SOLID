using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
 
    
    
    public abstract KeyCode WeaponKey { get; }
    public abstract Sprite WeaponSprite { get; }


    public virtual void Attack(Transform weaponHolder, Vector3 normalScale)
    {
        weaponHolder.localScale = normalScale * 1.5f;
    }
    public virtual void StopAttack(Transform weaponHolder, Vector3 normalScale)
    {
        weaponHolder.localScale = normalScale;
    }
}