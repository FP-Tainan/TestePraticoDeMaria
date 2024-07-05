CREATE TABLE tb_produtos (
    id SERIAL4 NOT NULL PRIMARY KEY,
    produto VARCHAR(255) NOT NULL,
   	quantidadeEstoque int NOT null,
    precoUnitario DECIMAL(10,2),
    descricao VARCHAR(255)
);