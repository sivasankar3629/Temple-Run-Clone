using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class count : MonoBehaviour
{
    public int countNumber = 0;
    [SerializeField] Text countText;

    public void increment()
    {
        if (countNumber < 10)
        {
            countNumber++;
            countText.text = countNumber.ToString();
        }

    }

    public void decrement()
    {
        if (countNumber > 0)
        {
            countNumber--;
            countText.text = countNumber.ToString();
        }

    }
}
