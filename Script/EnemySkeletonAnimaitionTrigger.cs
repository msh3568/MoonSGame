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
        // 공격 범위 내의 모든 콜라이더 찾기
        Collider2D[] colliders = Physics2D.OverlapCircleAll(enemy.attackCheck.position, enemy.attackCheckRadius);

        foreach (var hit in colliders)
        {
            if (hit.GetComponent<Player>() != null)
            {
                // 공격이 성공하면 플레이어에게 데미지
                hit.GetComponent<Player>().Damage();
            }
        }
    }
    private void OpenCounterWindow() => enemy.OpenCounterAttackWindow();
    private void CloseCounterWindow() => enemy.CloseCounterAttackWindow();
    */
}
