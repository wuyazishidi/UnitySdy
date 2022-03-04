/****************************************************
    文件：PETools.cs
	作者：靳万朋
    邮箱: 2604591896@qq.com
    日期：2022/3/2 15:5:17
	功能：工具类
*****************************************************/

using UnityEngine;

public class PETools
{
    public static int RDInt(int min,int max,System.Random rd=null)
    {
        if (rd == null)
        {
            rd = new System.Random();
        }
        int val = rd.Next(min,max+1);
        return val;
    }
}