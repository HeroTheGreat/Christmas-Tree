using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnOrnament : MonoBehaviour
{
    public GameObject myPrefab;
    public Text text;
    int Ballcounter;

    private void Start()
    {
        myPrefab.GetComponent<Rigidbody>().isKinematic = true;
    }


    public void OnTriggerEnter(Collider other)
    {
        {
            if (other.gameObject.tag == "sphere")
            {
                Ballcounter++;
                text.text = "Score..: " + Ballcounter;

                Debug.Log("Spawn!");
                Instantiate(myPrefab, new Vector3(0.2299995f, 9.667572f, -9.483604f), Quaternion.identity);

            }
            if (Ballcounter > 9)
            {

                SceneManager.LoadScene(sceneName: "FinishScene");
                SceneManager.UnloadSceneAsync(sceneName: "GameScene");
            }
        }
    }

}