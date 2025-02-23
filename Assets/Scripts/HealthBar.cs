using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] protected Health Health;

    private void OnEnable()
    {
        Health.HealthChanged += OnDamaged;
    }

    private void OnDisable()
    {
        Health.HealthChanged -= OnDamaged;
    }

    protected abstract void OnDamaged(int health);
}
