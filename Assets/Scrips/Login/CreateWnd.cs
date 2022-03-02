/****************************************************
    文件：CreateWnd.cs
	作者：靳万朋
    邮箱: 2604591896@qq.com
    日期：2022/3/1 16:21:24
	功能：角色创建面板
*****************************************************/

using UnityEngine;
using UnityEngine.UI;

public class CreateWnd :  WindowRoot
{
    public InputField iptName;
    protected override void InitWnd()
    {
        base.InitWnd();
        //TODO
        //显示一个随机的名字
        iptName.text=resSvc.GetRDNameData(false);
    }

    public void ClickRandBtn()
    {
        audioSvc.PlayUIAudio(Constants.UIClickBtn);
        string rdName = resSvc.GetRDNameData();
        iptName.text = rdName;
    }    

    public void ClickEnterBtn()
    {
        audioSvc.PlayUIAudio(Constants.UIClickBtn);
        if (iptName.text != "")
        { 
        //TODO
        //发送名字数据到服务器，登录主城
        }
        else
        {
            GameRoot.AddTips("当前名字不符合规范");
        }
    }
}