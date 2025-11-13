using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] private Health _target;

    private int _damage = 10;

    public void DealDamage()
    {
        if (_target != null && _target.HealthCount > 0)
        {
            _target.TakeDamage(_damage);
        }
    }
}
