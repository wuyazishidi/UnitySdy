/*/****************************************************
    文件：GameRoot.cs
	作者：靳万朋
    邮箱: 2604591896@qq.com
    日期：2022/2/27 13:48:7
	功能：游戏的启动入口
*****************************************************/

using UnityEngine;

public class GameRoot : MonoBehaviour 
{
    public static GameRoot Instance = null;
    public LoadingWnd loadingWnd;
    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(this);
        Debug.Log("Game Start...");
        Init();
    }

    private void Init()
    {
        //服务模块初始化
        ResSvc res = GetComponent<ResSvc>();
        res.InitSvc();
        //业务系统初始化
        LoginSys login = GetComponent<LoginSys>();
        login.InitSys();

        //进入登陆场景并加载相应的UI
        login.EnterLogin();
    }
}