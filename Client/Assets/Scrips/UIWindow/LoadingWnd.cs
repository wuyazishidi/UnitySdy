/*/****************************************************
    文件：LoadingWnd.cs
	作者：靳万朋
    邮箱: 2604591896@qq.com
    日期：2022/2/27 14:13:14
	功能：加载进度条
*****************************************************/

using UnityEngine;
using UnityEngine.UI;

public class LoadingWnd : WindowRoot 
{
    public Text txtTips;
    public Image imgFG;
    public Image imgPoint;
    public Text txtPrg;
    private float fgWidth;
    protected override void InitWnd()
    {
        base.InitWnd();
        fgWidth = imgFG.GetComponent<RectTransform>().sizeDelta.x;
        SetText(txtTips, "这是一条游戏Tips");
        txtPrg.text = "0%";
        imgFG.fillAmount = 0;
        imgPoint.transform.localPosition = new Vector3(-545f,0,0);
    }

    public void SetProgress(float prg)
    {
        SetText(txtPrg, (int)(prg * 100) + "%");
        imgFG.fillAmount = prg;
        float posX = prg * fgWidth - 545;
        imgPoint.GetComponent<RectTransform>().anchoredPosition = new Vector2(posX,0);
    }
}