using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrainMenuControl : MonoBehaviour
{
    

    #region PublicVariables
    //Brain GameObject
    public GameObject Brain;

    //Brain Parts
    public GameObject FrontalLobe;//1
    public GameObject Pariet;//2
    public GameObject Occipit;//3
    public GameObject Temp;//4
    public GameObject Cereb;//5   
    public GameObject Pitua;//6
    public GameObject Stem;//7
    public GameObject Corpus;//8


    //Canvas Information
    public Text Title;
    public Text Information;

    //Materials
    public Material HighlightedMaterial;
    public Material NormalMaterial;
    public Material TransparentMaterial;
    #endregion

    public bool LerpTransitionRotation = true;
    int Index = 0;
    Quaternion rotTo;
    float rotSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Index = 0;
        NextPart();
    }

    // Update is called once per frame
    void Update()
    {
        if(LerpTransitionRotation == true)
        {
            Brain.transform.rotation = Quaternion.Lerp(Brain.transform.rotation, rotTo, Time.deltaTime * 1f);
        }  
    }

    public void NextPart()
    {
        Index = (Index + 1);
        if(Index == 0 || Index>8)
        {
            Index = 1;
        }

        if      (Index == 1)
        {
            ChangePart(FrontalLobe);
        }
        else if (Index == 2)
        {
            ChangePart(Pariet);
        }
        else if (Index == 3)
        {
            ChangePart(Occipit);
        }
        else if (Index == 4)
        {
            ChangePart(Temp);
        }
        else if (Index == 5)
        {
            ChangePart(Cereb);
        }
        else if (Index == 6)
        {
            ChangePart(Pitua);
        }
        else if (Index == 7)
        {
            ChangePart(Stem);
        }
        else if (Index == 8)
        {
            ChangePart(Corpus);
        }
        else
        {
            ChangePart(FrontalLobe);
        }
    }


    void ChangePart(GameObject HighlightedPart)
    {
        LerpTransitionRotation = true;

        if (HighlightedPart == FrontalLobe)
        {
            #region Frontal Lobe
            //Change Brain Rotation
            //Brain.transform.rotation = Quaternion.Euler(0, 234.03f, 0);
            rotTo = Quaternion.Euler(0, 90f, 0);
            
            //Change Color of the highlighted part
            FrontalLobe.GetComponent<Renderer>().material = HighlightedMaterial;

            //Change Color of all other parts
            Cereb.GetComponent<Renderer>().material = NormalMaterial;
            Corpus.GetComponent<Renderer>().material = NormalMaterial;
            Occipit.GetComponent<Renderer>().material = NormalMaterial;
            Pariet.GetComponent<Renderer>().material = NormalMaterial;
            Pitua.GetComponent<Renderer>().material = NormalMaterial;
            Stem.GetComponent<Renderer>().material = NormalMaterial;
            Temp.GetComponent<Renderer>().material = NormalMaterial;

            //Change Title
            Title.text = "FRONTAL LOBE";

            //Change Information
            Information.text = "The frontal lobes are considered our emotional control center and home to our personality. There is no other part of the brain where lesions can cause such a wide variety of symptoms. The frontal lobes are involved in motor function, problem solving, spontaneity, memory, language, initiation, judgement, impulse control, and social and sexual behavior. The frontal lobes are extremely vulnerable to injury due to their location at the front of the cranium, proximity to the sphenoid wing and their large size. MRI studies have shown that the frontal area is the most common region of injury following mild to moderate traumatic brain injury.";
            #endregion
        }
        else if (HighlightedPart == Pariet)
        {
            #region PARIETAL LOBES
            //Change Brain Rotation
            rotTo = Quaternion.Euler(0f, -90f, 45f);
            //Brain.transform.rotation = Quaternion.Lerp(Brain.transform.rotation, rotTo, rotSpeed);

            //Change Color of the highlighted part
            Pariet.GetComponent<Renderer>().material = HighlightedMaterial;

            //Change Color of all other parts
            FrontalLobe.GetComponent<Renderer>().material = NormalMaterial;
            Corpus.GetComponent<Renderer>().material = NormalMaterial;
            Occipit.GetComponent<Renderer>().material = NormalMaterial;
            Cereb.GetComponent<Renderer>().material = NormalMaterial;
            Pitua.GetComponent<Renderer>().material = NormalMaterial;
            Stem.GetComponent<Renderer>().material = NormalMaterial;
            Temp.GetComponent<Renderer>().material = NormalMaterial;

            //Change Title
            Title.text = "PARIETAL LOBES";

            //Change Information
            Information.text = "The parietal lobes can be divided into two functional regions. One involves sensation and perception and the other is concerned with integrating sensory input, primarily with the visual system. The first function integrates sensory information to form a single perception (cognition). The second function constructs a spatial coordinate system to represent the world around us. Individuals with damage to the parietal lobes often show striking deficits, such as abnormalities in body image and spatial relations";
            #endregion
        }
        else if (HighlightedPart == Occipit)
        {
            #region Occipital Lobe
            //Change Brain Rotation
            rotTo = Quaternion.Euler(0f, -90f, 0f);
            //Brain.transform.rotation = Quaternion.Lerp(Brain.transform.rotation, rotTo, rotSpeed);

            //Change Color of the highlighted part
            Occipit.GetComponent<Renderer>().material = HighlightedMaterial;

            //Change Color of all other parts
            FrontalLobe.GetComponent<Renderer>().material = NormalMaterial;
            Corpus.GetComponent<Renderer>().material = NormalMaterial;
            Cereb.GetComponent<Renderer>().material = NormalMaterial;
            Pariet.GetComponent<Renderer>().material = NormalMaterial;
            Pitua.GetComponent<Renderer>().material = NormalMaterial;
            Stem.GetComponent<Renderer>().material = NormalMaterial;
            Temp.GetComponent<Renderer>().material = NormalMaterial;

            //Change Title
            Title.text = "OCCIPITAL LOBE";

            //Change Information
            Information.text = "The occipital lobe is the seat of most of the brain's visual cortex, allowing you not only to see and process stimuli from the external world, but also to assign meaning to and remember visual perceptions. Located just under the parietal lobe and above the temporal lobe, the occipital lobe is the brain's smallest lobe, but its functions are indispensable.";
            #endregion
        }
        else if (HighlightedPart == Temp)
        {
            #region Temporal Lobe
            //Change Brain Rotation
            rotTo = Quaternion.Euler(0f, 0f, 0f);
            //Brain.transform.rotation = Quaternion.Lerp(Brain.transform.rotation, rotTo, rotSpeed);

            //Change Color of the highlighted part
            Temp.GetComponent<Renderer>().material = HighlightedMaterial;

            //Change Color of all other parts
            FrontalLobe.GetComponent<Renderer>().material = NormalMaterial;
            Corpus.GetComponent<Renderer>().material = NormalMaterial;
            Cereb.GetComponent<Renderer>().material = NormalMaterial;
            Pariet.GetComponent<Renderer>().material = NormalMaterial;
            Pitua.GetComponent<Renderer>().material = NormalMaterial;
            Stem.GetComponent<Renderer>().material = NormalMaterial;
            Occipit.GetComponent<Renderer>().material = NormalMaterial;

            //Change Title
            Title.text = "TEMPORAL LOBE";

            //Change Information
            Information.text = "The temporal lobes sit behind the ears and are the second largest lobe. They are most commonly associated with processing auditory information and with the encoding of memory. The temporal lobes are also believed to play an important role in processing affect/emotions, language, and certain aspects of visual perception.\n\nThe dominant temporal lobe, which is the left side in most people, is involved in understanding language and learning and remembering verbal information. The non-dominant lobe, which is typically the right temporal lobe, is involved in learning and remembering non-verbal information(e.g.visuo - spatial material and music).";
            #endregion
        }
        else if (HighlightedPart == Cereb)
        {
            #region Cerebellum
            //Change Brain Rotation
            rotTo = Quaternion.Euler(0f, -94.64f, -84.77f);
            //Brain.transform.rotation = Quaternion.Lerp(Brain.transform.rotation, rotTo, rotSpeed);

            //Change Color of the highlighted part
            Cereb.GetComponent<Renderer>().material = HighlightedMaterial;

            //Change Color of all other parts
            FrontalLobe.GetComponent<Renderer>().material = NormalMaterial;
            Corpus.GetComponent<Renderer>().material = NormalMaterial;
            Occipit.GetComponent<Renderer>().material = NormalMaterial;
            Pariet.GetComponent<Renderer>().material = NormalMaterial;
            Pitua.GetComponent<Renderer>().material = NormalMaterial;
            Stem.GetComponent<Renderer>().material = NormalMaterial;
            Temp.GetComponent<Renderer>().material = NormalMaterial;

            //Change Title
            Title.text = "CEREBELLUM";

            //Change Information
            Information.text = "The cerebellum is located behind the top part of the brain stem(where the spinal cord meets the brain) and is made of two hemispheres(halves).\n\nThe cerebellum receives information from the sensory systems, the spinal cord, and other parts of the brain and then regulates motor movements.The cerebellum coordinates voluntary movements such as posture, balance, coordination, and speech, resulting in smooth and balanced muscular activity.It is also important for learning motor behaviors.";
            #endregion
        }
        else if (HighlightedPart == Pitua)
        {
            #region pituitary gland
            //Change Brain Rotation
            rotTo = Quaternion.Euler(0f, 83.97f, 31.48f);
            //Brain.transform.rotation = Quaternion.Lerp(Brain.transform.rotation, rotTo, rotSpeed);

            //Change Color of the highlighted part
            Pitua.GetComponent<Renderer>().material = HighlightedMaterial;

            //Change Color of all other parts
            FrontalLobe.GetComponent<Renderer>().material = TransparentMaterial;
            Corpus.GetComponent<Renderer>().material = NormalMaterial;
            Occipit.GetComponent<Renderer>().material = NormalMaterial;
            Pariet.GetComponent<Renderer>().material = NormalMaterial;
            Cereb.GetComponent<Renderer>().material = NormalMaterial;
            Stem.GetComponent<Renderer>().material = NormalMaterial;
            Temp.GetComponent<Renderer>().material = NormalMaterial;

            //Change Title
            Title.text = "PITUITARY GLAND";

            //Change Information
            Information.text = "The pituitary gland is called the 'master gland' as the hormones it produces control so many different processes in the body. It senses the body's needs and sends signals to different organs and glands throughout the body to regulate their function and maintain an appropriate environment. It secretes a variety of hormones into the bloodstream which act as messengers to transmit information from the pituitary gland to distant cells, regulating their activity. For example, the pituitary gland produces prolactin, which acts on the breasts to induce milk production. The pituitary gland also secretes hormones that act on the adrenal glands, thyroid gland, ovaries and testes, which in turn produce other hormones. Through secretion of its hormones, the pituitary gland controls metabolism, growth, sexual maturation, reproduction, blood pressure and many other vital physical functions and processes.";
            #endregion
        }
        else if (HighlightedPart == Stem)
        {
            #region BRAIN STEM
            //Change Brain Rotation
            rotTo = Quaternion.Euler(0f, 88.28f, 0f);
            //Brain.transform.rotation = Quaternion.Lerp(Brain.transform.rotation, rotTo, rotSpeed);

            //Change Color of the highlighted part
            Stem.GetComponent<Renderer>().material = HighlightedMaterial;

            //Change Color of all other parts
            FrontalLobe.GetComponent<Renderer>().material = TransparentMaterial;
            Corpus.GetComponent<Renderer>().material = NormalMaterial;
            Occipit.GetComponent<Renderer>().material = NormalMaterial;
            Pariet.GetComponent<Renderer>().material = NormalMaterial;
            Cereb.GetComponent<Renderer>().material = NormalMaterial;
            Pitua.GetComponent<Renderer>().material = NormalMaterial;
            Temp.GetComponent<Renderer>().material = NormalMaterial;

            //Change Title
            Title.text = "BRAIN STEM";

            //Change Information
            Information.text = "The stem-like part of the base of the brain that is connected to the spinal cord. The brain stem controls the flow of messages between the brain and the rest of the body, and it also controls basic body functions such as breathing, swallowing, heart rate, blood pressure, consciousness, and whether one is awake or sleepy.";
            #endregion
        }
        else if (HighlightedPart == Corpus)
        {
            #region Corpus Callosum
            //Change Brain Rotation
            rotTo = Quaternion.Euler(0f, 88.28f, -50f);
            //Brain.transform.rotation = Quaternion.Lerp(Brain.transform.rotation, rotTo, rotSpeed);

            //Change Color of the highlighted part
            Corpus.GetComponent<Renderer>().material = HighlightedMaterial;

            //Change Color of all other parts
            FrontalLobe.GetComponent<Renderer>().material = TransparentMaterial;
            Stem.GetComponent<Renderer>().material = NormalMaterial;
            Occipit.GetComponent<Renderer>().material = NormalMaterial;
            Pariet.GetComponent<Renderer>().material = NormalMaterial;
            Cereb.GetComponent<Renderer>().material = NormalMaterial;
            Pitua.GetComponent<Renderer>().material = NormalMaterial;
            Temp.GetComponent<Renderer>().material = NormalMaterial;

            //Change Title
            Title.text = "CORPUS CALLOSUM";

            //Change Information
            Information.text = "The Corpus Callosum is the part of the mind that allows communication between the two hemispheres of the brain. It is responsible for transmitting neural messages between both the right and left hemispheres.";
            #endregion
        }
    }
}
