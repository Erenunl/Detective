using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject exit,harry,jessica,pedofili,csecim,panel1,panel2,panel3;
    public void Opencsecim()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        csecim.SetActive(true);
        harry.SetActive(false);
        jessica.SetActive(false);
        pedofili.SetActive(false);
    }
      public void Openjessica()
    {
       jessica.SetActive(true);
        csecim.SetActive(false);
        Debug.Log("hi");
    }
      public void Openharry()
    {
        harry.SetActive(true);
        csecim.SetActive(false);
    }
      public void Openpedofili()
    {
        pedofili.SetActive(true);
        csecim.SetActive(false);
    }
    public void Openexit()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
    }
    public void Openpanel1()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
        panel3.SetActive(false);
        Debug.Log("hi");
        
    }
    public void Openpanel2()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
        panel3.SetActive(false);
        
    }
    public void Openpanel3()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(true);
        
    }
}