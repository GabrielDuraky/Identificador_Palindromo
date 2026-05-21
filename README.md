# Identificador de Palíndromo

## Descrição
Programa em C# que verifica se uma palavra ou frase é um palíndromo, ignorando maiúsculas/minúsculas, espaços e caracteres especiais.

## Abordagem
Utilizei o algoritmo clássico de **dois ponteiros** (`left` e `right`) com `ReadOnlySpan<char>` para percorrer a string de forma eficiente.

**Vantagens dessa abordagem:**
- Evita completamente o uso de `Reverse()` (conforme restrição da vaga)
- Complexidade **O(n)** em tempo e **O(1)** em espaço
- Trata corretamente frases com espaços, pontuação e acentuação

## Como executar

### Opção 1 - GitHub Codespaces
1. Abra o repositório no GitHub
2. Clique em **Code** → **Codespaces** → **Create codespace on main**
3. No terminal, rode:
   ```bash
   dotnet run

### Opção 2 - localmente
1. git clone https://github.com/GabrielDuraky/identificador_palindromo.git
2. cd identificador_palindromo
3. dotnet run

## Exemplos de uso:

| Entrada | Resultado |
| --- | --- |
| Socorram-me subi no onibus em marrocos | Palíndromo |
| A mala nada na lama | Palíndromo |
| Radar | Palíndromo |
| 12321 | Palíndromo |
| Oi | Não é um palíndromo |

## Decisões técnicas
- Uso de ReadOnlySpan<char> para melhor performance.
- char.ToLowerInvariant() para correto tratamento de Unicode.
- Tratamento robusto de null, strings vazias e espaços.
- loop interativo no console para facilitar testes.
