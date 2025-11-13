using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _hitPoints = 100;
    [SerializeField] private int _maxHitPoints = 100;

    public int HealthCount => _hitPoints;
    public int MaxHealthCount => _maxHitPoints;
    public event Action Changed;

    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            _hitPoints -= damage;
            Changed?.Invoke();
        }
    }

    public void TakeHeal(int health)
    {
        if (health > 0)
            _hitPoints += health;

        if (_hitPoints > _maxHitPoints)
            _hitPoints = _maxHitPoints;

        Changed?.Invoke();
    }
}