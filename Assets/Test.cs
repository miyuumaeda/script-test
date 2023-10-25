using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // 要素数5の配列を初期化する
        int[] array = new int[5];

        array[0] = 10;
        array[1] = 40;
        array[2] = 20;
        array[3] = 60;
        array[4] = 50;

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("array[" + i + "] = " + array[i]);
        }


        // 逆順で5回処理を繰り返す
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log("array[" + i + "] = " + array[i]);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
