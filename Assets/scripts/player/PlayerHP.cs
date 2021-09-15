using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHP : MonoBehaviour
{
    public int hitPoints;
    public int totalHP;

    public Slider hpBar;
    public TMP_Text hpText;

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
        hpText.text = hitPoints + "/" + totalHP;
    }
}
