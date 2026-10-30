using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GridLayoutGroup))]
public class GridLayoutAdaptivePC : MonoBehaviour
{
    [SerializeField] private UIAdaptiveManager _uIAdaptiveManager;
    [SerializeField] private UIGridLayoytGroupValue _gridLayoytGroupValue;
    private GridLayoutGroup _gridLayoutGroup;
    private bool _isStarted;
    private void Awake()
    {
        _gridLayoutGroup = GetComponent<GridLayoutGroup>();
    }
    private void Start()
    {
        _isStarted = true;
        ApplyAdaptive();
    }

    private void OnEnable()
    {
        _uIAdaptiveManager.OnResolutionChangedPC += ApplyAdaptive;
        // 首次启用交给 Start 处理
        if (!_isStarted)
            return;

        ApplyAdaptive();
    }

    private void OnDisable()
    {
        if (_uIAdaptiveManager != null)
        {
            // 取消订阅，防止重复订阅和内存泄漏
            _uIAdaptiveManager.OnResolutionChangedPC -= ApplyAdaptive;
        }
    }

    /// <summary>
    /// 应用自适应
    /// </summary>
    private void ApplyAdaptive()
    {
        if (_uIAdaptiveManager == null)
        {
            Debug.LogError("UIAdaptiveManager 未设置！", this);
            return;
        }

        if (_uIAdaptiveManager._matchWidthOrHeight != 0)
        {
            _uIAdaptiveManager.SetGridLayoutGroupValue(_gridLayoutGroup, _gridLayoytGroupValue);
        }
    }
}
