using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleToneTest : MonoBehaviour
{
    private void Start()
    {
        SingleToneMain.Instance.Access();
        //�̱��� Ŭ������ �����ϴ� ��
    }
}
