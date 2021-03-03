using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FallingObjects : MonoBehaviour
{
    public static FallingObjects instance;

    [SerializeField]
    private float xLimit;
    [SerializeField]
    private float[] xPositions;
    [SerializeField]
    private Faller[] faller;
    private float currentTime;
    List<float> usedPositions = new List<float>();
    private int fallerIndex;
    float xPos = 0;
    int rand;
    float[] MyPositions = new float[] { -5.5f, 0, 5.5f };

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
        usedPositions.AddRange(xPositions);
    }

    void Update()
    {
        if(Player.Instance.StartMoving == true)
        {
            currentTime -= Time.deltaTime;
            if(currentTime <= 0)
            {
                getFalling();
            }
        }
    }

    void FeltObject(float xPos)
    {
        string fallingObjectName = "";
        switch (Random.Range(0, 5))
        {
            case 0:
                fallingObjectName = "papier";
                break;

            case 1:
                fallingObjectName = "plast";
                break;

            case 2:
                fallingObjectName = "sklo";
                break;

            case 3:
                fallingObjectName = "phone";
                break;

            case 4:
                fallingObjectName = "computer";
                break;
        }
        GameObject faller = PoolOptimalize.instance.GetObjectFromPool(fallingObjectName);
        faller.transform.position = new Vector3(xPos, transform.position.y, 0);
        faller.SetActive(true);
    }

    
    void getFalling()
    {
        usedPositions = new List<float>();
        usedPositions.AddRange(xPositions);
        fallerIndex = Random.Range(0, faller.Length);
        currentTime = faller[fallerIndex].delayTime;
        if (faller[fallerIndex].fallingCount == 1)
        {
            rand = Random.Range(0, MyPositions.Length);
            xPos = MyPositions[rand];
            usedPositions.Add(rand);
        }
        else if (faller[fallerIndex].fallingCount > 1)
        {
            rand = Random.Range(0, usedPositions.Count);
            xPos = usedPositions[rand];
            usedPositions.RemoveAt(rand);
        }

        for (int i = 0; i < faller[fallerIndex].fallingCount; i++)
        {
            FeltObject(xPos);
            rand = Random.Range(0, usedPositions.Count);
            xPos = usedPositions[rand];
            usedPositions.RemoveAt(rand);
        }
    }
}

[System.Serializable]
public class Faller
{
    public float delayTime;
    public float fallingCount;
}
