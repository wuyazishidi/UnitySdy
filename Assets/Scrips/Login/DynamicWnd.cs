/****************************************************
    文件：DynamicWnd.cs
	作者：靳万朋
    邮箱: 2604591896@qq.com
    日期：2022/3/1 15:6:43
	功能：Nothing
*****************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicWnd : WindowRoot 
{
    public Animation tipsAni;
    public Text txtTips;
    private bool isTipsShow = false;
    private Queue<string> tipsQue = new Queue<string>(); 

    protected override void InitWnd()
    {
        base.InitWnd();
        SetActive(txtTips,false);
    }

    private void Update()
    {
        if (tipsQue.Count > 0&&isTipsShow==false)
        {
            lock (tipsQue)
            {
                string tips = tipsQue.Dequeue();
                isTipsShow = true;
                SetTips(tips);
            }
        }
    }

    public void AddTips(string tips)
    {
        lock (tipsQue)
        {
            tipsQue.Enqueue(tips);
        }
    }


    private void SetTips(string tips)
    {
        SetActive(txtTips);
        SetText(txtTips,tips);
        AnimationClip clip = tipsAni.GetClip("tipsShowAni");
        tipsAni.Play();
        StartCoroutine(AniPlayDone(clip.length,()=> {
            SetActive(txtTips,false);
            isTipsShow = false;
        }));
    }

    private IEnumerator AniPlayDone(float sec, Action cb)
    {
        yield return new WaitForSeconds(sec);
        if (cb != null)
        {
            cb();
        }
    }

}