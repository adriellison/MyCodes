## Problema

Fazer um programa para ler os dados de um produto em estoque (nome, preço e quantidade no estoque). Em seguida:
  - Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no estoque)
  - Realizar uma entrada no estoque e mostrar novamente os dados do produto
  - Realizar uma saída no estoque e mostrar novamamente os dados do produto

> Para resolver o problema, é preciso criar uma CLASSE conforme o projeto abaixo:

| Produto |
| :--- |
| - Nome: string |
| - Preco: double |
| - Quantidade: int |
||
| + ValorTotalEmEstoque(): double |
| + AdicionarProdutos(quantity: int): void |
| + RemoverProdutos(quantity: int): void |

> Comportamento esperado:

Entre os dados do produto:

Nome: `TV`

Preço: `900`

Quantidade no estoque: `10`

Dados do produto: TV, $ 900.00, 10 unidades, Total: $ 9000.00

Digite o númeor de produtos a ser adicionado ao estoque: `5`

Dados atualizados: TV, $ 900.00, 15 unidades, Total: $13500.00

Digite o número de produtos a ser removido do estoque: `3`

Dados atualizados: TV, $ 900.00, 12 unidades, Total: $10800.00
