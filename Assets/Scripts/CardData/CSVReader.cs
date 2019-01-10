using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CSVReader : MonoBehaviour {

    /// <summary>
    /// csvを読み込んでstring[]のリスト形式にして返すクラス
    /// </summary>

    TextAsset csvFile;//読み込むファイル
    List<string[]> csvDatas = new List<string[]>();//csvデータのリスト

    List<string[]> ReadCsvFile(string fileName)
    {
        csvFile = Resources.Load(fileName) as TextAsset; // Resouces下のCSV読み込み
        StringReader reader = new StringReader(csvFile.text);

        // , で分割しつつ一行ずつ読み込み
        // リストに追加していく
        while (reader.Peek() != -1) // reader.Peaekが-1になるまで
        {
            string line = reader.ReadLine(); // 一行ずつ読み込み
            csvDatas.Add(line.Split(',')); // , 区切りでリストに追加
        }

        // csvDatas[行][列]を指定して値を自由に取り出せる
        //Debug.Log(csvDatas[0][1]);

        return csvDatas;
    }



}
