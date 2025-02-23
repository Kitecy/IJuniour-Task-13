using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothImageHealthBar : HealthBar
{
    [SerializeField] private Image _bar;
    [SerializeField] private float _smoothDuration;

    protected override void OnDamaged(int health, int maxHealth)
    {
        StartCoroutine(Show(health, maxHealth));
    }

    private IEnumerator Show(int health, int maxHealth)
    {
        float currentHealth = _bar.fillAmount * maxHealth;
        float time = 0;

        while (time < _smoothDuration)
        {
            time += Time.deltaTime;
            currentHealth = Mathf.MoveTowards(currentHealth, health, (maxHealth / _smoothDuration) * Time.deltaTime);
            _bar.fillAmount = currentHealth / maxHealth;

            yield return null;
        }
    }
}
