using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScene : MonoBehaviour
{
    private CubeData cubeData;
    void Start()
    {
        this.cubeData = GameObject.FindAnyObjectByType<CubeData>();
        Debug.LogFormat("{0}/{1}", this.cubeData.GetHeroHp(), cubeData.GetHeroMaxHp());
    }
}