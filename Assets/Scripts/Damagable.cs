using System;
using UnityEngine;

public class Damagable : MonoBehaviour
{
    [SerializeField] private int _maxHealth;

    private int _health;

    public event Action<int, int> HealthChanged;
    public event Action Died;

    private void Awake()
    {
        _health = _maxHealth;
    }

    public void TakeDamage(int damage)
    {
        _health -= Mathf.Clamp(damage, 0, _maxHealth);
        HealthChanged?.Invoke(_health, _maxHealth);

        if (_health <= 0)
            Kill();
    }

    public void Regen(int value)
    {
        _health += Math.Clamp(value, 0, int.MaxValue);
        HealthChanged?.Invoke(_health, _maxHealth);
    }

    private void Kill()
    {
        Died?.Invoke();
    }
}