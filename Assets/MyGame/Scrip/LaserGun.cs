using UnityEngine;

public class LaserGun : MonoBehaviour , IWeapon
{
    public void Shoot()
    {
        Debug.Log("Pew Pew!");
    }
}
