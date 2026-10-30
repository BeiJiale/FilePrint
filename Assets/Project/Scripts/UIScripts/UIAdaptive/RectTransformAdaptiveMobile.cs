using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class RectTransformAdaptiveMobile : MonoBehaviour
{
    [SerializeField] private UIAdaptiveManager _uIAdaptiveManager;
    [SerializeField] private UIRectTransformValue _rectTransformValue;
    private RectTransform _rectTransform;
    private bool _isStarted;
    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
    }
    private void Start()
    {
        _isStarted = true;
        ApplyAdaptive();
    }

    private void OnEnable()
    {
        _uIAdaptiveManager.OnResolutionChangedMobile += ApplyAdaptive;
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
            _uIAdaptiveManager.OnResolutionChangedMobile -= ApplyAdaptive;
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

        if (_uIAdaptiveManager._matchWidthOrHeight != 1)
        {
            _uIAdaptiveManager.SetRectTransformValue(_rectTransform, _rectTransformValue);
        }
    }
}
