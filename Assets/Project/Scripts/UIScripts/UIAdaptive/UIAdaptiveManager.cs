using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public struct UIRectTransformValue
{
    public Vector3 Pos;
    public float left;
    public float right;
    public float bottom;
    public float top;
    public float width;
    public float minuswidth;
    public float height;
    public float minusheight;
}

[Serializable]
public struct UIGridLayoytGroupValue
{
    public int PaddingLeft;
    public int PaddingRight;
    public int PaddingTop;
    public int PaddingBottom;
    public Vector2 CellSize;
    public Vector2 Spacing;
}

public class UIAdaptiveManager : MonoBehaviour
{
    public event Action OnResolutionChangedMobile;
    public event Action OnResolutionChangedPC;

    [SerializeField] private Canvas _canvas;
    public int _screenWidth;
    public int _screenHeight;
    [HideInInspector]
    public CanvasScaler _scaler;

    public float _matchWidthOrHeight;

    private void Awake()
    {
        _scaler = _canvas.GetComponent<CanvasScaler>();
    }

    private void OnEnable()
    {
        GetScreenSize();
        SetCanvasMatch();
    }

    private void Update()
    {
        // 检测屏幕分辨率是否变化
        if (_screenWidth != Screen.width || _screenHeight != Screen.height)
        {
            GetScreenSize();
            SetCanvasMatch();
            if (_matchWidthOrHeight == 1)
            {
                OnResolutionChangedPC?.Invoke();
            }
            else
            {
                OnResolutionChangedMobile?.Invoke();
            }
        }
    }

    /// <summary>
    /// 获取屏幕长款比
    /// </summary>
    public void GetScreenSize()
    {
        _screenWidth = Screen.width;
        _screenHeight = Screen.height;
    }

    /// <summary>
    /// 设置Canvas的Match
    /// </summary>
    public void SetCanvasMatch()
    {
        float currentAspect = (float)_screenWidth / _screenHeight;
        if (!Mathf.Approximately(currentAspect, _matchWidthOrHeight))
        {
            if (currentAspect >= 1)
            {
                _matchWidthOrHeight = 1;
            }
            else
            {
                _matchWidthOrHeight = 0;
            }
        }
        _scaler.matchWidthOrHeight = _matchWidthOrHeight;
    }

    public void SetRectTransformValue(RectTransform rectTransform, UIRectTransformValue uIRectTransformValue)
    {
        rectTransform.anchoredPosition = new Vector3(uIRectTransformValue.Pos.x, uIRectTransformValue.Pos.y);
        rectTransform.offsetMin = new Vector2(uIRectTransformValue.left, uIRectTransformValue.bottom);
        rectTransform.offsetMax = new Vector2(uIRectTransformValue.right, uIRectTransformValue.top);
        if (uIRectTransformValue.minuswidth != 0)
        {
            if (_screenWidth > _scaler.referenceResolution.x)
            {
                uIRectTransformValue.width = _screenWidth - uIRectTransformValue.minuswidth;
            }
            else
            {
                uIRectTransformValue.width = _scaler.referenceResolution.x - uIRectTransformValue.minuswidth;
            }
        }
        if (uIRectTransformValue.minusheight != 0)
        {
            if (_screenHeight > _scaler.referenceResolution.y)
            {
                uIRectTransformValue.height = _screenHeight - uIRectTransformValue.minusheight;
            }
            else
            {
                uIRectTransformValue.height = _scaler.referenceResolution.y - uIRectTransformValue.minusheight;
            }
        }
        rectTransform.sizeDelta = new Vector2(uIRectTransformValue.width, uIRectTransformValue.height);
    }

    public void SetGridLayoutGroupValue(GridLayoutGroup gridLayoutGroup, UIGridLayoytGroupValue uIGridLayoytValue)
    {
        gridLayoutGroup.padding.left = uIGridLayoytValue.PaddingLeft;
        gridLayoutGroup.padding.right = uIGridLayoytValue.PaddingRight;
        gridLayoutGroup.padding.top = uIGridLayoytValue.PaddingTop;
        gridLayoutGroup.padding.bottom = uIGridLayoytValue.PaddingBottom;
        gridLayoutGroup.cellSize = uIGridLayoytValue.CellSize;
        gridLayoutGroup.spacing = uIGridLayoytValue.Spacing;
    }
}
