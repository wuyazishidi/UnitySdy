/****************************************************
    文件：SystemRoot.cs
	作者：靳万朋
    邮箱: 2604591896@qq.com
    日期：2022/3/1 14:39:59
	功能：业务系统基类
*****************************************************/

using UnityEngine;

public class SystemRoot : MonoBehaviour 
{
    protected ResSvc resSvc;
    protected AudioSvc audioSvc;

    public virtual void InitSys()
    {
        resSvc = ResSvc.Instance;
        audioSvc = AudioSvc.Instance;
    }
}