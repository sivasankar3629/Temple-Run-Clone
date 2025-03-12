using System.Collections;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    GameObject[] cubes;
    float speed = 90;

    public void button()
    {
        StartCoroutine(Rot());
    }

    IEnumerator Rot()
    {

        for (int i = 0; i < 3; i++)
        {
            float time = 0;
            while (time < 4)
            {
                cubes[i].transform.Rotate(Vector3.up * Time.deltaTime * speed);
                time += Time.deltaTime;
                yield return null;
            }
        }
    }
}