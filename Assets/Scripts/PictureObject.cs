using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Firebase.Storage;

public class PictureObject : MonoBehaviour
{
    Firebase.Storage.StorageReference pictureRef;
    Texture texture;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public PictureObject(Firebase.Storage.StorageReference PictureRefrence, Texture text)
    {
        pictureRef = PictureRefrence;
        texture = text;

    }

    public Firebase.Storage.StorageReference GetRef()
    {
        return pictureRef;
    }

    public void setRef(Firebase.Storage.StorageReference PictureRefrence)
    {
        pictureRef = PictureRefrence;
    }

    public Texture PicText()
    {
        return texture;
    }

    public void setPicText(Texture text)
    {
        texture = text;
    }

    public void PrintContents()
    {
        Debug.Log(pictureRef.ToString() + texture.ToString());
    }
}
