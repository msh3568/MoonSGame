using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonAttackState : EnemyState
{
    private EnemySkeleton enemy;
    public SkeletonAttackState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBoolName, EnemySkeleton _enemy)
        : base(_enemyBase, _stateMachine, _animBoolName)
    {
        this.enemy = _enemy;
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();

        // 공격 후 마지막 공격 시간을 기록합니다.
        enemy.lastTimeAttacked = Time.time;
    }

    public override void Update()
    {
        base.Update();

        // 공격 범위에 있는 동안에는 이동하지 않고 그 자리에서 공격
        enemy.SetZeroVelocity();

        if (triggerCalled)
        {
            // 공격이 끝나면 Idle 상태로 전환
            stateMachine.ChangeState(enemy.idleState);
        }
    }


}
