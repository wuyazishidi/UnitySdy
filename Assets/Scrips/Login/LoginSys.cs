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
    public void InitSys()
    {
        Debug.Log("Init LoginSys...");
    }
    public void EnterLogin()
    {
        //TODO
        //异步加载登录场景
        ResSvc.Instance.AsyncLoadScene(Constants.SceneLogin);
        GameRoot.Instance.loadingWnd.gameObject.SetActive(true);
        //并显示加载的进度
        //加载完成后打开注册登录界面
    }
}