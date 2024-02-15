using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class JsonData : MonoBehaviour
{
    public InputField input;
    public Button saveButton;
    public Button loadButton;
    //파일로 저장할 데이터
    private List<string> data;
    //파일의 저장경로
    string path;
    private void Awake()
    {
        //파일의 저장경로 설정은 파일 저장/읽기보다 반드시 먼저 해야함.
        path = Application.persistentDataPath + "/data_sample.json";
        //Application.persistentDataPath : 플랫폼 OS에 따라 경로를 자동으로 잡아줌
    }
    void Start()
    {
        data = new List<string>();
        input.onSubmit.AddListener(words =>
        {
            data.Add(words);
            Debug.Log("Save : " + words);
        });
        saveButton.onClick.AddListener(() =>
        {
            SaveData();
            Debug.Log("파일을 저장했습니다.");
        });
        loadButton.onClick.AddListener(() =>
        {
            LoadData();
            Debug.Log("파일을 로드했습니다.");
        });
    }
    private void SaveData()
    {
        //리스트에 저장된 문자들을 json으로 직렬화
        string json = JsonConvert.SerializeObject(data);
        Debug.Log(path);
        //파일로 저장 
        File.WriteAllText(path, json);
        //파일로 저장완료 
    }
    //파일 읽어오기
    private void LoadData()
    {
        //1.로컬 파일 읽기-파일이 없을 경우 예외처리할것
        string fileData = File.ReadAllText(path);
        //2.리소스 파일 읽기-유니티 리소스 파일에 json파일이 존재해야함
        //TextAsset asset = Resources.Load<TextAsset>("data_sample");
        //string json = asset.text;
        //1.로컬 파일의 데이터를 역직렬화
        string[] data = JsonConvert.DeserializeObject<string[]>(fileData);
        //2.리소스 파일의 데이터를 역직렬화
        //string[] data = JsonConvert.DeserializeObject<string[]>(json);
        foreach (string word in data)
        {
            Debug.Log("Load : " + word);
        }
    }
}
