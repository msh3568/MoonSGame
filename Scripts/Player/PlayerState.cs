using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PlayerState 클래스: 플레이어 상태의 기본 클래스, 모든 플레이어 상태 클래스의 부모 클래스
public class PlayerState
{
    protected PlayerStateMachine stateMachine; // 플레이어 상태 머신
    protected Player player; // 플레이어 인스턴스

    protected Rigidbody2D rb; // 플레이어의 Rigidbody2D 컴포넌트

    protected float xInput; // 수평 입력 값
    protected float yInput; // 수직 입력 값
    private string animBoolName; // 애니메이션 상태를 제어하는 변수 이름

    protected float stateTimer; // 상태 타이머, 특정 상태의 지속 시간 관리
    protected bool triggerCalled; // 애니메이션 트리거가 호출되었는지 여부

    public PlayerState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName)
    {
        this.player = _player;
        this.stateMachine = _stateMachine;
        this.animBoolName = _animBoolName;
    }

    public virtual void Enter()
    {
        // 상태 진입 시 애니메이션 상태 활성화
        player.anim.SetBool(animBoolName, true);
        rb = player.rb;
        triggerCalled = false;
    }

    public virtual void Update()
    {
        // 상태 타이머 감소
        stateTimer -= Time.deltaTime;

        // 입력 값 업데이트
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
        player.anim.SetFloat("yVelocity", rb.velocity.y); // 애니메이션에 수직 속도 전달
    }

    public virtual void Exit()
    {
        // 상태 종료 시 애니메이션 상태 비활성화
        player.anim.SetBool(animBoolName, false);
    }

    public virtual void AnimationFinishTrigger()
    {
        // 애니메이션 트리거가 호출되었음을 표시
        triggerCalled = true;
    }
}
