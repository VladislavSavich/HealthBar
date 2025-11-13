using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _hitPoints = 100;
    [SerializeField] private int _maxHitPoints = 100;

    public event Action Changed;
    public int HitCount => _hitPoints;
    public int MaxHitCount => _maxHitPoints;

    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            _hitPoints -= damage;
            Changed?.Invoke();
        }
    }

    public void TakeHeal(int heal)
    {
        if (heal > 0)
            _hitPoints += heal;

        if (_hitPoints > _maxHitPoints)
            _hitPoints = _maxHitPoints;

        Changed?.Invoke();
    }
}