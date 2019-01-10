using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class JsonHelper{

    public static object FromJson<T>(string json)
    {
        if (json.StartsWith("{[", System.StringComparison.CurrentCulture))
        {
            json = json.Insert(1, "\"items\":");
            Debug.Log(json);
            var obj = JsonUtility.FromJson<Wrapper<T>>(json);

            return (T[])(object)obj.items;
        }
        else
        {
            T obj = JsonUtility.FromJson<T>(json);
            return obj;
        }
    }

    [System.Serializable]
    private class Wrapper<T>
    {
        public T[] items;
    }

    /*
     * Json読み込みハマったところ  
     * 配列型のjsonを扱うときは整形が必要
     * ラッパークラス？ジェネリック？
     * そもそもjsonのファイルの中身が不正な形になってた
     * JsonUtilityが何をどこまでしてくれるクラスなのか  
    */
}
