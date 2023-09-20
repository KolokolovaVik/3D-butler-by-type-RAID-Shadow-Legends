using System.Collections;
using System.Collections.Generic;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Character _player;
    [SerializeField] private Character _enemy;

    private IEnumerator Start()
    {
        while (true)
        {
            if (_player.Health > 0 && _enemy.Health > 0)
            {
                yield return _player.Attack(_enemy);
            }

            yield return new WaitForSeconds(1f);

            if (_player.Health > 0 && _enemy.Health > 0)
            {
               yield return _enemy.Attack(_player);
            }

            yield return new WaitForSeconds(1f);

            if (_player.Health == 0 || _enemy.Health == 0)
            {
                Debug.Log($"{GetType().Name}._player.Health = {_player.Health}. _enemy.Health = {_enemy.Health}. -  {Time.time} ");
                yield break;
            }
        }
    }
}
