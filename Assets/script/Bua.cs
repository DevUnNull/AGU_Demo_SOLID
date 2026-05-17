using UnityEngine;

public class Bua : Weapon
{
    public Sprite sprite;

    public override KeyCode WeaponKey => KeyCode.Alpha1;

    public override Sprite WeaponSprite => sprite;
}