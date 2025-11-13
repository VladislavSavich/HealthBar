using UnityEngine;

public class Healer : HealthChanger
{
    private int _healPoint = 10;

    protected override void ChangeValue()
    {
        if (Target != null)
        {
            Target.TakeHeal(_healPoint);
        }
    }
}
