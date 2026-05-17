using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    private Weapon[] weapons;
    private Weapon currentWeapon;
    public SpriteRenderer weaponRenderer;

    private Vector3 normalScale;

    private void Start()
    {
        weapons = GetComponents<Weapon>();

        normalScale = weaponRenderer.transform.localScale;

        if (weapons.Length > 0)
        {
            EquipWeapon(weapons[0]);
        }
    }

    private void Update()
    {
        foreach (Weapon weapon in weapons)
        {
            if (Input.GetKeyDown(weapon.WeaponKey))
            {
                EquipWeapon(weapon);
            }
        }

        if (Input.GetKey(KeyCode.F))
        {
            currentWeapon?.Attack(weaponRenderer.transform, normalScale);
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            currentWeapon?.StopAttack(weaponRenderer.transform, normalScale);
        }
    }

    void EquipWeapon(Weapon weapon)
    {
        currentWeapon = weapon;
        weaponRenderer.sprite = weapon.WeaponSprite;
    }
}