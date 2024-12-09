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
        player.currentJumpCount = 1; // 점프 횟수 초기화 (public 필드로 변경) // 벽에서 떨어질 때 첫 점프를 사용할 수 있도록 설정
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();

        // 벽 감지 여부 확인
        if (!player.IsWallDetected())
        {
            stateMachine.ChangeState(player.airState); // 벽이 감지되지 않으면 공중 상태로 전환
            return;
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            player.SetVelocity(5 * -player.facingDir, player.jumpForce); // 벽 반대 방향으로 점프하도록 수정
            stateMachine.ChangeState(player.jumpState); // 벽에서 점프할 수 있도록 수정
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