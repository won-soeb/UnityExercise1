using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public int MaxHp
    {
        get; set;
    }

    public int Hp
    {
        get; set;
    }

    public Action onHit;

    private void Start()
    {
        this.MaxHp = 10;
        this.Hp = this.MaxHp;
        Debug.LogFormat("{0}/{1}", this.Hp, this.MaxHp);
    }

    void Update()
    {
        //ȭ���� Ŭ���ϸ� ���ظ� �޴´� 
        if (Input.GetMouseButtonDown(0))
        {
            this.Hp -= 1;
            if (this.Hp <= 0) this.Hp = 0;
            Debug.LogFormat("{0}/{1}", this.Hp, this.MaxHp);

            this.onHit();   //�븮�� ȣ�� 
        }
    }
}
