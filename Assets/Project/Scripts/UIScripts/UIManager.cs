using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static UIReferences;

public class UIManager : MonoBehaviour
{
    /// <summary>
    /// 初始化按钮事件
    /// </summary>
    public UnityAction[] InitializeButtons(UnityAction[] _buttonActions, List<UIPageBinding> _UIPageBindingList)
    {
        _buttonActions = new UnityAction[_UIPageBindingList.Count];

        for (int i = 0; i < _UIPageBindingList.Count; i++)
        {
            UIPageBinding binding = _UIPageBindingList[i];

            if (binding.Button == null || binding.Page == null)
            {
                Debug.LogWarning($"UI 页面绑定第 {i} 项未配置完整！", this);
                continue;
            }

            GameObject targetPage = binding.Page;

            _buttonActions[i] = () => ShowPage(targetPage, _UIPageBindingList);
        }
        return _buttonActions;
    }

    /// <summary>
    /// 注册按钮事件
    /// </summary>
    public void RegisterButtonEvents(UnityAction[] _buttonActions, List<UIPageBinding> _UIPageBindingList)
    {
        for (int i = 0; i < _UIPageBindingList.Count; i++)
        {
            if (_buttonActions[i] == null)
                continue;

            _UIPageBindingList[i].Button.onClick.AddListener(_buttonActions[i]);
        }
    }

    /// <summary>
    /// 取消按钮事件
    /// </summary>
    public void UnregisterButtonEvents(UnityAction[] _buttonActions, List<UIPageBinding> _UIPageBindingList)
    {
        for (int i = 0; i < _UIPageBindingList.Count; i++)
        {
            if (_buttonActions[i] == null)
                continue;

            _UIPageBindingList[i].Button.onClick.RemoveListener(_buttonActions[i]);
        }
    }
    /// <summary>
    /// 显示指定页面，关闭其他页面
    /// </summary>
    public void ShowPage(GameObject targetPage, List<UIPageBinding> _UIPageBindingList)
    {
        if (targetPage == null)
            return;

        foreach (var binding in _UIPageBindingList)
        {
            if (binding.Page == null)
                continue;

            binding.Page.SetActive(binding.Page == targetPage);
        }
    }
}
