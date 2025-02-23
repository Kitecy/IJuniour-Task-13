using TMPro;
using UnityEngine;

public class TextHealthBar : HealthBar
{
    [SerializeField] private TMP_Text _text;

    protected override void OnDamaged(int health)
    {
        _text.text = $"{health}/{Health.MaxHealth}";
    }
}