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

        Debug.Log("아잉 너무 빨리누른거 아니양? 이따 눌러잉!");
        return false;
    }

    public virtual void UseSkill()
    {
           // 스킬을 쓸수있게 해줌ㅇㅇ 아닌가?
    }
}
