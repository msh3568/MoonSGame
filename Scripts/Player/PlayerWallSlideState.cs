using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWallSlideState : PlayerState
{
    public PlayerWallSlideState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
        player.currentJumpCount = 1; // ���� Ƚ�� �ʱ�ȭ (public �ʵ�� ����) // ������ ������ �� ù ������ ����� �� �ֵ��� ����
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();

        // �� ���� ���� Ȯ��
        if (!player.IsWallDetected())
        {
            stateMachine.ChangeState(player.airState); // ���� �������� ������ ���� ���·� ��ȯ
            return;
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            player.SetVelocity(5 * -player.facingDir, player.jumpForce); // �� �ݴ� �������� �����ϵ��� ����
            stateMachine.ChangeState(player.jumpState); // ������ ������ �� �ֵ��� ����
            return;
        }

        if (xInput != 0 && player.facingDir != xInput)
            stateMachine.ChangeState(player.idleState);

        if (yInput < 0)
            rb.velocity = new Vector2(0, rb.velocity.y);
        else
            rb.velocity = new Vector2(0, rb.velocity.y * .7f);

        if (player.IsGroundDetected())
            stateMachine.ChangeState(player.idleState);
    }
}