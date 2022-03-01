/*/****************************************************
    文件：LoginSys.cs
	作者：靳万朋
    邮箱: 2604591896@qq.com
    日期：2022/2/27 13:50:36
	功能：登录注册业务系统
*****************************************************/

using UnityEngine;

public class LoginSys : SystemRoot
{
    public static LoginSys Instance = null;
    public LoginWnd loginWnd;
    public CreateWnd createWnd;
    public override void InitSys()
    {
        base.InitSys();
        Instance = this;
        Debug.Log("Init LoginSys...");
    }

    /// <summary>
    /// 进入登录场景
    /// </summary>
    public void EnterLogin()
    {
        //TODO
        //异步加载登录场景
        //并显示加载的进度
        resSvc.AsyncLoadScene(Constants.SceneLogin, () =>
        {
            //加载完成后打开注册登录界面
            loginWnd.SetWndState();
            audioSvc.PlayBGMusic(Constants.BGLogin);
            GameRoot.AddTips("Load Done1");
            GameRoot.AddTips("Load Done1");
            GameRoot.AddTips("Load Done2");
        });
    }

    public void RspLogin()
    {
        GameRoot.AddTips("登陆成功");
        //打开角色创建面板
        createWnd.SetWndState();
        //关闭登录界面
        loginWnd.SetWndState(false);
    }    

    public void OpenLoginWnd()
    {
        loginWnd.SetWndState();
    }
}