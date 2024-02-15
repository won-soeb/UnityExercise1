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
    //���Ϸ� ������ ������
    private List<string> data;
    //������ ������
    string path;
    private void Awake()
    {
        //������ ������ ������ ���� ����/�б⺸�� �ݵ�� ���� �ؾ���.
        path = Application.persistentDataPath + "/data_sample.json";
        //Application.persistentDataPath : �÷��� OS�� ���� ��θ� �ڵ����� �����
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
            Debug.Log("������ �����߽��ϴ�.");
        });
        loadButton.onClick.AddListener(() =>
        {
            LoadData();
            Debug.Log("������ �ε��߽��ϴ�.");
        });
    }
    private void SaveData()
    {
        //����Ʈ�� ����� ���ڵ��� json���� ����ȭ
        string json = JsonConvert.SerializeObject(data);
        Debug.Log(path);
        //���Ϸ� ���� 
        File.WriteAllText(path, json);
        //���Ϸ� ����Ϸ� 
    }
    //���� �о����
    private void LoadData()
    {
        //1.���� ���� �б�-������ ���� ��� ����ó���Ұ�
        string fileData = File.ReadAllText(path);
        //2.���ҽ� ���� �б�-����Ƽ ���ҽ� ���Ͽ� json������ �����ؾ���
        //TextAsset asset = Resources.Load<TextAsset>("data_sample");
        //string json = asset.text;
        //1.���� ������ �����͸� ������ȭ
        string[] data = JsonConvert.DeserializeObject<string[]>(fileData);
        //2.���ҽ� ������ �����͸� ������ȭ
        //string[] data = JsonConvert.DeserializeObject<string[]>(json);
        foreach (string word in data)
        {
            Debug.Log("Load : " + word);
        }
    }
}
