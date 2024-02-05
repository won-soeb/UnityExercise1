using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefOutTest : MonoBehaviour
{
    private int normalValue = 1;//초기값 1
    private int refValue = 1;
    private int outValue;//초기화 필요 없음
    void Start()
    {
        //초기화한 변수값
        //메소드 호출
        //호출후 변수값 비교
        Debug.LogFormat("SetNormalValue호출전 : {0}", normalValue);
        SetNormalValue(normalValue);
        Debug.LogFormat("SetNormalValue호출후 : {0}", normalValue);
        
        Debug.LogFormat("SetRefValue호출전 : {0}", refValue);
        SetRefValue(ref refValue);
        Debug.LogFormat("SetRefValue호출후 : {0}", refValue);
        
        Debug.LogFormat("SetOutValue호출전 : {0}", outValue);
        SetOutValue(out outValue);
        Debug.LogFormat("SetOutValue호출후 : {0}", outValue);
    }
    //일반 매개변수
    private void SetNormalValue(int value)
    {
        value = 0;
        Debug.LogFormat("SetNormalValue에서 {0}를 호출", value);
    }//내부 로직에서 값을 0으로 변경한다.

    //ref매개변수
    private void SetRefValue(ref int value)
    {
        value = 0;
        Debug.LogFormat("SetRefValue {0}를 호출", value);
    }
    //out매개변수
    private void SetOutValue(out int value)
    {
        value = 1;
        Debug.LogFormat("SetOutValue {0}를 호출", value);
    }
}
