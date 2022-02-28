/****************************************************
    文件：WindowRoot.cs
	作者：靳万朋
    邮箱: 2604591896@qq.com
    日期：2022/2/28 15:2:8
	功能：Nothing
*****************************************************/

using UnityEngine;

public class WindowRoot : MonoBehaviour 
{
    public ResSvc resSvc = null;

    public void SetWndState(bool isActive=true)
    {
        if (gameObject.activeSelf != isActive)
        {
            gameObject.SetActive(isActive);
        }
        if (isActive)
        {
            InitWnd();
        }
        else
        {
            ClearWnd();
        }
    }

    protected virtual void InitWnd()
    {
        resSvc = ResSvc.Instance;
    }
    protected virtual void ClearWnd()
    {
        resSvc = null;
    }
}