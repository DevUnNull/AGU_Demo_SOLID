using UnityEngine;

public class Kiem : Weapon
{
    public Sprite sprite;

    public override KeyCode WeaponKey => KeyCode.Alpha3;

    public override Sprite WeaponSprite => sprite;
}