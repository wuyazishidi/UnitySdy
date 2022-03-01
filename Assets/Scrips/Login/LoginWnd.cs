/****************************************************
    文件：LoginWnd.cs
	作者：靳万朋
    邮箱: 2604591896@qq.com
    日期：2022/2/28 12:2:40
	功能：登录注册界面
*****************************************************/

using UnityEngine;
using UnityEngine.UI;

public class LoginWnd : WindowRoot 
{
    public InputField iptAcct;
    public InputField iptPass;
    public Button btnEnter;
    public Button btnNotice;
    protected override void InitWnd()
    {
        base.InitWnd();
        //获取本地存储的账号密码
        if (PlayerPrefs.HasKey("Acct")&&PlayerPrefs.HasKey("Pass"))
        {
            iptAcct.text = PlayerPrefs.GetString("Acct");
            iptPass.text = PlayerPrefs.GetString("Pass");
        }
        else
        {
            iptAcct.text = "";
            iptPass.text = "";
        }
    }
    //TODO 更新账号和密码
    /// <summary>
    /// 点击进入游戏
    /// </summary>
    public void ClickEnterBtn()
    {
        audioSvc.PlayUIAudio(Constants.UILoginBtn);
        string acct = iptAcct.text;
        string pass = iptPass.text;
        if (acct != "" && pass != "")
        {
            PlayerPrefs.SetString("Acct",acct);
            PlayerPrefs.SetString("Pass",pass);

        }

    }
}