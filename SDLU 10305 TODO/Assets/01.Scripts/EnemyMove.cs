using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : EntityBase
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Dead();
    }
}
