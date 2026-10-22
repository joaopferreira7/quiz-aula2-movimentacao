# Quiz – Aula 2: Movimentação básica com pulo (2D)

Unity **6000.4.1f1** · Input Manager (antigo) · física 2D (Rigidbody2D)

## Como abrir
1. Unity Hub → **Add project from disk** → selecione esta pasta.
2. Abra a cena `Assets/Scenes/Main.unity` e aperte **Play**.

## Controles
| Ação | Tecla |
|---|---|
| Andar | A / D ou ← / → |
| Pular | Espaço, W ou ↑ |

## O que foi feito
- `Assets/Scripts/PlayerController2D.cs`
  - Lê o input no `Update` e aplica a velocidade no `FixedUpdate` (passo da física).
  - Movimento horizontal pela `linearVelocity` do `Rigidbody2D`; o pulo define a velocidade vertical.
  - Só pula se estiver no chão: `Rigidbody2D.IsTouching` com um `ContactFilter2D` que aceita apenas contatos cuja normal aponta para cima (não precisa de layers).
  - Rotação travada e respawn se cair do mapa.
- `Assets/Scripts/CameraFollow2D.cs` – câmera que segue o jogador.
- `Assets/Editor/SceneBuilder.cs` – menu **Quiz → Recriar cena** monta a cena do zero.

## Assets
O cenário usa um sprite quadrado simples (`Assets/Sprites/Quadrado.png`). Para usar um pack de assets
(ex.: *Kenney Pixel Platformer*, gratuito), importe o pack e arraste o sprite desejado no campo
**Sprite** do `SpriteRenderer` do Player e das plataformas – o código não muda.
