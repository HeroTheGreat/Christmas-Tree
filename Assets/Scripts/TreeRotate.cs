using DG.Tweening;
using UnityEngine;

public class TreeRotate : MonoBehaviour
{
  public Transform treeTransform;
    

    void Update()
    {
     
        transform.Rotate(Vector3.forward * 20 * Time.deltaTime);
    }
}
