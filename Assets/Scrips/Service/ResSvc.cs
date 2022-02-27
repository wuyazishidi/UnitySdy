/*/****************************************************
    文件：ResSvc.cs
	作者：靳万朋
    邮箱: 2604591896@qq.com
    日期：2022/2/27 13:50:17
	功能：资源加载服务
*****************************************************/

using UnityEngine;
using UnityEngine.SceneManagement;

public class ResSvc : MonoBehaviour
{
    public static ResSvc Instance = null;
    public void InitSvc()
    {
        Instance = this;
        Debug.Log("Init ResSvc...");
    }

    public void AsyncLoadScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}