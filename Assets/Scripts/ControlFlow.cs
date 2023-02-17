using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    [SerializeField] private int gameStopShareQuantity;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            CompareGameStopShare();
    }

    private void CompareGameStopShare()
    {
        if (gameStopShareQuantity == 0)
        {
            Debug.Log("You have no shares in Game Stop");
        }
        else
        {
            Debug.Log("You have Game Stop shares");
        }
    }
}
