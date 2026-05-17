using UnityEngine;

public class Con : Weapon
{
    public Sprite sprite;

    public override KeyCode WeaponKey => KeyCode.Alpha2;

    public override Sprite WeaponSprite => sprite;
}