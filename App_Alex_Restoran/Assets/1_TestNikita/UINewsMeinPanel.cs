using UnityEngine;

public class UINewsMeinPanel : MonoBehaviour
{
    [SerializeField] private OneNewsDataStore _oneNewsDataStore;
    [SerializeField] private GameObject _root;

    public void Start()
    {
        foreach (var entry in _oneNewsDataStore.Prefabs)
        {
            GameObject newsGO = Instantiate(entry, _root.transform);
        }
    }
}
