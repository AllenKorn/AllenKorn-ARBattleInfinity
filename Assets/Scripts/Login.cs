using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Login : MonoBehaviour
{
    [Header("登录界面")]
    public GameObject loginPanel;

    [Header("用户名输入框")]
    public InputField ID;

    [Header("用户密码输入框")]
    public InputField PW;

    [Header("登录按钮")]
    public Button loginButton;

    [Header("注册按钮")]
    public Button registerButton;

    [Header("错误提示：账号或密码错误")]
    public GameObject loginError1;

    [Header("错误提示：无网络")]
    public GameObject loginError2;


    [Header("注册界面")]
    public GameObject registerPanl;

    [Header("设置用户名")]
    public InputField id;

    [Header("设置密码")]
    public InputField pw;

    [Header("确认密码")]
    public InputField pw1;

    [Header("确认注册")]
    public Button register;

    [Header("返回按钮")]
    public Button retur;

    [Header("错误提示:用户名重复")]
    public GameObject registerError1;

    [Header("错误提示:两次密码不一致")]
    public GameObject registerError2;

    string pass1;
    string pass2;
    // Start is called before the first frame update
    void Start()
    {
        //登录界面的用户名、密码
        ID = ID.GetComponent<InputField>();
        PW = PW.GetComponent<InputField>();
        //注册页面的用户名、密码、确认密码
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
    #region 登录,进入游戏
    public void OnLoginButton()
    {
        SceneManager.LoadScene("GamingScene");
    }
    #endregion

    #region 打开注册界面
    public void OpenRegisterPanel()
    {
        loginPanel.SetActive(false);
        registerPanl.SetActive(true);

    }
    #endregion

    #region 从注册页面返回登录界面
    public void OnreturnButton()
    {
        registerPanl.SetActive(false);
        loginPanel.SetActive(true);
    }
    #endregion

    #region 注册账号
    public void OnregisterButton()
    {
        registererror1();
        registererror2();
    }
    #endregion

    #region 无网络，抛出错误提示2
    public void loginerror2()
    {
        if (true)
        {
            loginError1.SetActive(true);
        }
    }
    #endregion

    #region 账号或密码错误，抛出错误提示1
    public void loginerror1()
    {
        if (true)
        {
            loginError2.SetActive(true);
        }
    }
    #endregion

    #region 用户名不可用，抛出错误提示1
    public void registererror1()
    {
        if (true)
        {
            registerError1.SetActive(true);
        }
    }
    #endregion

    #region 两次密码输入不一致，抛出错误提示2
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
