using UnityEngine;

public class Gun : MonoBehaviour , IWeapon
{
    public void Shoot()
    {
        Debug.Log("Bang Bang!");
    }
}
