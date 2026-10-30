using System;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIReferences : MonoBehaviour
{
    [Serializable]
    public class UIPageBinding
    {
        public Button Button;
        public GameObject Page;
    }

    [SerializeField] private UIManager _uIManager;

    [SerializeField] private TMP_Text Title;

    [Header("按钮和页面绑定列表")]
    [SerializeField] private List<UIPageBinding> _UIPageBindingList;

    private UnityAction[] _buttonActions;

    private void Awake()
    {
        _buttonActions = _uIManager.InitializeButtons(_buttonActions, _UIPageBindingList);
    }

    private void OnEnable()
    {
        _uIManager.RegisterButtonEvents(_buttonActions, _UIPageBindingList);
    }

    private void OnDisable()
    {
        _uIManager.UnregisterButtonEvents(_buttonActions, _UIPageBindingList);
    }
}
