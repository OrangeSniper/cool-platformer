using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "simple weapon", menuName = "my scriptable objects/simple weapon")]
public class WeaponAsset : ScriptableObject
{
    public string weaponName;

    public Sprite weaponSprite;
    public Sprite bulletSprite;

    public float damage;
}
