using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int hitPoints;
    public int totalHP;
    private void Start()
    {
        hitPoints = totalHP;
    }

    public void Damage(int damage)
    {
        hitPoints -= damage;
    }

    public void Heal(int heal)
    {
        hitPoints += heal;
    }
}
