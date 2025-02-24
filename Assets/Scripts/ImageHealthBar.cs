using UnityEngine;
using UnityEngine.UI;

public class ImageHealthBar : HealthBar
{
    [SerializeField] private Slider _slider;

    private void Awake()
    {
        _slider.maxValue = Health.MaxValue;
        _slider.value = Health.MaxValue;
    }

    protected override void OnDamaged(int health)
    {
        _slider.value = health;
    }
}
