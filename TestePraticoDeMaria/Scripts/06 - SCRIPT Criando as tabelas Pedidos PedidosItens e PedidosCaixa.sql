create table tb_pedidos (
id SERIAL4 NOT NULL PRIMARY KEY,
cliente_id INT NOT NULL,
dataPedido DATE,
dataConcluido DATE,
dataCancelado DATE,
cancelado BOOLEAN,
finalizado BOOLEAN,
Observacao VARCHAR(255),
ValorTotalPedido DECIMAL(10,2),
FOREIGN KEY (cliente_id) REFERENCES tb_clientes(id)
);

CREATE TABLE tb_pedidosItens (
    pedidos_id INT NOT NULL,
    produtos_id INT NOT NULL,
    Quantidade INT NOT NULL,
    ValorUnitario DECIMAL(10,2) NOT NULL,
    valorTotal DECIMAL(10,2) NOT NULL,
    PRIMARY KEY (pedidos_id, produtos_id),
    FOREIGN KEY (pedidos_id) REFERENCES tb_pedidos(id),
    FOREIGN KEY (produtos_id) REFERENCES tb_produtos(id)
);


CREATE TABLE tb_pedidosCaixa (
	id SERIAL4 NOT NULL PRIMARY KEY,
    pedidos_id INT NOT NULL,
    Entrada BOOLEAN,
    Saida BOOLEAN,
    ValorMovimentacao DECIMAL(10,2) NOT NULL,
    FormaPagamento VARCHAR(255),
    FOREIGN KEY (pedidos_id) REFERENCES tb_pedidos(id)
);

