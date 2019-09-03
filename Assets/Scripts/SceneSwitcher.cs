using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            string nextScene = "Planes";

            if (SceneManager.GetActiveScene().name == "Planes")
                nextScene = "Sphere";

            if (SceneManager.GetActiveScene().name == "Sphere")
                nextScene = "Cube";

            SceneManager.LoadScene(nextScene );
        }
    }
}
