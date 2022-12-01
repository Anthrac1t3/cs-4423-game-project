using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalInputHandler : MonoBehaviour
{
    float sceneSwitchCooldownTimer;
    float sceneSwitchCooldownInterval = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        sceneSwitchCooldownTimer = Time.time + sceneSwitchCooldownInterval;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape")) {
            Application.Quit();
        }

        if (Input.GetKeyDown("tab")) {
            if (Time.time > sceneSwitchCooldownTimer) {
                string[] sceneList = new string []
                {
                    "Grasslands",
                    "Bayou Forest",
                    "Desert",
                    "Deciduous Forest",
                    "Tundra",
                    "Vampire Area",
                    "Werewolves Den",
                };

                string currentScene = SceneManager.GetActiveScene().name;
                for (int i = 0; i < sceneList.Length; i++) {
                    if (currentScene == sceneList[i]) {
                        int nextSceneIndex = (i + 1) % sceneList.Length;
                        string nextScene = sceneList[nextSceneIndex];
                        SceneManager.LoadScene(nextScene);
                    }
                }
            }
        }
    }
}
