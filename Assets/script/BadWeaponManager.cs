using UnityEngine;

public class BadWeaponManager : MonoBehaviour
{
    public string currentWeapon = "Bua";

    public Sprite BuaSprite;
    public Sprite ConSprite;
    public Sprite KiemSprite;
    public SpriteRenderer weaponRenderer;

    private Vector3 normalScale;

    private void Start()
    {
        normalScale = weaponRenderer.transform.localScale;
        weaponRenderer.sprite = BuaSprite;
    }

    private void Update()
    {
        // Change weapon
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon = "Bua";
            weaponRenderer.sprite = BuaSprite;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentWeapon = "Con";
            weaponRenderer.sprite = ConSprite;
        }

        /*
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentWeapon = "Kiem";
            weaponRenderer.sprite = KiemSprite;
        }
        */

        if (Input.GetKey(KeyCode.F))
        {
            weaponRenderer.transform.localScale = normalScale * 1.5f;
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            weaponRenderer.transform.localScale = normalScale;
        }
    }
}