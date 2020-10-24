using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ResetScript : MonoBehaviour
{
    static List<GameObject> dices;
    static List<Vector3> vectors;

    // Start is called before the first frame update
    void Start()
    {
        dices = new List<GameObject> {
            GameObject.Find("D4"),
            GameObject.Find("D6"),
            GameObject.Find("D8"),
            GameObject.Find("D10"),
            GameObject.Find("D12"),
            GameObject.Find("D20")
        };
        vectors = new List<Vector3>();
        foreach (var dice in dices)
        {
            vectors.Add(dice.transform.position);
        }
    }
    public static void Reset()
    {
        for (int i = 0; i < dices.Count; ++i)
        {
            dices[i].transform.position = vectors[i];
        }
    }
}
