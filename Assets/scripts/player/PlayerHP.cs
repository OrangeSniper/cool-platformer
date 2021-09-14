using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public int hitPoints;
    public int totalHP;

    public Slider hpBar;

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

    private void Update()
    {
        hpBar.value = (float)hitPoints / totalHP;
    }
}
