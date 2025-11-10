using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

[CreateAssetMenu(fileName = "OneNewsData",menuName = "OneNewsData/News")]
public class OneNewsData : ScriptableObject
{
    public string Name;
    public string Text;
    public string ShortText;
    public Sprite Image;
}
[CreateAssetMenu(fileName = "OneNewsDataStore", menuName = "OneNewsData/NewsStore")]
public class OneNewsDataStore : ScriptableObject
{
    public List<GameObject> Prefabs = new();
}
