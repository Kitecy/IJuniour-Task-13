using UnityEngine;
using UnityEngine.UI;

public class ImageHealthBar : HealthBar
{
    [SerializeField] private Slider _slider;

    private void Awake()
    {
        _slider.maxValue = Health.MaxHealth;
        _slider.value = Health.MaxHealth;
    }

    protected override void OnDamaged(int health)
    {
        _slider.value = health;
    }
}
