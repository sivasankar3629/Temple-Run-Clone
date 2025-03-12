using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField] private Text timeText;

    public void button()
    {
        StartCoroutine(Timer());
    }
    IEnumerator Timer()
    {
        for (int j = 0; j < 3; j++)
        {
            for (int i = 3; i >= 0; i--)
            {
                timeText.text = i.ToString();
                yield return new WaitForSeconds(1f);
            }

        }
    }
}
