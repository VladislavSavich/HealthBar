using UnityEngine;
using UnityEngine.UI;

public abstract class HealthChanger : MonoBehaviour
{
    [SerializeField] protected Health Target;
    [SerializeField] protected Button Button;

    protected virtual void OnEnable()
    {
        Button.onClick.AddListener(ChangeValue);
    }

    protected virtual void OnDisable()
    {
        Button.onClick.RemoveListener(ChangeValue);
    }

    protected abstract void ChangeValue();
}
