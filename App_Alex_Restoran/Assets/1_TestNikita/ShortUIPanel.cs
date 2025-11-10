using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShortUIPanel : MonoBehaviour
{
    [SerializeField] private OneNewsData _oneNewsData;

    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private TextMeshProUGUI _newsText;
    [SerializeField] private Image _image;
    private GameObject _newsRoot;

    private void Awake()
    {
        _newsRoot = GameObject.FindWithTag("NewsPanel");
        if (_newsRoot == null)
        {
            Debug.LogError("Не найден объект с тегом 'NewsPanel'!");
        }
    }

    private void Start()
    {
        _name.text = _oneNewsData.Name;
        _newsText.text = _oneNewsData.ShortText;
        if (_image != null)
        {
            _image.sprite = _oneNewsData.Image;
        }
    }
    public void OpenNews()
    {
        var newsInfo = _newsRoot.GetComponent<NewsInfo>();
        newsInfo.GetData(_oneNewsData);
        newsInfo.Open();

    }
    public void SetNews()
    {
      
    }
}
