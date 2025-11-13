using TMPro;
using UnityEngine;

public class HealthViewText : HealthView
{
    [SerializeField] private TextMeshProUGUI _text;

    protected override void UpdateView()
    {
        if (_text != null)
            _text.text = $"{Health.HitCount}/{Health.MaxHitCount}";
    }
}
