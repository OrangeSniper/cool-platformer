using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstEnemy : BehaviorAddBase
{

    private BoxCollider2D boxCollider;

    private int track;

    public int damage = 5;
    public override void Track0()
    {
        Debug.Log("track 0");
        track = 0;
    }

    public override void Track1()
    {
        Debug.Log("track 1");
        track = 1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(track == 0 && collision.collider.CompareTag("Player"))
        {
            GameObject player = collision.collider.gameObject;
            player.GetComponent<PlayerHP>().Damage(damage);
        }
    }
}
