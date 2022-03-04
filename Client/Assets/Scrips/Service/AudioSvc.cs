/****************************************************
    文件：AudioSvc.cs
	作者：靳万朋
    邮箱: 2604591896@qq.com
    日期：2022/3/1 14:12:30
	功能：语音服务
*****************************************************/

using UnityEngine;

public class AudioSvc : MonoBehaviour 
{
    public static AudioSvc Instance = null;
    public AudioSource bgAudio;
    public AudioSource uiAudio;
    public void InitSvc()
    {
        Instance = this;
        Debug.Log("Init AudioSvc...");
    }
    public void PlayBGMusic(string name, bool isLoop = true)
    {
        AudioClip audio = ResSvc.Instance.LoadAudio("ResAudio/"+name,true);
        if (bgAudio.clip == null || bgAudio.clip.name != audio.name)
        {
            bgAudio.clip = audio;
            bgAudio.loop = isLoop;
            bgAudio.Play();
        }
    }

    public void PlayUIAudio(string name)
    {
        AudioClip audio = ResSvc.Instance.LoadAudio("ResAudio/"+name,true);
        uiAudio.clip = audio;
        uiAudio.Play();
    }

  
}