using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    float vMouse;                   // v = vertical. Serve para pegar o eixo Y do mouse.
    float hMouse;                   // h = horizontal. Serve para pegar o eixo X do mouse.
    float vRotation;                // Existe para pode usar a função "Mathf.Clamp" e "Quaternion.Euler". Adiciona a si mesmo o valor de vMouse.

    public float mouseSensitivity = 300f;  // Serve para setar a velocidade de movimento da câmera.
    public GameObject player;       // Serve para pegar o Player.

    void MouseDirection() {
        vMouse = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        hMouse = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
    }
    void Update()
    {
        MouseDirection();

        vRotation += vMouse * -1;                                           // * -1 pois assim se arrastar o mouse para cima a câmera também irá olhar para cima.
        vRotation = Mathf.Clamp(vRotation, 7, 10);                      // "Clamp" é uma função que limita um valor entre 2 números. Nesse caso serve para limitar o ângulo
                                                                            //de visão do eixo Y da câmera, de -90 até 15.
        player.transform.Rotate(Vector3.up * hMouse);                       // "Vector.up" significa a mesma coisa que "new Vector3(0, 1, 0)".
        this.transform.localRotation = Quaternion.Euler(vRotation, 0, 0);   // "Quaternion.Euler" é uma função para rotação, assim como "Rotate", porém aquele aceita parâmetros do "Mathf".

    }
}
