using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon
{
    public GameObject firePoint;

    private PlayerInputActions inputActions;


    public void PrimFire(InputAction.CallbackContext context)
    {
        Debug.Log("primary Fire");
    }

    public void AltFire(InputAction.CallbackContext context)
    {
        Debug.Log("alternate Fire");
    }
}
