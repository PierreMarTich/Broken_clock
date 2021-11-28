using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockMaker : MonoBehaviour
{
    // Object to spawn
    public GameObject clock;

    // Grid dimensions
    public float gridX = 36f;
    public float gridY = 20f;
    public float spacing = 1f;

    // Clock values
    public List<int> minutes;
    public List<int> hours;
    public List<List<int>> combinations = new List<List<int>>();

    // List of created clocks
    public List<GameObject> clocks;

    // Start is called before the first frame update
    void Start()
    {
        // Creating the list of mins & hours
        for (int min = 0; min < 60; min++)
        {
            minutes.Add(min);
        }
        for (int hour = 0; hour < 12; hour++)
        {
            hours.Add(hour);
        }

        // Combine every hour and minute to get all 720 combinations
        foreach(int hour in hours)
        {
            foreach(int min in minutes)
            {
                List<int> currentCombination = new List<int>();
                currentCombination.Add(hour);
                currentCombination.Add(min);
                combinations.Add(currentCombination);
            }
        }
        // Shuffle the combinations
        for (int i = 0; i < combinations.Count; i++)
        {
            List<int> temp = combinations[i];
            int randomIndex = Random.Range(i, combinations.Count);
            combinations[i] = combinations[randomIndex];
            combinations[randomIndex] = temp;
        }
        // Create clocks on the grid
        int step = 0;
        for (int y = 0; y < gridY; y++)
        {
            for (int x = 0; x < gridX; x++)
            {
                Vector3 pos = new Vector3(x, y, 0) * spacing;
                GameObject currentClock = Instantiate(clock, pos, Quaternion.identity);
                currentClock.transform.Find("aiguilles/small").GetComponent<Aiguille>().value = combinations[step][0];
                currentClock.transform.Find("aiguilles/big").GetComponent<Aiguille>().value = combinations[step][1];
                step++;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
