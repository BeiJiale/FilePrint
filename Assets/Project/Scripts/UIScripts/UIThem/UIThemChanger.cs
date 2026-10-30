using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIThemChanger : MonoBehaviour
{
    [SerializeField] private UIManager uIManager;
    public UIComponentType uIComponentType;

    private Image image;
    private RawImage rawImage;
    private Text text;
    private TMP_Text tMP_Text;
    private Button button;
    private GameObject tMP_Button;
    private InputField inputField;
    private TMP_InputField tMP_InputField;
    private Dropdown dropdown;
    private TMP_Dropdown tMP_Dropdown;
    private Toggle toggle;
    private Slider slider;
    private Scrollbar scrollbar;
    private GameObject scrollView;
    private bool _isStarted;

    private void Awake()
    {
        
    }

    private void OnEnable()
    {
        if (!_isStarted) return;
        //设置UIThem
    }

    private void Start()
    {
        _isStarted = true;
        //设置UIThem
    }
}
