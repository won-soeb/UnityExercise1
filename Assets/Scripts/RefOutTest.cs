using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefOutTest : MonoBehaviour
{
    private int normalValue = 1;//�ʱⰪ 1
    private int refValue = 1;
    private int outValue;//�ʱ�ȭ �ʿ� ����
    void Start()
    {
        //�ʱ�ȭ�� ������
        //�޼ҵ� ȣ��
        //ȣ���� ������ ��
        Debug.LogFormat("SetNormalValueȣ���� : {0}", normalValue);
        SetNormalValue(normalValue);
        Debug.LogFormat("SetNormalValueȣ���� : {0}", normalValue);
        
        Debug.LogFormat("SetRefValueȣ���� : {0}", refValue);
        SetRefValue(ref refValue);
        Debug.LogFormat("SetRefValueȣ���� : {0}", refValue);
        
        Debug.LogFormat("SetOutValueȣ���� : {0}", outValue);
        SetOutValue(out outValue);
        Debug.LogFormat("SetOutValueȣ���� : {0}", outValue);
    }
    //�Ϲ� �Ű�����
    private void SetNormalValue(int value)
    {
        value = 0;
        Debug.LogFormat("SetNormalValue���� {0}�� ȣ��", value);
    }//���� �������� ���� 0���� �����Ѵ�.

    //ref�Ű�����
    private void SetRefValue(ref int value)
    {
        value = 0;
        Debug.LogFormat("SetRefValue {0}�� ȣ��", value);
    }
    //out�Ű�����
    private void SetOutValue(out int value)
    {
        value = 1;
        Debug.LogFormat("SetOutValue {0}�� ȣ��", value);
    }
}
