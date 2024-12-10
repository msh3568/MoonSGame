using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneSkill : Skill
{
    [Header("이 그림자 분신술은 뭐냐 나루토!!! 쥐엔장 난 니가 좋다 나루토!!")]
    [SerializeField] private GameObject clonePrefab;
    [SerializeField] private float cloneDuration;

    public void CreatClone(Transform _clonPosition)
    {
        GameObject newClone = Instantiate(clonePrefab);

        newClone.GetComponent<ClonSkillController>().SetupClone(_clonPosition,cloneDuration);
    }
}
