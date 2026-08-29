using UnityEngine;

public class ImageController : MonoBehaviour
{
    public GameObject image;

    public void LigarImagem(){
        image.SetActive(true);
    }
    public void DesligarImagem(){
        image.SetActive(false);
    }
}
