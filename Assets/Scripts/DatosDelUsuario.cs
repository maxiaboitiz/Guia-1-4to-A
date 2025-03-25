using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string nombreUsuario;
    [SerializeField] int edadUsuario;
    [SerializeField] float estaturaUsuario;
    [SerializeField] bool donanteOrganos;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es: " + nombreUsuario + "Tengo: " + edadUsuario + "Mido: " + estaturaUsuario + donanteOrganos + "Soy o no Donante");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
