using Fsm.AppUI;
using UnityEngine;

public class Context : MonoBehaviour
{
    public static Context Instance { get; private set; }

    public UserInfo UserInfo = new UserInfo();
    public IAppSystem AppUISystem = new AppUISystem();


    private void Awake() 
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

}
