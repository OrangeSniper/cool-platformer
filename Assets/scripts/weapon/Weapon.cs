using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon : MonoBehaviour
{
    public GameObject firePoint;

    private PlayerInputActions inputActions;

    [SerializeField]private WeaponAsset weaponType;

    public void PrimFire(InputAction.CallbackContext context)
    {
        Debug.Log("primary Fire");
    }

    public void AltFire(InputAction.CallbackContext context)
    {
        Debug.Log("alternate Fire");
    }
}
