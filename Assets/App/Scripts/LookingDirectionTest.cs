using HoloToolkit.Unity.InputModule;
using HoloToolkitExtensions.Utilities;
using UnityEngine;

public class LookingDirectionTest : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        Debug.Log(LookingDirectionHelpers.GetPostionInLookingDirection(2.0f,GazeManager.Instance.Stabilizer));
    }
}
