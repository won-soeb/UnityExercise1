using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleToneMain : MonoBehaviour
{
    //�̱��� ������
    public static readonly SingleToneMain Instance = new SingleToneMain();
    private SingleToneMain()
    {
        //�����ڸ� private���� �����Ѵ�.
    }
    public void Access()
    {
        Debug.Log("�̱��� �޼ҵ� ȣ��");
    }
}
