using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public int Health;
    
    public IEnumerator Attack(Character attackedCharacter)
    {
        Debug.Log($"{GetType().Name}.Attack: name = {gameObject.name} => {attackedCharacter.gameObject.name}");

        _animator.SetTrigger("Shoot");
        yield return new WaitForSeconds(2f);

        attackedCharacter.Health -= 1;
        if (attackedCharacter.Health <= 0)
        {
           attackedCharacter.Die();
        }
    }

    private void Die()
    {
        Debug.Log($"{GetType().Name}.Die: name = {name}");
    }
}
