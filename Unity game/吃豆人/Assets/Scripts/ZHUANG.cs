using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
//第二关转场
public class ZHUANG : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void jump()
    {
        SceneManager.LoadScene(0);
    }
    public void Jump()
    {
        SceneManager.LoadScene(1);
    }
}
