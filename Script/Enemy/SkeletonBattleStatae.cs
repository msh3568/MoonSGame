using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonBattleStatae : EnemyState
{
    private Transform player;
    private EnemySkeleton enemy;
    private int moveDir;
    public SkeletonBattleStatae(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBoolName, EnemySkeleton enemy) : base(_enemyBase, _stateMachine, _animBoolName)
    {
        this.enemy = enemy;
    }

    public override void Enter()
    {
        base.Enter();
        player = GameObject.Find("player").transform;
    }

    public override void Update()
    {
        base.Update();

        if (enemy.IsPlayerDetected())
        {
            if (enemy.IsPlayerDetected().distance < enemy.attackDistance)
            {
                enemy.ZeroVelocity();
                return;
            }
        }
        if (player.position.x > enemy.transform.position.x)
        {
            moveDir = 1;
        }
        else if (player.position.x > enemy.transform.position.x)
        {
            moveDir = -1;
        }

        enemy.SetVelocity(enemy.moveSpeed * moveDir, rb.velocity.y);
    }

    public override void Exit()
    {
        base.Exit();
    }


}
