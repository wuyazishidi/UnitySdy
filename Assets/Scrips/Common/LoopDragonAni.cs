/****************************************************
    文件：LoopDragonAni.cs
	作者：靳万朋
    邮箱: 2604591896@qq.com
    日期：2022/3/1 14:51:51
	功能：飞龙循环动画
*****************************************************/

using UnityEngine;

public class LoopDragonAni : MonoBehaviour
{
    private Animation ani;
    private void Awake()
    {
        ani = transform.GetComponent<Animation>();
    }
    private void Start()
    {
        if (ani != null)
        {
            InvokeRepeating("PlayDragonAni", 0,20);
        }
    }

    private void PlayDragonAni()
    {
        if (ani != null)
        {
            ani.Play();
        }
    }
}