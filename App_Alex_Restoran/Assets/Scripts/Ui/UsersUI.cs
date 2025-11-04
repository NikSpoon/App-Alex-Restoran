using TMPro;
using UnityEngine;

public class UsersUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private TextMeshProUGUI _status;
    [SerializeField] private TextMeshProUGUI _bonuses;
    [SerializeField] private TextMeshProUGUI _visitorStatistics;
    private UserInfo _userInfo;

    private void Awake()
    {
        _userInfo = UserInfo.Instance;
    }
    private void Start()
    {
        _name.text = _userInfo.Name;
        _status.text = _userInfo.Status.ToString();
        _bonuses.text = _userInfo.Bonuses.ToString();
        _visitorStatistics.text = _userInfo.Visitor.ToString();
    }
   
}
