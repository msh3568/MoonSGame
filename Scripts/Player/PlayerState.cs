using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PlayerState Ŭ����: �÷��̾� ������ �⺻ Ŭ����, ��� �÷��̾� ���� Ŭ������ �θ� Ŭ����
public class PlayerState
{
    protected PlayerStateMachine stateMachine; // �÷��̾� ���� �ӽ�
    protected Player player; // �÷��̾� �ν��Ͻ�

    protected Rigidbody2D rb; // �÷��̾��� Rigidbody2D ������Ʈ

    protected float xInput; // ���� �Է� ��
    protected float yInput; // ���� �Է� ��
    private string animBoolName; // �ִϸ��̼� ���¸� �����ϴ� ���� �̸�

    protected float stateTimer; // ���� Ÿ�̸�, Ư�� ������ ���� �ð� ����
    protected bool triggerCalled; // �ִϸ��̼� Ʈ���Ű� ȣ��Ǿ����� ����

    public PlayerState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName)
    {
        this.player = _player;
        this.stateMachine = _stateMachine;
        this.animBoolName = _animBoolName;
    }

    public virtual void Enter()
    {
        // ���� ���� �� �ִϸ��̼� ���� Ȱ��ȭ
        player.anim.SetBool(animBoolName, true);
        rb = player.rb;
        triggerCalled = false;
    }

    public virtual void Update()
    {
        // ���� Ÿ�̸� ����
        stateTimer -= Time.deltaTime;

        // �Է� �� ������Ʈ
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
        player.anim.SetFloat("yVelocity", rb.velocity.y); // �ִϸ��̼ǿ� ���� �ӵ� ����
    }

    public virtual void Exit()
    {
        // ���� ���� �� �ִϸ��̼� ���� ��Ȱ��ȭ
        player.anim.SetBool(animBoolName, false);
    }

    public virtual void AnimationFinishTrigger()
    {
        // �ִϸ��̼� Ʈ���Ű� ȣ��Ǿ����� ǥ��
        triggerCalled = true;
    }
}
