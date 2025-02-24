using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int _health;

    public event Action<int> HealthChanged;
    public event Action Died;

    [field: SerializeField]
    public int MaxHealth { get; private set; }

    private void Awake()
    {
        _health = MaxHealth;
    }

    public void TakeDamage(int damage)
    {
        _health -= Mathf.Clamp(damage, 0, MaxHealth);
        HealthChanged?.Invoke(_health);

        if (_health <= 0)
            Kill();
    }

    public void Heal(int value)
    {
        _health += Math.Clamp(value, 0, int.MaxValue);
        HealthChanged?.Invoke(_health);
    }

    private void Kill()
    {
        Died?.Invoke();
    }
}