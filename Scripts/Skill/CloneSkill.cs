using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneSkill : Skill
{
    [Header("�� �׸��� �нż��� ���� ������!!! �㿣�� �� �ϰ� ���� ������!!")]
    [SerializeField] private GameObject clonePrefab;
    [SerializeField] private float cloneDuration;

    public void CreatClone(Transform _clonPosition)
    {
        GameObject newClone = Instantiate(clonePrefab);

        newClone.GetComponent<ClonSkillController>().SetupClone(_clonPosition,cloneDuration);
    }
}
