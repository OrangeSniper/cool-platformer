using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHandler : MonoBehaviour
{
    private Inventory inventory;

    private void Awake()
    {
        inventory = new Inventory();
    }
}
