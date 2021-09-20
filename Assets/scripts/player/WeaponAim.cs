using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAim : MonoBehaviour
{
    public Camera cam;
    public GameObject weapon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 lookDir = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookVector = lookDir - new Vector2(weapon.transform.position.x, weapon.transform.position.y);
        float angle = Mathf.Atan2(lookVector.y, lookVector.x) * Mathf.Rad2Deg;
        weapon.GetComponent<Rigidbody2D>().rotation = angle;
    }
}
