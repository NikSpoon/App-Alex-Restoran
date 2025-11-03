using System.Collections;
using UnityEngine;

public class TestDenLern : MonoBehaviour
{
    
    int a = 1;
    string d = "1";

    void Update()
    {
        var q = 5;
        if (Input.GetKey(KeyCode.A))
        {
            StartCoroutine(Wq(q));
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log(q + d);
        }
    }

   public IEnumerator Wq(int t)
    {
        var time = 5;

        for (int i = 0; i < time; i++)
        {
            Debug.Log(5 - i + " = Timer");
          yield return new WaitForSeconds(1);
        }
       
        Debug.Log(t + a);

    }
  
}
