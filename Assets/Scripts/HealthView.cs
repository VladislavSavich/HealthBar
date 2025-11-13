using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthView : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private TextMeshProUGUI _healPoints;
    [SerializeField] private Slider _healSlider;
    [SerializeField] private Slider _smoothHealSlider;

    private float _stepValue = 10f;
    private Coroutine _smoothCoroutine;

    private void OnEnable()
    {
        _health.Changed += UpdateHealthView;
    }

    private void OnDisable()
    {
        _health.Changed -= UpdateHealthView;
    }

    private void UpdateHealthView()
    {
        if (_healPoints && _healSlider && _smoothHealSlider != null)
        {
            _healPoints.text = $"{_health.HealthCount}/{_health.MaxHealthCount}";
            _healSlider.value = _health.HealthCount;

            if (_smoothCoroutine != null)
                StopCoroutine(_smoothCoroutine);

            _smoothCoroutine = StartCoroutine(ChangeSliderValue());
        }
    }

    private IEnumerator ChangeSliderValue()
    {
        while (enabled)
        {
            _smoothHealSlider.value = Mathf.MoveTowards(_smoothHealSlider.value, _health.HealthCount, _stepValue * Time.deltaTime);

            yield return null;
        }
    }
}
