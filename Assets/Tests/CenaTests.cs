using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class CenaTests
{
    [UnityTest]
    public IEnumerator JogadorPousaNoChaoENaoCaiParaSempre()
    {
        SceneManager.LoadScene("Main");
        yield return null;

        var player = GameObject.FindWithTag("Player");
        Assert.IsNotNull(player, "A cena precisa ter um objeto com a tag Player");
        var controle = player.GetComponent<PlayerController2D>();
        var rb = player.GetComponent<Rigidbody2D>();

        yield return new WaitForSeconds(1.5f);

        Assert.IsTrue(controle.EstaNoChao(), "O jogador deveria estar apoiado no chão");
        Assert.Greater(player.transform.position.y, -3f, "O jogador atravessou o chão");
        Assert.AreEqual(0f, rb.linearVelocity.y, 0.01f, "O jogador ainda está caindo");
    }
}
