using UnityEngine;
using UnityEngine.UI;

public class HealthViewSlider : HealthView
{
    [SerializeField] private Slider _slider;

    protected override void UpdateView()
    {
        if (_slider != null)
            _slider.value = Health.HitCount;
    }
}
