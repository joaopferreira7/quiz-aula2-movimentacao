# Quiz – Aula 2: Movimentação básica com pulo (2D)

Unity **6000.4.1f1** · Input System · física 2D (Rigidbody2D) · assets **Kenney Pixel Platformer** (CC0)

![Preview do pack](Assets/Kenney%20Pixel%20Platformer/Preview.png)

## Como abrir
1. Unity Hub → **Add project from disk** → selecione esta pasta.
2. Abra a cena `Assets/Scenes/Main.unity` e aperte **Play**.

## Controles
| Ação | Teclado | Controle |
|---|---|---|
| Andar | A / D ou ← / → | Analógico esquerdo |
| Pular | Espaço, W ou ↑ | Botão A |

## O que foi feito
- `Assets/Scripts/PlayerController2D.cs`
  - Inputs criados por código com o **Input System** (`InputAction`), lidos no `Update`.
  - A física é aplicada no `FixedUpdate`: velocidade horizontal pela `linearVelocity` do `Rigidbody2D`; o pulo define a velocidade vertical.
  - Só pula se estiver no chão: `Rigidbody2D.IsTouching` com um `ContactFilter2D` que aceita apenas contatos cuja normal aponta para cima (não precisa de layers).
  - Vira o sprite (`flipX`) para o lado em que anda, trava a rotação e volta ao início se cair do mapa.
- `Assets/Scripts/CameraFollow2D.cs` – câmera que segue o jogador (com o fundo do pack preso a ela).
- `Assets/Fisica/JogadorSemAtrito` – material sem atrito para o jogador não grudar nas paredes.
- `Assets/Editor/SceneBuilder.cs` – menu **Quiz → Recriar cena** monta a cena do zero.
- `Assets/Editor/KenneySpriteImporter.cs` – configura os PNGs do pack como pixel art (Point, sem compressão, 1 tile = 1 unidade).

## Assets
[Kenney Pixel Platformer](https://kenney.nl/assets/pixel-platformer) (licença CC0, ver `Assets/Kenney Pixel Platformer/License.txt`):
personagem, chão de grama/terra, plataformas de madeira, decoração e fundo.

## Teste automático
`Assets/Tests/CenaTests.cs` (Window → General → Test Runner → PlayMode → Run All) carrega a cena e verifica que o
jogador pousa no chão e fica parado sobre ele.
