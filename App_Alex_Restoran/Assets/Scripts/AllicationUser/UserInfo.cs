using System.Collections.Generic;
using UnityEngine;

public class UserInfo : MonoBehaviour
{
    public static UserInfo Instance { get; private set; }

    public string Name = "Den";
    public string Password = "Nikita";

    public int Id = 236457;
    public int Status = 1;
    public int Bonuses = 1441;
    public int Visitor = 4;

   
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

    public void AddUser()
    {

    }
    public void RemuveUsre()
    {

    }
    public void GetUserInfo(string name, string password)
    {

    }
}
