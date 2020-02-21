using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
public class Cal : MonoBehaviour
{
    public InputField n1,n2;
    private int first,second;
    public Text result;
    public void onAdd()
    {
       first = int.Parse(n1.text);
       second = int.Parse(n2.text);
       result.text = "Result : " + (first+second).ToString();
    }
    public void onSub()
    {
        first = int.Parse(n1.text);
        second = int.Parse(n2.text);
        result.text = "Result : " + (first - second).ToString();
    }
    public void onMul()
    {
        first = int.Parse(n1.text);
        second = int.Parse(n2.text);
        result.text = "Result : " + (first * second).ToString();
    }
    public void onDiv()
    {
        first = int.Parse(n1.text);
        second = int.Parse(n2.text);
        result.text = "Result : " + (first / second).ToString();
    }
}
