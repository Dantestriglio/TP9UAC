using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DecrementadorUI : MonoBehaviour
{
    public TMP_InputField input_ingresoNumero;
    public TextMeshProUGUI txt_Resultado;


        // Start is called before the first frame update
    void Start()
    {


    }

  // Update is called once per frame
    void Update()
    {
       
    }


    public void Decrementar()
    {
    int numero = int.Parse(input_ingresoNumero.text);




    if (numero > 0)
    {
        int resultado = numero - 1;




       input_ingresoNumero.text = resultado.ToString();
        txt_Resultado.text = "Resultado: " + resultado;
    }
    else
    {
        txt_Resultado.text = "No puede ser menor que 0";
    }


    }
}
