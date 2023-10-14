using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTracker : MonoBehaviour
{
    [SerializeField] private int nextScene;
    // Start is called before the first frame update
    public void ChangeScene(int index)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene( index);
    }
}
