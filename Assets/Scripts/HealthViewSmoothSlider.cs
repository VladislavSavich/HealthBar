using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthViewSmoothSlider : HealthView
{
    [SerializeField] private Slider _smoothSlider;

    private float _stepValue = 10f;
    private Coroutine _smoothCoroutine;

    protected override void UpdateView()
    {
        if (_smoothSlider != null)
        {
            if (_smoothCoroutine != null)
                StopCoroutine(_smoothCoroutine);

            _smoothCoroutine = StartCoroutine(ChangeSliderValue());
        }
    }

    private IEnumerator ChangeSliderValue()
    {
        while (enabled)
        {
            _smoothSlider.value = Mathf.MoveTowards(_smoothSlider.value, Health.HitCount, _stepValue * Time.deltaTime);

            yield return null;
        }
    }
}
