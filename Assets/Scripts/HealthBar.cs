using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] private Damagable _damagable;

    private void OnEnable()
    {
        _damagable.HealthChanged += OnDamaged;
    }

    private void OnDisable()
    {
        _damagable.HealthChanged -= OnDamaged;
    }

    protected abstract void OnDamaged(int health, int maxHealth);
}
