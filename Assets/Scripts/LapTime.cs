using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapTime : MonoBehaviour
{
    public static int Min_count;
    public static int Sec_count;
    public static float Mili_count;
    public static string Milisec_display;
    public GameObject MinB;
    public GameObject SecB;
    public GameObject MiliB;

    
    void Update()
    {
        Mili_count += Time.deltaTime * 10;
        Milisec_display = Mili_count.ToString ("F0");
        MiliB.GetComponent<Text> ().text = "" + Milisec_display;
        if (Mili_count >= 10) {
            Mili_count = 0;
            Sec_count += 1;
        }
        if (Sec_count <= 9){
            SecB.GetComponent<Text> ().text = "0" + Sec_count + ".";

        }
        else{
            SecB.GetComponent<Text> ().text = "" + Sec_count + ".";

        }
        if (Sec_count >= 60){
            Sec_count = 0;
            Min_count += 1;
        } 
        if (Min_count <= 9){
            MinB.GetComponent<Text>().text = "0" + Min_count + ":";
        }
        else{
            MinB.GetComponent<Text>().text = "" + Min_count + ":";

        }
        
    }
}
