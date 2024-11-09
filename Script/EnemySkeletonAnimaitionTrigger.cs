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
/*
    private void AttackTrigger()
    {
        // ���� ���� ���� ��� �ݶ��̴� ã��
        Collider2D[] colliders = Physics2D.OverlapCircleAll(enemy.attackCheck.position, enemy.attackCheckRadius);

        foreach (var hit in colliders)
        {
            if (hit.GetComponent<Player>() != null)
            {
                // ������ �����ϸ� �÷��̾�� ������
                hit.GetComponent<Player>().Damage();
            }
        }
    }
    private void OpenCounterWindow() => enemy.OpenCounterAttackWindow();
    private void CloseCounterWindow() => enemy.CloseCounterAttackWindow();
    */
}
