using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public void loadLevel(string level) {
        print("loading Level: " + level);
        Application.LoadLevel(level);
    }
   
    public void quit(string level) {
        print("quitting application");
        Application.Quit();
    }
} 
