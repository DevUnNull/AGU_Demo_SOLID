using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private IWeapon weapon;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            weapon?.Shoot();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        IWeapon newWeapon = other.GetComponent<IWeapon>();

        if (newWeapon != null)
        {
            weapon = newWeapon;

            Debug.Log("Nhặt vũ khí: " + other.name);
        }
    }
}