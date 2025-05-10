using UnityEngine;

public class MovimientoNave : MonoBehaviour
{
    public float velocidad = 1f;
    private float amplitud = 0.2f;
    private Vector3 posicionInicial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        posicionInicial = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = posicionInicial + new Vector3(0, amplitud * Mathf.Sin(Time.time * velocidad), 0);
        Debug.Log(amplitud);
    }
}
