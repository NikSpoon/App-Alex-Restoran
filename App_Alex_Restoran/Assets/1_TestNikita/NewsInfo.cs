using TMPro;
using UnityEngine;

public class NewsInfo : MonoBehaviour
{
    [SerializeField] private GameObject _root;
    private OneNewsData _textData;

    [SerializeField] private TextMeshProUGUI _newsName;
    [SerializeField] private TextMeshProUGUI _newsText;

    public void Open()
    {
        _root.SetActive(true);

    }
    public void Closed()
    {
        _root.SetActive(false);
    }
    public void GetData(OneNewsData data)
    {
        _textData = data;
        _newsName.text = _textData.Name;
        _newsText.text = _textData.Text;
    }
}
