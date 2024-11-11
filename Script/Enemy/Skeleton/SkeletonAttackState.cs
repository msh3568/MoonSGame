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

        // ���� �� ������ ���� �ð��� ����մϴ�.
        enemy.lastTimeAttacked = Time.time;
    }

    public override void Update()
    {
        base.Update();

        // ���� ������ �ִ� ���ȿ��� �̵����� �ʰ� �� �ڸ����� ����
        enemy.SetZeroVelocity();

        if (triggerCalled)
        {
            // ������ ������ Idle ���·� ��ȯ
            stateMachine.ChangeState(enemy.idleState);
        }
    }


}
