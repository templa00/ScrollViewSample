using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// スクロールビューコントロール
/// </summary>
public class ScrollViewCtrl : MonoBehaviour
{
    /// <summary>
    /// コンテンツの短径の情報
    /// </summary>
    [SerializeField]
    private RectTransform contentRect = null;

    /// <summary>
    /// ステージリスト
    /// </summary>
    [SerializeField]
    private GameObject stageListObj = null;

    /// <summary>
    /// ボタンオブジェクト
    /// </summary>
    [SerializeField]
    private GameObject baseBtnObj = null;

    /// <summary>
    /// 開始
    /// </summary>
    void Start ()
    {
        // ボタン生成
        CreateButton(100);
    }

    /// <summary>
    /// ボタン生成
    /// </summary>
    /// <param name="_num">個数</param>
    private void CreateButton (int _num)
    {
        // ゲームオブジェクトとしてプレファブ(object)を読み込みます。
        var obj = Instantiate(Resources.Load("Prefabs/Button")) as GameObject;

        for (int i = 0; i < _num; i++)
        {
            // objをGameObjectとしてcopy_objに複製する。
            var copy_obj = UnityEngine.Object.Instantiate(obj) as GameObject;

            copy_obj.transform.parent = stageListObj.transform;

            copy_obj.GetComponent<ButtonCtrl>().text.text = string.Format("ステージ {0}", i + 1);
        }
    }
}
