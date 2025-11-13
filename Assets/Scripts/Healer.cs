using UnityEngine;

public class Healer : MonoBehaviour
{
    [SerializeField] private Health _target;

    private int _healPoint = 10;

    public void Heal()
    {
        if (_target != null)
        {
            _target.TakeHeal(_healPoint);
        }
    }
}
