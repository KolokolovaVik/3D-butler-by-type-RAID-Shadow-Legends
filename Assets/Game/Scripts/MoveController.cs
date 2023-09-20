using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class MoveController : MonoBehaviour
{
    [SerializeField] Player player;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player.Move(Vector3.forward);
            return;
        }

        if (Input.GetKey(KeyCode.S))
        {
            player.Move(Vector3.back);
            return;
        }

        if (Input.GetKey(KeyCode.A))
        {
            player.Move(Vector3.left);
            return;
        }

        if (Input.GetKey(KeyCode.D))
        {
            player.Move(Vector3.right);
            return;
        }
    }
}
