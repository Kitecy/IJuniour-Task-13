using UnityEngine;
using UnityEngine.UI;

public class ImageHealthBar : HealthBar
{
    [SerializeField] private Image _bar;

    protected override void OnDamaged(int health)
    {
        _bar.fillAmount = (float)health / maxHealth;
    }
}
