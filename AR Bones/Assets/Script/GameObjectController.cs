using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectController : MonoBehaviour
{
    public GameObject Femur;
    public GameObject Foot;
    public GameObject Hand;
    public GameObject Humorus;
    public GameObject Pelvis;
    public GameObject RadiusAndUlna;
    public GameObject Ribs;
    public GameObject ScapulaAndClavical;
    public GameObject Skull;
    public GameObject TibiaAndFibula;
    public GameObject VertebralColumn;
    public GameObject FullBones;

    public GameObject FemurName;
    public GameObject FootName;
    public GameObject HandName;
    public GameObject HumorusName;
    public GameObject PelvisName;
    public GameObject RadiusAndUlnaName;
    public GameObject RibsName;
    public GameObject ScapulaAndClavicalName;
    public GameObject SkullName;
    public GameObject TibiaAndFibulaName;
    public GameObject VertebralColumnName;
    public GameObject FullBonesName;

    AudioSource FemurAudio;
    AudioSource FootAudio;
    AudioSource HandAudio;
    AudioSource HumorusAudio;
    AudioSource PelvisAudio;
    AudioSource RadiusAndUlnaAudio;
    AudioSource RibsAudio;
    AudioSource ScapulaAndClavicalAudio;
    AudioSource SkullAudio;
    AudioSource TibiaAndFibulaAudio;
    AudioSource VertebralColumnAudio;
    AudioSource FullBonesAudio;


    public GameObject ObjectManu;
    Animator AnimObjectManu;

    public GameObject CloseButton;
    

    public GameObject FemurDesButton;
    public GameObject FootDesButton;
    public GameObject HandDesButton;
    public GameObject HumorusDesButton;
    public GameObject PelvisDesButton;
    public GameObject RadiusAndUlnaDesButton;
    public GameObject RibsDesButton;
    public GameObject ScapulaAndClavicalDesButtone;
    public GameObject SkullDesButton;
    public GameObject TibiaAndFibularDesButton;
    public GameObject VertebralColumnDesButton;
    public GameObject FullBonesDesButton;

    public GameObject DeactiveFemurDesButton;
    public GameObject DeactiveFootDesButton;
    public GameObject DeactiveHandDesButton;
    public GameObject DeactiveHumorusDesButton;
    public GameObject DeactivePelvisDesButton;
    public GameObject DeactiveRadiusAndUlnaDesButton;
    public GameObject DeactiveRibsDesButton;
    public GameObject DeactiveScapulaAndClavicalDesButtone;
    public GameObject DeactiveSkullDesButton;
    public GameObject DeactiveTibiaAndFibularDesButton;
    public GameObject DeactiveVertebralColumnDesButton;
    public GameObject DeactiveFullBonesDesButton;

    // Start is called before the first frame update
    void Start()
    {
        AnimObjectManu = ObjectManu.GetComponent<Animator>();

        AnimObjectManu.SetTrigger("OPEN");

        CloseButton.SetActive(false);

        

     FemurDesButton.SetActive(false);
     FootDesButton.SetActive(false);
     HandDesButton.SetActive(false);
     HumorusDesButton.SetActive(false);
     PelvisDesButton.SetActive(false);
     RadiusAndUlnaDesButton.SetActive(false);
     RibsDesButton.SetActive(false);
     ScapulaAndClavicalDesButtone.SetActive(false);
     SkullDesButton.SetActive(false);
     TibiaAndFibularDesButton.SetActive(false);
     VertebralColumnDesButton.SetActive(false);
     FullBonesDesButton.SetActive(false);


        DeactiveFemurDesButton.SetActive(false);
        DeactiveFootDesButton.SetActive(false);
        DeactiveHandDesButton.SetActive(false);
        DeactiveHumorusDesButton.SetActive(false);
        DeactivePelvisDesButton.SetActive(false);
        DeactiveRadiusAndUlnaDesButton.SetActive(false);
        DeactiveRibsDesButton.SetActive(false);
        DeactiveScapulaAndClavicalDesButtone.SetActive(false);
        DeactiveSkullDesButton.SetActive(false);
        DeactiveTibiaAndFibularDesButton.SetActive(false);
        DeactiveVertebralColumnDesButton.SetActive(false);
        DeactiveFullBonesDesButton.SetActive(false);


        Femur.SetActive(false);
        Foot.SetActive(false);
        Hand.SetActive(false);
        Humorus.SetActive(false);
        Pelvis.SetActive(false);
        RadiusAndUlna.SetActive(false);
        Ribs.SetActive(false);
        ScapulaAndClavical.SetActive(false);
        Skull.SetActive(false);
        TibiaAndFibula.SetActive(false);
        VertebralColumn.SetActive(false);
        FullBones.SetActive(false);

        FemurName.SetActive(false);
        FootName.SetActive(false);
        HandName.SetActive(false);
        HumorusName.SetActive(false);
        PelvisName.SetActive(false);
        RadiusAndUlnaName.SetActive(false);
        RibsName.SetActive(false);
        ScapulaAndClavicalName.SetActive(false);
        SkullName.SetActive(false);
        TibiaAndFibulaName.SetActive(false);
        VertebralColumnName.SetActive(false);
        FullBonesName.SetActive(false);

        FemurAudio = Femur.GetComponent<AudioSource>();
        SkullAudio= Skull.GetComponent<AudioSource>();
        FootAudio = Foot.GetComponent<AudioSource>();
        HandAudio = Hand.GetComponent<AudioSource>();
        HumorusAudio = Humorus.GetComponent<AudioSource>();
        PelvisAudio = Pelvis.GetComponent<AudioSource>();
        RadiusAndUlnaAudio = RadiusAndUlna.GetComponent<AudioSource>();
        RibsAudio = Ribs.GetComponent<AudioSource>();
        ScapulaAndClavicalAudio = ScapulaAndClavical.GetComponent<AudioSource>();
        TibiaAndFibulaAudio = TibiaAndFibula.GetComponent<AudioSource>();
        VertebralColumnAudio = VertebralColumn.GetComponent<AudioSource>();
        FullBonesAudio = FullBones.GetComponent<AudioSource>();
    }

    public void FemurSetActive()
    {
        AnimObjectManu.ResetTrigger("OPEN");
        AnimObjectManu.SetTrigger("CLOSE");
        Femur.SetActive(true);

        CloseButton.SetActive(true);
        FemurDesButton.SetActive(true);
        


    }

    public void FootSetActive()
    {
        AnimObjectManu.ResetTrigger("OPEN");
        AnimObjectManu.SetTrigger("CLOSE");
        Foot.SetActive(true);
        CloseButton.SetActive(true);
        FootDesButton.SetActive(true);
        
        
    }

    public void HandSetActive()
    {
        AnimObjectManu.ResetTrigger("OPEN");
        AnimObjectManu.SetTrigger("CLOSE");
        Hand.SetActive(true);
        CloseButton.SetActive(true);
        
        HandDesButton.SetActive(true);
        
    }

    public void HumorusSetActive()
    {
        AnimObjectManu.ResetTrigger("OPEN");
        AnimObjectManu.SetTrigger("CLOSE");
        Humorus.SetActive(true);
        CloseButton.SetActive(true);

        
        HumorusDesButton.SetActive(true);
        
    }

    public void PelvisSetActive()
    {
        AnimObjectManu.ResetTrigger("OPEN");
        AnimObjectManu.SetTrigger("CLOSE");
        Pelvis.SetActive(true);
        CloseButton.SetActive(true);

        
        PelvisDesButton.SetActive(true);
       
    }

    public void RadiusAndUlnaSetActive()
    {
        AnimObjectManu.ResetTrigger("OPEN");
        AnimObjectManu.SetTrigger("CLOSE");
        RadiusAndUlna.SetActive(true);
        CloseButton.SetActive(true);

        
        RadiusAndUlnaDesButton.SetActive(true);
        
    }

    public void RibsSetActive()
    {
        AnimObjectManu.ResetTrigger("OPEN");
        AnimObjectManu.SetTrigger("CLOSE");
        Ribs.SetActive(true);
        CloseButton.SetActive(true);

       
        RibsDesButton.SetActive(true);
       
    }

    public void ScapulaAndClavicalSetActive()
    {
        AnimObjectManu.ResetTrigger("OPEN");
        AnimObjectManu.SetTrigger("CLOSE");
        ScapulaAndClavical.SetActive(true);
        CloseButton.SetActive(true);

        
        ScapulaAndClavicalDesButtone.SetActive(true);
        
    }

    public void SkullSetActive()
    {
        AnimObjectManu.ResetTrigger("OPEN");
        AnimObjectManu.SetTrigger("CLOSE");
        Skull.SetActive(true);
        CloseButton.SetActive(true);

        
        SkullDesButton.SetActive(true);
       
    }

    public void TibiaAndFibulaSetActive()
    {
        AnimObjectManu.ResetTrigger("OPEN");
        AnimObjectManu.SetTrigger("CLOSE");
        TibiaAndFibula.SetActive(true);
        CloseButton.SetActive(true);

        
        TibiaAndFibularDesButton.SetActive(true);
        
    }

    public void VertebralColumnSetActive()
    {
        AnimObjectManu.ResetTrigger("OPEN");
        AnimObjectManu.SetTrigger("CLOSE");
        VertebralColumn.SetActive(true);
        CloseButton.SetActive(true);

        
        VertebralColumnDesButton.SetActive(true);

    }
    public void FullBonesSetActive()
    {
        AnimObjectManu.ResetTrigger("OPEN");
        AnimObjectManu.SetTrigger("CLOSE");
        FullBones.SetActive(true);
        CloseButton.SetActive(true);

        
        FullBonesDesButton.SetActive(true);
    }

    public void FemurSetActivedes()
    {

        FemurName.SetActive(true);
        FemurAudio.Play();

        DeactiveFemurDesButton.SetActive(true);
        FemurDesButton.SetActive(false);

    }

    public void FootSetActivedes()
    {
        
        FootName.SetActive(true);
        FootAudio.Play();

        DeactiveFootDesButton.SetActive(true);
        FootDesButton.SetActive(false);
    }

    public void HandSetActivedes()
    {
       
        HandName.SetActive(true);
        HandAudio.Play();

        DeactiveHandDesButton.SetActive(true);
        HandDesButton.SetActive(false);
    }

    public void HumorusSetActivedes()
    {
        
        HumorusName.SetActive(true);
        HumorusAudio.Play();

        DeactiveHumorusDesButton.SetActive(true);
        HumorusDesButton.SetActive(false);
    }

    public void PelvisSetActivedes()
    {
      
        PelvisName.SetActive(true);
        PelvisAudio.Play();

        DeactivePelvisDesButton.SetActive(true);
        PelvisDesButton.SetActive(false);

    }

    public void RadiusAndUlnaSetActivedes()
    {
       
        RadiusAndUlnaName.SetActive(true);
        RadiusAndUlnaAudio.Play();

        DeactiveRadiusAndUlnaDesButton.SetActive(true);
        RadiusAndUlnaDesButton.SetActive(false);
    }

    public void RibsSetActivedes()
    {


        RibsName.SetActive(true);
        RibsAudio.Play();

        DeactiveRibsDesButton.SetActive(true);
        RibsDesButton.SetActive(false);


    }

    public void ScapulaAndClavicalSetActivedes()
    {
       
        ScapulaAndClavicalName.SetActive(true);
        ScapulaAndClavicalAudio.Play();

        DeactiveScapulaAndClavicalDesButtone.SetActive(true);
        ScapulaAndClavicalDesButtone.SetActive(false);

    }

    public void SkullSetActivedes()
    {
       
        SkullName.SetActive(true);
        SkullAudio.Play();

        DeactiveSkullDesButton.SetActive(true);
        SkullDesButton.SetActive(true);

    }

    public void TibiaAndFibulaSetActivedes()
    {
        
        TibiaAndFibulaName.SetActive(true);
        TibiaAndFibulaAudio.Play();

        DeactiveTibiaAndFibularDesButton.SetActive(true);
        TibiaAndFibularDesButton.SetActive(false);
    }

    public void VertebralColumnSetActivedes()
    {
        
        VertebralColumnName.SetActive(true);
        VertebralColumnAudio.Play();

        DeactiveVertebralColumnDesButton.SetActive(true);
        VertebralColumnDesButton.SetActive(false);
    }
    public void FullBonesSetActivedes()
    {
        FullBonesName.SetActive(true);
        FullBonesAudio.Play();

        DeactiveFullBonesDesButton.SetActive(true);
        FullBonesDesButton.SetActive(false);
    }


    public void FemurSetDeactivateDes() {

        FemurName.SetActive(false);
        

        FemurAudio.Stop();
        

        FemurDesButton.SetActive(true);
        DeactiveFemurDesButton.SetActive(false);
        DeactiveFootDesButton.SetActive(false);
        DeactiveHandDesButton.SetActive(false);
        DeactiveHumorusDesButton.SetActive(false);
        DeactivePelvisDesButton.SetActive(false);
        DeactiveRadiusAndUlnaDesButton.SetActive(false);
        DeactiveRibsDesButton.SetActive(false);
        DeactiveScapulaAndClavicalDesButtone.SetActive(false);
        DeactiveSkullDesButton.SetActive(false);
        DeactiveTibiaAndFibularDesButton.SetActive(false);
        DeactiveVertebralColumnDesButton.SetActive(false);
        DeactiveFullBonesDesButton.SetActive(false);

    }

    public void FootSetDeactivateDes()
    {

        
        FootName.SetActive(false);
        

        
        FootAudio.Stop();
        

        
        FootDesButton.SetActive(true);
        DeactiveFemurDesButton.SetActive(false);
        DeactiveFootDesButton.SetActive(false);
        DeactiveHandDesButton.SetActive(false);
        DeactiveHumorusDesButton.SetActive(false);
        DeactivePelvisDesButton.SetActive(false);
        DeactiveRadiusAndUlnaDesButton.SetActive(false);
        DeactiveRibsDesButton.SetActive(false);
        DeactiveScapulaAndClavicalDesButtone.SetActive(false);
        DeactiveSkullDesButton.SetActive(false);
        DeactiveTibiaAndFibularDesButton.SetActive(false);
        DeactiveVertebralColumnDesButton.SetActive(false);
        DeactiveFullBonesDesButton.SetActive(false);

    }

    public void HandSetDeactivateDes()
    {

        
        HandName.SetActive(false);
        

       
        HandAudio.Stop();
        

       
        HandDesButton.SetActive(true);
        DeactiveFemurDesButton.SetActive(false);
        DeactiveFootDesButton.SetActive(false);
        DeactiveHandDesButton.SetActive(false);
        DeactiveHumorusDesButton.SetActive(false);
        DeactivePelvisDesButton.SetActive(false);
        DeactiveRadiusAndUlnaDesButton.SetActive(false);
        DeactiveRibsDesButton.SetActive(false);
        DeactiveScapulaAndClavicalDesButtone.SetActive(false);
        DeactiveSkullDesButton.SetActive(false);
        DeactiveTibiaAndFibularDesButton.SetActive(false);
        DeactiveVertebralColumnDesButton.SetActive(false);
        DeactiveFullBonesDesButton.SetActive(false);

    }

    public void HumoruSetDeactivateDes()
    {

        
        HumorusName.SetActive(false);
        

       
        HumorusAudio.Stop();
        

        
        HumorusDesButton.SetActive(true);
        DeactiveFemurDesButton.SetActive(false);
        DeactiveFootDesButton.SetActive(false);
        DeactiveHandDesButton.SetActive(false);
        DeactiveHumorusDesButton.SetActive(false);
        DeactivePelvisDesButton.SetActive(false);
        DeactiveRadiusAndUlnaDesButton.SetActive(false);
        DeactiveRibsDesButton.SetActive(false);
        DeactiveScapulaAndClavicalDesButtone.SetActive(false);
        DeactiveSkullDesButton.SetActive(false);
        DeactiveTibiaAndFibularDesButton.SetActive(false);
        DeactiveVertebralColumnDesButton.SetActive(false);
        DeactiveFullBonesDesButton.SetActive(false);

    }

    public void PelviSetDeactivateDes()
    {

        
        PelvisName.SetActive(false);
        

        
        PelvisAudio.Stop();
        

        
        PelvisDesButton.SetActive(true);
        DeactiveFemurDesButton.SetActive(false);
        DeactiveFootDesButton.SetActive(false);
        DeactiveHandDesButton.SetActive(false);
        DeactiveHumorusDesButton.SetActive(false);
        DeactivePelvisDesButton.SetActive(false);
        DeactiveRadiusAndUlnaDesButton.SetActive(false);
        DeactiveRibsDesButton.SetActive(false);
        DeactiveScapulaAndClavicalDesButtone.SetActive(false);
        DeactiveSkullDesButton.SetActive(false);
        DeactiveTibiaAndFibularDesButton.SetActive(false);
        DeactiveVertebralColumnDesButton.SetActive(false);
        DeactiveFullBonesDesButton.SetActive(false);

    }

    public void RadiusAndUlnaSetDeactivateDes()
    {

        
        RadiusAndUlnaName.SetActive(false);
        

        
        RadiusAndUlnaAudio.Stop();
       

        
        RadiusAndUlnaDesButton.SetActive(true);
        DeactiveFemurDesButton.SetActive(false);
        DeactiveFootDesButton.SetActive(false);
        DeactiveHandDesButton.SetActive(false);
        DeactiveHumorusDesButton.SetActive(false);
        DeactivePelvisDesButton.SetActive(false);
        DeactiveRadiusAndUlnaDesButton.SetActive(false);
        DeactiveRibsDesButton.SetActive(false);
        DeactiveScapulaAndClavicalDesButtone.SetActive(false);
        DeactiveSkullDesButton.SetActive(false);
        DeactiveTibiaAndFibularDesButton.SetActive(false);
        DeactiveVertebralColumnDesButton.SetActive(false);
        DeactiveFullBonesDesButton.SetActive(false);

    }

    public void RibsSetDeactivateDes()
    {

        
        RibsName.SetActive(false);
       

        
        RibsAudio.Stop();
        

        
        RibsDesButton.SetActive(true);
        DeactiveFemurDesButton.SetActive(false);
        DeactiveFootDesButton.SetActive(false);
        DeactiveHandDesButton.SetActive(false);
        DeactiveHumorusDesButton.SetActive(false);
        DeactivePelvisDesButton.SetActive(false);
        DeactiveRadiusAndUlnaDesButton.SetActive(false);
        DeactiveRibsDesButton.SetActive(false);
        DeactiveScapulaAndClavicalDesButtone.SetActive(false);
        DeactiveSkullDesButton.SetActive(false);
        DeactiveTibiaAndFibularDesButton.SetActive(false);
        DeactiveVertebralColumnDesButton.SetActive(false);
        DeactiveFullBonesDesButton.SetActive(false);
    }

    public void ScapulaAndClavicalSetDeactivateDes()
    {

       
        ScapulaAndClavicalName.SetActive(false);
        
       
        ScapulaAndClavicalAudio.Stop();
        

        
        ScapulaAndClavicalDesButtone.SetActive(true);
        DeactiveFemurDesButton.SetActive(false);
        DeactiveFootDesButton.SetActive(false);
        DeactiveHandDesButton.SetActive(false);
        DeactiveHumorusDesButton.SetActive(false);
        DeactivePelvisDesButton.SetActive(false);
        DeactiveRadiusAndUlnaDesButton.SetActive(false);
        DeactiveRibsDesButton.SetActive(false);
        DeactiveScapulaAndClavicalDesButtone.SetActive(false);
        DeactiveSkullDesButton.SetActive(false);
        DeactiveTibiaAndFibularDesButton.SetActive(false);
        DeactiveVertebralColumnDesButton.SetActive(false);
        DeactiveFullBonesDesButton.SetActive(false);

    }

    public void SkullSetDeactivateDes()
    {

        
        SkullName.SetActive(false);
        

        
        SkullAudio.Stop();
        

        
        SkullDesButton.SetActive(true);
        DeactiveFemurDesButton.SetActive(false);
        DeactiveFootDesButton.SetActive(false);
        DeactiveHandDesButton.SetActive(false);
        DeactiveHumorusDesButton.SetActive(false);
        DeactivePelvisDesButton.SetActive(false);
        DeactiveRadiusAndUlnaDesButton.SetActive(false);
        DeactiveRibsDesButton.SetActive(false);
        DeactiveScapulaAndClavicalDesButtone.SetActive(false);
        DeactiveSkullDesButton.SetActive(false);
        DeactiveTibiaAndFibularDesButton.SetActive(false);
        DeactiveVertebralColumnDesButton.SetActive(false);
        DeactiveFullBonesDesButton.SetActive(false);

    }

    public void TibiaAndFibulaSetDeactivateDes()
    {

       
        TibiaAndFibulaName.SetActive(false);
        

        
        TibiaAndFibulaAudio.Stop();
       

        
        TibiaAndFibularDesButton.SetActive(true);
        DeactiveFemurDesButton.SetActive(false);
        DeactiveFootDesButton.SetActive(false);
        DeactiveHandDesButton.SetActive(false);
        DeactiveHumorusDesButton.SetActive(false);
        DeactivePelvisDesButton.SetActive(false);
        DeactiveRadiusAndUlnaDesButton.SetActive(false);
        DeactiveRibsDesButton.SetActive(false);
        DeactiveScapulaAndClavicalDesButtone.SetActive(false);
        DeactiveSkullDesButton.SetActive(false);
        DeactiveTibiaAndFibularDesButton.SetActive(false);
        DeactiveVertebralColumnDesButton.SetActive(false);
        DeactiveFullBonesDesButton.SetActive(false);

    }

    public void VertebralColumnFemurSetDeactivateDes()
    {

        
        VertebralColumnName.SetActive(false);
        

        
        VertebralColumnAudio.Stop();
        

     
        VertebralColumnDesButton.SetActive(true);
        DeactiveFemurDesButton.SetActive(false);
        DeactiveFootDesButton.SetActive(false);
        DeactiveHandDesButton.SetActive(false);
        DeactiveHumorusDesButton.SetActive(false);
        DeactivePelvisDesButton.SetActive(false);
        DeactiveRadiusAndUlnaDesButton.SetActive(false);
        DeactiveRibsDesButton.SetActive(false);
        DeactiveScapulaAndClavicalDesButtone.SetActive(false);
        DeactiveSkullDesButton.SetActive(false);
        DeactiveTibiaAndFibularDesButton.SetActive(false);
        DeactiveVertebralColumnDesButton.SetActive(false);
        DeactiveFullBonesDesButton.SetActive(false);

    }

    public void FullBonesSetDeactivateDes()
    {


        FullBonesName.SetActive(false);



        FullBonesAudio.Stop();



        FullBonesDesButton.SetActive(true);
        DeactiveFemurDesButton.SetActive(false);
        DeactiveFootDesButton.SetActive(false);
        DeactiveHandDesButton.SetActive(false);
        DeactiveHumorusDesButton.SetActive(false);
        DeactivePelvisDesButton.SetActive(false);
        DeactiveRadiusAndUlnaDesButton.SetActive(false);
        DeactiveRibsDesButton.SetActive(false);
        DeactiveScapulaAndClavicalDesButtone.SetActive(false);
        DeactiveSkullDesButton.SetActive(false);
        DeactiveTibiaAndFibularDesButton.SetActive(false);
        DeactiveVertebralColumnDesButton.SetActive(false);
        DeactiveFullBonesDesButton.SetActive(false);

    }



    public void SetDeactive()
    {
        AnimObjectManu.ResetTrigger("CLOSE");
        AnimObjectManu.SetTrigger("OPEN");
        Femur.SetActive(false);
        Foot.SetActive(false);
        Hand.SetActive(false);
        Humorus.SetActive(false);
        Pelvis.SetActive(false);
        RadiusAndUlna.SetActive(false);
        Ribs.SetActive(false);
        ScapulaAndClavical.SetActive(false);
        Skull.SetActive(false);
        TibiaAndFibula.SetActive(false);
        VertebralColumn.SetActive(false);
        FullBones.SetActive(false);

        FemurDesButton.SetActive(false);
        FootDesButton.SetActive(false);
        HandDesButton.SetActive(false);
        HumorusDesButton.SetActive(false);
        PelvisDesButton.SetActive(false);
        RadiusAndUlnaDesButton.SetActive(false);
        RibsDesButton.SetActive(false);
        ScapulaAndClavicalDesButtone.SetActive(false);
        SkullDesButton.SetActive(false);
        TibiaAndFibularDesButton.SetActive(false);
        VertebralColumnDesButton.SetActive(false);
        FullBonesDesButton.SetActive(false);


        DeactiveFemurDesButton.SetActive(false);
        DeactiveFootDesButton.SetActive(false);
        DeactiveHandDesButton.SetActive(false);
        DeactiveHumorusDesButton.SetActive(false);
        DeactivePelvisDesButton.SetActive(false);
        DeactiveRadiusAndUlnaDesButton.SetActive(false);
        DeactiveRibsDesButton.SetActive(false);
        DeactiveScapulaAndClavicalDesButtone.SetActive(false);
        DeactiveSkullDesButton.SetActive(false);
        DeactiveTibiaAndFibularDesButton.SetActive(false);
        DeactiveVertebralColumnDesButton.SetActive(false);
        DeactiveFullBonesDesButton.SetActive(false);

        CloseButton.SetActive(false);
    }


}
