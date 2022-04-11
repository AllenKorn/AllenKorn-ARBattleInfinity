using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Login : MonoBehaviour
{
    [Header("��¼����")]
    public GameObject loginPanel;

    [Header("�û��������")]
    public InputField ID;

    [Header("�û����������")]
    public InputField PW;

    [Header("��¼��ť")]
    public Button loginButton;

    [Header("ע�ᰴť")]
    public Button registerButton;

    [Header("������ʾ���˺Ż��������")]
    public GameObject loginError1;

    [Header("������ʾ��������")]
    public GameObject loginError2;


    [Header("ע�����")]
    public GameObject registerPanl;

    [Header("�����û���")]
    public InputField id;

    [Header("��������")]
    public InputField pw;

    [Header("ȷ������")]
    public InputField pw1;

    [Header("ȷ��ע��")]
    public Button register;

    [Header("���ذ�ť")]
    public Button retur;

    [Header("������ʾ:�û����ظ�")]
    public GameObject registerError1;

    [Header("������ʾ:�������벻һ��")]
    public GameObject registerError2;

    string pass1;
    string pass2;
    // Start is called before the first frame update
    void Start()
    {
        //��¼������û���������
        ID = ID.GetComponent<InputField>();
        PW = PW.GetComponent<InputField>();
        //ע��ҳ����û��������롢ȷ������
        id = id.GetComponent<InputField>();
        pw = pw.GetComponent<InputField>();
        pw1 = pw1.GetComponent<InputField>();
        pass1 = pw.text;
        pass2 = pw1.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #region ��¼,������Ϸ
    public void OnLoginButton()
    {
        SceneManager.LoadScene("GamingScene");
    }
    #endregion

    #region ��ע�����
    public void OpenRegisterPanel()
    {
        loginPanel.SetActive(false);
        registerPanl.SetActive(true);

    }
    #endregion

    #region ��ע��ҳ�淵�ص�¼����
    public void OnreturnButton()
    {
        registerPanl.SetActive(false);
        loginPanel.SetActive(true);
    }
    #endregion

    #region ע���˺�
    public void OnregisterButton()
    {
        registererror1();
        registererror2();
    }
    #endregion

    #region �����磬�׳�������ʾ2
    public void loginerror2()
    {
        if (true)
        {
            loginError1.SetActive(true);
        }
    }
    #endregion

    #region �˺Ż���������׳�������ʾ1
    public void loginerror1()
    {
        if (true)
        {
            loginError2.SetActive(true);
        }
    }
    #endregion

    #region �û��������ã��׳�������ʾ1
    public void registererror1()
    {
        if (true)
        {
            registerError1.SetActive(true);
        }
    }
    #endregion

    #region �����������벻һ�£��׳�������ʾ2
    public void registererror2()
    {
        if (pass1==pass2)
        {
            
        }
        else
        {
            registerError2.SetActive(true);
        }
    }
    #endregion
}
