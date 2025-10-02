using UnityEngine;

public class GeneradorBlocParet : MonoBehaviour
{
    private const float LIMIT_ESQUERRA = -7f;
    private const float LIMIT_DRET = 7f;
    private const float LIMIT_INFERIOR = -1f;
    private const float LIMIT_SUPERIOR = 7f;
    private const float LIMIT_POSTERIOR = 90f; 

    public GameObject prefabBlocParet;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        // Param1: Funcio que es cridara repetidament
        // Param2: Des de que s'obre l'escena, quant tarda a començar-se a cridar
        // Param3: Una vegada ja es crida, cada quant es torna a cridar
        InvokeRepeating("GenerarBlocParets", 0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void GenerarBlocParets()
    {
        GameObject paretInferiorEsquerra = Instantiate(prefabBlocParet);
        paretInferiorEsquerra.transform.position = new Vector3(
            LIMIT_ESQUERRA,
            LIMIT_INFERIOR,
            LIMIT_POSTERIOR
        );

        GameObject paretInferiorDreta = Instantiate(prefabBlocParet);
        paretInferiorDreta.transform.position = new Vector3(
            LIMIT_DRET,
            LIMIT_INFERIOR,
            LIMIT_POSTERIOR
        );
        GameObject paretSuperiorDreta = Instantiate(prefabBlocParet);
        paretSuperiorDreta.transform.position = new Vector3(
            LIMIT_DRET,
            LIMIT_SUPERIOR,
            LIMIT_POSTERIOR
        );
        GameObject paretSuperiorEsquerra = Instantiate(prefabBlocParet);
        paretSuperiorEsquerra.transform.position = new Vector3(
            LIMIT_ESQUERRA,
            LIMIT_SUPERIOR,
            LIMIT_POSTERIOR
        );
    }
}
