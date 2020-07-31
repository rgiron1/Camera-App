using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class DeleteFunction : MonoBehaviour
{
    public GameObject Scripts;
    public GameObject currentImage;
    public int i0;
    public int i1;
    public int i2;
    public int i3;
    public int i4;
    public int i5;
    public int i6;
    public int i7;
    public int i8;
    // UnityEngine.UI.RawImage image0;
    // UnityEngine.UI.RawImage image1;
    // UnityEngine.UI.RawImage image2;
    // UnityEngine.UI.RawImage image3;
    // UnityEngine.UI.RawImage image4;
    // UnityEngine.UI.RawImage image5;
    // UnityEngine.UI.RawImage image6;
    // UnityEngine.UI.RawImage image7;
    // UnityEngine.UI.RawImage image8;
    public bool canDelete;
    // Start is called before the first frame update
    void Start()
    {
        canDelete = false;
        i0 = 0;
        i1 = 1;
        i2 = 2;
        i3 = 3;
        i4 = 4;
        i5 = 5;
        i6 = 6;
        i7 = 7;
        i8 = 8;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void deleteToggle()
    {
        if (canDelete == false)
        {
            canDelete = true;
        }
        else
        {
            canDelete = false;
        }
    }

    public void deletePicture()
    {
        if (canDelete)
        {
            if (currentImage.name == "RawImage0")
            { // get the picture ref and delete from Firebase storage and then delete the texture from PictureObject
                Debug.Log("delete pic 0");
                var picRef0 = Scripts.GetComponent<UploadPicture>().pictures[i0].GetRef();
                picRef0.DeleteAsync().ContinueWith(Task =>
                {
                    if (Task.IsCompleted)
                    {
                        Debug.Log("File successfuly deleted");
                    }
                    else
                    {
                        Debug.Log("Error occurred");
                    }
                });
                Texture pic0Text = Scripts.GetComponent<UploadPicture>().pictures[i0].PicText();
                Destroy(pic0Text); //shift everything left (need more time to find better algorithim)
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 1)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i0].setRef(Scripts.GetComponent<UploadPicture>().pictures[i1].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i0].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i1].PicText());
                    Scripts.GetComponent<OpenCamera>().images[0].texture = Scripts.GetComponent<UploadPicture>().pictures[i0].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 2)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i1].setRef(Scripts.GetComponent<UploadPicture>().pictures[i2].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i1].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i2].PicText());
                    Scripts.GetComponent<OpenCamera>().images[1].texture = Scripts.GetComponent<UploadPicture>().pictures[i1].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 3)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i2].setRef(Scripts.GetComponent<UploadPicture>().pictures[i3].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i2].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i3].PicText());
                    Scripts.GetComponent<OpenCamera>().images[2].texture = Scripts.GetComponent<UploadPicture>().pictures[i2].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 4)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i3].setRef(Scripts.GetComponent<UploadPicture>().pictures[i4].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i3].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i4].PicText());
                    Scripts.GetComponent<OpenCamera>().images[3].texture = Scripts.GetComponent<UploadPicture>().pictures[i3].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 5)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i4].setRef(Scripts.GetComponent<UploadPicture>().pictures[i5].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i4].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i5].PicText());
                    Scripts.GetComponent<OpenCamera>().images[4].texture = Scripts.GetComponent<UploadPicture>().pictures[i4].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 6)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i5].setRef(Scripts.GetComponent<UploadPicture>().pictures[i6].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i5].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i6].PicText());
                    Scripts.GetComponent<OpenCamera>().images[5].texture = Scripts.GetComponent<UploadPicture>().pictures[i5].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 7)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i6].setRef(Scripts.GetComponent<UploadPicture>().pictures[i7].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i6].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i7].PicText());
                    Scripts.GetComponent<OpenCamera>().images[6].texture = Scripts.GetComponent<UploadPicture>().pictures[i6].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 8)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i7].setRef(Scripts.GetComponent<UploadPicture>().pictures[i8].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i7].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i8].PicText());
                    Scripts.GetComponent<OpenCamera>().images[7].texture = Scripts.GetComponent<UploadPicture>().pictures[i7].PicText();
                }
                // Debug.Log(Scripts.GetComponent<UploadPicture>().pictures.Count - 1);
                // Debug.Log(Scripts.GetComponent<UploadPicture>().numOfPics - 1);
                if (Scripts.GetComponent<UploadPicture>().pictures[Scripts.GetComponent<UploadPicture>().pictures.Count - 1].PicText()) // get rid of the last image
                {
                    Debug.Log("Texture is not null removing last image!");
                    Scripts.GetComponent<OpenCamera>().images[Scripts.GetComponent<UploadPicture>().pictures.Count - 1].texture = null;

                }
                else
                {
                    Debug.Log("texture is null");
                }
                Scripts.GetComponent<UploadPicture>().pictures.RemoveAt(Scripts.GetComponent<UploadPicture>().pictures.Count - 1); //remove last picture object
                Scripts.GetComponent<OpenCamera>().firstEmptyImage--; //shift left
                Scripts.GetComponent<UploadPicture>().numOfPics--; //one less picture

            }
            else if (currentImage.name == "RawImage1")
            {
                Debug.Log("delete pic 1");
                var picref1 = Scripts.GetComponent<UploadPicture>().pictures[i1].GetRef();
                picref1.DeleteAsync().ContinueWith(Task =>
                {
                    if (Task.IsCompleted)
                    {
                        Debug.Log("File successfuly deleted");
                    }
                    else
                    {
                        Debug.Log("Error occurred");
                    }
                });
                Texture pic1Text = Scripts.GetComponent<UploadPicture>().pictures[i1].PicText();
                Destroy(pic1Text);

                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 2)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i1].setRef(Scripts.GetComponent<UploadPicture>().pictures[i2].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i1].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i2].PicText());
                    Scripts.GetComponent<OpenCamera>().images[1].texture = Scripts.GetComponent<UploadPicture>().pictures[i1].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 3)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i2].setRef(Scripts.GetComponent<UploadPicture>().pictures[i3].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i2].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i3].PicText());
                    Scripts.GetComponent<OpenCamera>().images[2].texture = Scripts.GetComponent<UploadPicture>().pictures[i2].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 4)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i3].setRef(Scripts.GetComponent<UploadPicture>().pictures[i4].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i3].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i4].PicText());
                    Scripts.GetComponent<OpenCamera>().images[3].texture = Scripts.GetComponent<UploadPicture>().pictures[i3].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 5)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i4].setRef(Scripts.GetComponent<UploadPicture>().pictures[i5].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i4].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i5].PicText());
                    Scripts.GetComponent<OpenCamera>().images[4].texture = Scripts.GetComponent<UploadPicture>().pictures[i4].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 6)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i5].setRef(Scripts.GetComponent<UploadPicture>().pictures[i6].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i5].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i6].PicText());
                    Scripts.GetComponent<OpenCamera>().images[5].texture = Scripts.GetComponent<UploadPicture>().pictures[i5].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 7)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i6].setRef(Scripts.GetComponent<UploadPicture>().pictures[i7].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i6].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i7].PicText());
                    Scripts.GetComponent<OpenCamera>().images[6].texture = Scripts.GetComponent<UploadPicture>().pictures[i6].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 8)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i7].setRef(Scripts.GetComponent<UploadPicture>().pictures[i8].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i7].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i8].PicText());
                    Scripts.GetComponent<OpenCamera>().images[7].texture = Scripts.GetComponent<UploadPicture>().pictures[i7].PicText();
                }
                // Debug.Log(Scripts.GetComponent<UploadPicture>().pictures.Count - 1);
                // Debug.Log(Scripts.GetComponent<UploadPicture>().numOfPics - 1);
                if (Scripts.GetComponent<UploadPicture>().pictures[Scripts.GetComponent<UploadPicture>().pictures.Count - 1].PicText()) // get rid of the last image
                {
                    Debug.Log("texture is not null");
                    Scripts.GetComponent<OpenCamera>().images[Scripts.GetComponent<UploadPicture>().pictures.Count - 1].texture = null;

                }
                else
                {
                    Debug.Log("texture is null");
                }
                Scripts.GetComponent<UploadPicture>().pictures.RemoveAt(Scripts.GetComponent<UploadPicture>().pictures.Count - 1);
                Scripts.GetComponent<OpenCamera>().firstEmptyImage--;
                Scripts.GetComponent<UploadPicture>().numOfPics--;

            }
            else if (currentImage.name == "RawImage2")
            {
                Debug.Log("delete pic 2");
                var picref2 = Scripts.GetComponent<UploadPicture>().pictures[i2].GetRef();
                picref2.DeleteAsync().ContinueWith(Task =>
                {
                    if (Task.IsCompleted)
                    {
                        Debug.Log("File successfuly deleted");
                    }
                    else
                    {
                        Debug.Log("Error occurred");
                    }
                });
                Texture pic2Text = Scripts.GetComponent<UploadPicture>().pictures[i2].PicText();
                Destroy(pic2Text);

                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 3)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i2].setRef(Scripts.GetComponent<UploadPicture>().pictures[i3].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i2].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i3].PicText());
                    Scripts.GetComponent<OpenCamera>().images[2].texture = Scripts.GetComponent<UploadPicture>().pictures[i2].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 4)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i3].setRef(Scripts.GetComponent<UploadPicture>().pictures[i4].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i3].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i4].PicText());
                    Scripts.GetComponent<OpenCamera>().images[3].texture = Scripts.GetComponent<UploadPicture>().pictures[i3].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 5)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i4].setRef(Scripts.GetComponent<UploadPicture>().pictures[i5].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i4].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i5].PicText());
                    Scripts.GetComponent<OpenCamera>().images[4].texture = Scripts.GetComponent<UploadPicture>().pictures[i4].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 6)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i5].setRef(Scripts.GetComponent<UploadPicture>().pictures[i6].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i5].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i6].PicText());
                    Scripts.GetComponent<OpenCamera>().images[5].texture = Scripts.GetComponent<UploadPicture>().pictures[i5].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 7)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i6].setRef(Scripts.GetComponent<UploadPicture>().pictures[i7].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i6].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i7].PicText());
                    Scripts.GetComponent<OpenCamera>().images[6].texture = Scripts.GetComponent<UploadPicture>().pictures[i6].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 8)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i7].setRef(Scripts.GetComponent<UploadPicture>().pictures[i8].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i7].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i8].PicText());
                    Scripts.GetComponent<OpenCamera>().images[7].texture = Scripts.GetComponent<UploadPicture>().pictures[i7].PicText();
                }
                // Debug.Log(Scripts.GetComponent<UploadPicture>().pictures.Count - 1);
                // Debug.Log(Scripts.GetComponent<UploadPicture>().numOfPics - 1);
                if (Scripts.GetComponent<UploadPicture>().pictures[Scripts.GetComponent<UploadPicture>().pictures.Count - 1].PicText()) // get rid of the last image
                {
                    Debug.Log("texture is not null");
                    Scripts.GetComponent<OpenCamera>().images[Scripts.GetComponent<UploadPicture>().pictures.Count - 1].texture = null;

                }
                else
                {
                    Debug.Log("texture is null");
                }
                Scripts.GetComponent<UploadPicture>().pictures.RemoveAt(Scripts.GetComponent<UploadPicture>().pictures.Count - 1);
                Scripts.GetComponent<OpenCamera>().firstEmptyImage--;
                Scripts.GetComponent<UploadPicture>().numOfPics--;
            }
            else if (currentImage.name == "RawImage3")
            {
                Debug.Log("delete pic 3");
                var picref3 = Scripts.GetComponent<UploadPicture>().pictures[i3].GetRef();
                picref3.DeleteAsync().ContinueWith(Task =>
                {
                    if (Task.IsCompleted)
                    {
                        Debug.Log("File successfuly deleted");
                    }
                    else
                    {
                        Debug.Log("Error occurred");
                    }
                });
                Texture pic3Text = Scripts.GetComponent<UploadPicture>().pictures[i3].PicText();
                Destroy(pic3Text);

                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 4)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i3].setRef(Scripts.GetComponent<UploadPicture>().pictures[i4].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i3].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i4].PicText());
                    Scripts.GetComponent<OpenCamera>().images[3].texture = Scripts.GetComponent<UploadPicture>().pictures[i3].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 5)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i4].setRef(Scripts.GetComponent<UploadPicture>().pictures[i5].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i4].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i5].PicText());
                    Scripts.GetComponent<OpenCamera>().images[4].texture = Scripts.GetComponent<UploadPicture>().pictures[i4].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 6)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i5].setRef(Scripts.GetComponent<UploadPicture>().pictures[i6].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i5].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i6].PicText());
                    Scripts.GetComponent<OpenCamera>().images[5].texture = Scripts.GetComponent<UploadPicture>().pictures[i5].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 7)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i6].setRef(Scripts.GetComponent<UploadPicture>().pictures[i7].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i6].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i7].PicText());
                    Scripts.GetComponent<OpenCamera>().images[6].texture = Scripts.GetComponent<UploadPicture>().pictures[i6].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 8)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i7].setRef(Scripts.GetComponent<UploadPicture>().pictures[i8].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i7].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i8].PicText());
                    Scripts.GetComponent<OpenCamera>().images[7].texture = Scripts.GetComponent<UploadPicture>().pictures[i7].PicText();
                }
                // Debug.Log(Scripts.GetComponent<UploadPicture>().pictures.Count - 1);
                // Debug.Log(Scripts.GetComponent<UploadPicture>().numOfPics - 1);
                if (Scripts.GetComponent<UploadPicture>().pictures[Scripts.GetComponent<UploadPicture>().pictures.Count - 1].PicText()) // get rid of the last image
                {
                    Debug.Log("texture is not null");
                    Scripts.GetComponent<OpenCamera>().images[Scripts.GetComponent<UploadPicture>().pictures.Count - 1].texture = null;

                }
                else
                {
                    Debug.Log("texture is null");
                }
                Scripts.GetComponent<UploadPicture>().pictures.RemoveAt(Scripts.GetComponent<UploadPicture>().pictures.Count - 1);

                Scripts.GetComponent<OpenCamera>().firstEmptyImage--;
                Scripts.GetComponent<UploadPicture>().numOfPics--;

            }
            else if (currentImage.name == "RawImage4")
            {
                Debug.Log("delete pic 4");
                var picref4 = Scripts.GetComponent<UploadPicture>().pictures[i4].GetRef();
                picref4.DeleteAsync().ContinueWith(Task =>
                {
                    if (Task.IsCompleted)
                    {
                        Debug.Log("File successfuly deleted");
                    }
                    else
                    {
                        Debug.Log("Error occurred");
                    }
                });
                Texture pic4Text = Scripts.GetComponent<UploadPicture>().pictures[i4].PicText();
                Destroy(pic4Text);

                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 5)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i4].setRef(Scripts.GetComponent<UploadPicture>().pictures[i5].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i4].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i5].PicText());
                    Scripts.GetComponent<OpenCamera>().images[4].texture = Scripts.GetComponent<UploadPicture>().pictures[i4].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 6)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i5].setRef(Scripts.GetComponent<UploadPicture>().pictures[i6].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i5].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i6].PicText());
                    Scripts.GetComponent<OpenCamera>().images[5].texture = Scripts.GetComponent<UploadPicture>().pictures[i5].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 7)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i6].setRef(Scripts.GetComponent<UploadPicture>().pictures[i7].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i6].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i7].PicText());
                    Scripts.GetComponent<OpenCamera>().images[6].texture = Scripts.GetComponent<UploadPicture>().pictures[i6].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 8)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i7].setRef(Scripts.GetComponent<UploadPicture>().pictures[i8].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i7].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i8].PicText());
                    Scripts.GetComponent<OpenCamera>().images[7].texture = Scripts.GetComponent<UploadPicture>().pictures[i7].PicText();
                }
                // Debug.Log(Scripts.GetComponent<UploadPicture>().pictures.Count - 1);
                // Debug.Log(Scripts.GetComponent<UploadPicture>().numOfPics - 1);
                if (Scripts.GetComponent<UploadPicture>().pictures[Scripts.GetComponent<UploadPicture>().pictures.Count - 1].PicText()) // get rid of the last image
                {
                    Debug.Log("texture is not null");
                    Scripts.GetComponent<OpenCamera>().images[Scripts.GetComponent<UploadPicture>().pictures.Count - 1].texture = null;

                }
                else
                {
                    Debug.Log("texture is null");
                }
                Scripts.GetComponent<UploadPicture>().pictures.RemoveAt(Scripts.GetComponent<UploadPicture>().pictures.Count - 1);
                Scripts.GetComponent<OpenCamera>().firstEmptyImage--;
                Scripts.GetComponent<UploadPicture>().numOfPics--;
            }

            else if (currentImage.name == "RawImage5")
            {
                Debug.Log("delete pic 5");
                var picref5 = Scripts.GetComponent<UploadPicture>().pictures[i5].GetRef();
                picref5.DeleteAsync().ContinueWith(Task =>
                {
                    if (Task.IsCompleted)
                    {
                        Debug.Log("File successfuly deleted");
                    }
                    else
                    {
                        Debug.Log("Error occurred");
                    }
                });
                Texture pic5Text = Scripts.GetComponent<UploadPicture>().pictures[i5].PicText();
                Destroy(pic5Text);

                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 6)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i5].setRef(Scripts.GetComponent<UploadPicture>().pictures[i6].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i5].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i6].PicText());
                    Scripts.GetComponent<OpenCamera>().images[5].texture = Scripts.GetComponent<UploadPicture>().pictures[i5].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 7)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i6].setRef(Scripts.GetComponent<UploadPicture>().pictures[i7].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i6].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i7].PicText());
                    Scripts.GetComponent<OpenCamera>().images[6].texture = Scripts.GetComponent<UploadPicture>().pictures[i6].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 8)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i7].setRef(Scripts.GetComponent<UploadPicture>().pictures[i8].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i7].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i8].PicText());
                    Scripts.GetComponent<OpenCamera>().images[7].texture = Scripts.GetComponent<UploadPicture>().pictures[i7].PicText();
                }
                // Debug.Log(Scripts.GetComponent<UploadPicture>().pictures.Count - 1);
                // Debug.Log(Scripts.GetComponent<UploadPicture>().numOfPics - 1);
                if (Scripts.GetComponent<UploadPicture>().pictures[Scripts.GetComponent<UploadPicture>().pictures.Count - 1].PicText()) // get rid of the last image
                {
                    Debug.Log("texture is not null");
                    Scripts.GetComponent<OpenCamera>().images[Scripts.GetComponent<UploadPicture>().pictures.Count - 1].texture = null;

                }
                else
                {
                    Debug.Log("texture is null");
                }
                Scripts.GetComponent<UploadPicture>().pictures.RemoveAt(Scripts.GetComponent<UploadPicture>().pictures.Count - 1);
                Scripts.GetComponent<OpenCamera>().firstEmptyImage--;
                Scripts.GetComponent<UploadPicture>().numOfPics--;

            }
            else if (currentImage.name == "RawImage6")
            {
                Debug.Log("delete pic 6");
                var picref6 = Scripts.GetComponent<UploadPicture>().pictures[i6].GetRef();
                picref6.DeleteAsync().ContinueWith(Task =>
                {
                    if (Task.IsCompleted)
                    {
                        Debug.Log("File successfuly deleted");
                    }
                    else
                    {
                        Debug.Log("Error occurred");
                    }
                });
                Texture pic6Text = Scripts.GetComponent<UploadPicture>().pictures[i6].PicText();
                Destroy(pic6Text);

                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 7)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i6].setRef(Scripts.GetComponent<UploadPicture>().pictures[i7].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i6].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i7].PicText());
                    Scripts.GetComponent<OpenCamera>().images[6].texture = Scripts.GetComponent<UploadPicture>().pictures[i6].PicText();
                }
                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 8)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i7].setRef(Scripts.GetComponent<UploadPicture>().pictures[i8].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i7].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i8].PicText());
                    Scripts.GetComponent<OpenCamera>().images[7].texture = Scripts.GetComponent<UploadPicture>().pictures[i7].PicText();
                }
                // Debug.Log(Scripts.GetComponent<UploadPicture>().pictures.Count - 1);
                // Debug.Log(Scripts.GetComponent<UploadPicture>().numOfPics - 1);
                if (Scripts.GetComponent<UploadPicture>().pictures[Scripts.GetComponent<UploadPicture>().pictures.Count - 1].PicText()) // get rid of the last image
                {
                    Debug.Log("texture is not null");
                    Scripts.GetComponent<OpenCamera>().images[Scripts.GetComponent<UploadPicture>().pictures.Count - 1].texture = null;

                }
                else
                {
                    Debug.Log("texture is null");
                }
                Scripts.GetComponent<UploadPicture>().pictures.RemoveAt(Scripts.GetComponent<UploadPicture>().pictures.Count - 1);
                Scripts.GetComponent<OpenCamera>().firstEmptyImage--;
                Scripts.GetComponent<UploadPicture>().numOfPics--;

            }
            else if (currentImage.name == "RawImage7")
            {
                Debug.Log("delete pic 7");
                var picref7 = Scripts.GetComponent<UploadPicture>().pictures[i7].GetRef();
                picref7.DeleteAsync().ContinueWith(Task =>
                {
                    if (Task.IsCompleted)
                    {
                        Debug.Log("File successfuly deleted");
                    }
                    else
                    {
                        Debug.Log("Error occurred");
                    }
                });
                Texture pic7Text = Scripts.GetComponent<UploadPicture>().pictures[i7].PicText();
                Destroy(pic7Text);

                if (Scripts.GetComponent<UploadPicture>().pictures.Count > 8)
                {
                    Scripts.GetComponent<UploadPicture>().pictures[i7].setRef(Scripts.GetComponent<UploadPicture>().pictures[i8].GetRef());
                    Scripts.GetComponent<UploadPicture>().pictures[i7].setPicText(Scripts.GetComponent<UploadPicture>().pictures[i8].PicText());
                    Scripts.GetComponent<OpenCamera>().images[7].texture = Scripts.GetComponent<UploadPicture>().pictures[i7].PicText();
                }
                // Debug.Log(Scripts.GetComponent<UploadPicture>().pictures.Count - 1);
                // Debug.Log(Scripts.GetComponent<UploadPicture>().numOfPics - 1);
                if (Scripts.GetComponent<UploadPicture>().pictures[Scripts.GetComponent<UploadPicture>().pictures.Count - 1].PicText()) // get rid of the last image
                {
                    Debug.Log("texture is not null");
                    Scripts.GetComponent<OpenCamera>().images[Scripts.GetComponent<UploadPicture>().pictures.Count - 1].texture = null;

                }
                else
                {
                    Debug.Log("texture is null");
                }
                Scripts.GetComponent<UploadPicture>().pictures.RemoveAt(Scripts.GetComponent<UploadPicture>().pictures.Count - 1);
                Scripts.GetComponent<OpenCamera>().firstEmptyImage--;
                Scripts.GetComponent<UploadPicture>().numOfPics--;

            }
            else if (currentImage.name == "RawImage8")
            {
                Debug.Log("delete pic 8");
                var picref8 = Scripts.GetComponent<UploadPicture>().pictures[i8].GetRef();
                picref8.DeleteAsync().ContinueWith(Task =>
                {
                    if (Task.IsCompleted)
                    {
                        Debug.Log("File successfuly deleted");
                    }
                    else
                    {
                        Debug.Log("Error occurred");
                    }
                });
                Texture pic8Text = Scripts.GetComponent<UploadPicture>().pictures[i8].PicText();
                Destroy(pic8Text);
                Scripts.GetComponent<UploadPicture>().pictures.RemoveAt(Scripts.GetComponent<UploadPicture>().pictures.Count - 1);
                Scripts.GetComponent<OpenCamera>().firstEmptyImage--;
                Scripts.GetComponent<UploadPicture>().numOfPics--;

            }
        }
        else
        {
            Debug.Log("won't delete!");
        }
    }



}
