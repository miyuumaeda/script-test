using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // 要素数5の配列を初期化する
        int[] arrey = new int[5];

        // 5回処理を繰り返す
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }


        // 逆順で5回処理を繰り返す
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
