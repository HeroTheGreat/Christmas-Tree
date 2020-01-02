using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MouseSwipeEvent : MonoBehaviour
{
    Vector3 startPos, endPos, direction;
    public GameObject sphere;
    public GameObject myPrefab;
    public GameObject tree;
    public Rigidbody rigidB;
    public GameObject BallCount;
    float throwForceInXY=5;
    float throwForceInZ=150;
    int counter = 0;
    int Balls = 15;
   
    private void Start()
    {
        tree = GameObject.Find("TreeSnowy");
        this.gameObject.tag = "sphere";
        rigidB.isKinematic = true;
        
    }

    public void Update()
    {
        
        if (Input.GetMouseButtonDown(0))//Koordinatların Alınması
        {
            startPos = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0)) //Alınan Koordinatların Sonu
        {
            endPos = Input.mousePosition;
            direction = endPos - startPos;
            OnFingerSwipe();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        { SceneManager.LoadScene("SampleScene"); }
        if (counter > 0)
        {
            throwForceInXY = 0;
            throwForceInZ = 0;
        }
        else
        {
            throwForceInXY = 5;
            throwForceInZ = 150;
        }
    }
  public   void OnFingerSwipe()
        {
        //Yapılan İşlem
        counter++;
        rigidB.isKinematic = false;
            rigidB.mass = 0.2f;
            rigidB.AddForce(direction.x / throwForceInXY, direction.y / throwForceInXY, throwForceInZ);
        Invoke("SetInvoke", 2f);
        BallCount.GetComponent<Text>().text = "Balls..: " + Balls;
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag=="tree")
        {
            //Collider'lar birbirine trigger ise olacak şey
            rigidB.isKinematic = true;
            sphere.transform.parent = tree.transform;
            Debug.Log("Collided");
            Destroy(this);
           
        }
    }
 public   void SetInvoke()
    {
        //Bir şey yapılmadığı halde etkinleştirilecek olay
        counter--;
        Instantiate(myPrefab, new Vector3(0.2299995f, 9.667572f, -9.483604f), Quaternion.identity);
        Destroy(this.gameObject);
    }
}



















/*   public Rigidbody ballRB;
   public int thrust;
   Vector3 mousePos = new Vector3(0,0,0);
   Vector3 secmousePos;
   void Start()
   {

   }


   void Update()
   {
       mousePos.x = Input.mousePosition.x;
       mousePos.y = Input.mousePosition.y;
       mousePos.z = Input.mousePosition.z;
       Debug.Log(mousePos.z);
       Debug.Log(mousePos.y);

   }
   public void OnFingerSwipe()
       {
        secmousePos = new Vector3(0, Input.mousePosition.y,Input.mousePosition.z);
       ballRB.isKinematic = false;
       ballRB.mass = 0.50f;
       ballRB.AddForce(secmousePos.normalized * thrust);
   }*/
