using UnityEngine;

public class Damager : HealthChanger
{
    private int _damage = 10;

    protected override void ChangeValue()
    {
        if (Target != null && Target.HitCount > 0)
        {
            Target.TakeDamage(_damage);
        }
    }
}
