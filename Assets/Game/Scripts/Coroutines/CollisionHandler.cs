using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    

    public event UnityAction<Enemy> ObstacleCollided;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Enemy enemy))
        {
            ObstacleCollided?.Invoke(enemy);
            _animator.SetTrigger("Death");
        }
    }
}
