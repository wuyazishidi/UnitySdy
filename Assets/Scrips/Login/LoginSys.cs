/*/****************************************************
    文件：LoginSys.cs
	作者：靳万朋
    邮箱: 2604591896@qq.com
    日期：2022/2/27 13:50:36
	功能：登录注册业务系统
*****************************************************/

using UnityEngine;

public class LoginSys : MonoBehaviour 
{
    public static LoginSys Instance = null;
    public LoginWnd loginWnd;
    public void InitSys()
    {
        Instance = this;
        Debug.Log("Init LoginSys...");
    }
    public void EnterLogin()
    {
       
        //TODO
        //异步加载登录场景
        ResSvc.Instance.AsyncLoadScene(Constants.SceneLogin,()=> {
            //加载完成后打开注册登录界面
            loginWnd.gameObject.SetActive(true);
            loginWnd.InitWnd();
        });
        //并显示加载的进度
    }

    public void OpenLoginWnd()
    {
        loginWnd.gameObject.SetActive(true);
        loginWnd.InitWnd();
    }
}