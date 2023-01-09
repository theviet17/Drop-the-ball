using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane : MonoBehaviour
{
    [SerializeField] public SpawnTargetBall tg;
    [SerializeField] public flow fl;

    public void reup()
    {
        gameObject.transform.position = gameObject.transform.position + new Vector3(0, -2.6f, 0);
        tg.SpawnTerrain();
        fl.flowplane();
        tg.SpawnTerrain2();

    }
}
