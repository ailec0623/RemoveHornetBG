using System.Collections;
using System.Linq;
using System.Reflection;
using GlobalEnums;
using UnityEngine;
using ModCommon;
using ModCommon.Util;
using Modding;
using UnityEngine.SceneManagement;

namespace RemoveHornetBG
{
    public class LoadScene : MonoBehaviour
    {
        private void Start()
        {
            UnityEngine.SceneManagement.SceneManager.activeSceneChanged += SceneChanged;
        }

        private void SceneChanged(Scene lastscene, Scene currentscene)
        {
            if (currentscene.name == "GG_Hornet_1")
            {
                foreach (GameObject i in FindObjectsOfType<GameObject>())
                {
                    if (i.name.Contains("crowd") || i.name.Contains("Loom") || i.name.Contains("BG")) 
                    {
                        Destroy(i);
                    }
                    else if (i.name.Contains("Pt") || i.name.Contains("particle") || i.name.Contains("Particle"))
                    {
                        Destroy(i);
                    }
                    else if (i.name.Contains("Dreamer Scene 1") || i.name.Contains("Godseeker Crowd"))
                    {
                        Destroy(i);
                    }
                }
            }    
        }
    }
}