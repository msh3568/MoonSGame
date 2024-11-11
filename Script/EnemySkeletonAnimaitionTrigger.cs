using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySkeletonAnimaitionTrigger : MonoBehaviour
{
    private EnemySkeleton enemy => GetComponentInParent<EnemySkeleton>();

    private void AnimaitionTrigger()
    {
        enemy.AnimaitionFinishTrigger();
    }

    private void AttackTrigger()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(enemy.attackCheck.position, enemy.attackCheckRadius);

        foreach(var hit in colliders)
        {
            if (hit.GetComponent<Player>() != null)
                hit.GetComponent<Player>().Damge();

        }
    }
}
