using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothImageHealthBar : HealthBar
{
    [SerializeField] private Image _bar;
    [SerializeField] private float _smoothDuration;

    protected override void OnDamaged(int health)
    {
        StartCoroutine(Show(health));
    }

    private IEnumerator Show(int health)
    {
        float currentHealth = _bar.fillAmount * Health.MaxHealth;
        float time = 0;

        while (time < _smoothDuration)
        {
            time += Time.deltaTime;
            currentHealth = Mathf.MoveTowards(currentHealth, health, (Health.MaxHealth / _smoothDuration) * Time.deltaTime);
            _bar.fillAmount = currentHealth / Health.MaxHealth;

            yield return null;
        }
    }
}
