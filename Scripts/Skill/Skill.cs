using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Skill : MonoBehaviour
{
    [SerializeField] protected float cooldown;
    protected float cooldownTimer;

    protected virtual void Update()
    {
        cooldownTimer -= Time.deltaTime;
    }

    public virtual bool CanUseSkill()
    {
        if(cooldownTimer < 0)
        {
            UseSkill();
            cooldownTimer = cooldown;
            return true;
        }

        Debug.Log("���� �ʹ� ���������� �ƴϾ�? �̵� ������!");
        return false;
    }

    public virtual void UseSkill()
    {
           // ��ų�� �����ְ� ���ܤ��� �ƴѰ�?
    }
}
