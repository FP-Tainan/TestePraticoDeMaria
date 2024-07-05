CREATE TABLE tb_clientes (
    id SERIAL4 NOT NULL PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    cpfCnpj VARCHAR(255) NOT NULL UNIQUE,
    telefone VARCHAR(255),
    email VARCHAR(255) unique,
     PessoaJuridica BOOLEAN NOT NULL
);


CREATE TABLE tb_enderecos (
    id SERIAL4 NOT NULL PRIMARY KEY,
    cep VARCHAR(20) NOT NULL UNIQUE,
    logradouro VARCHAR(255),
	numero int,
	numeroComplemento VARCHAR(255),
    bairro VARCHAR(255),
    localidade VARCHAR(255),
    uf VARCHAR(2),
    cliente_id INT NOT NULL,
    FOREIGN KEY (cliente_id) REFERENCES tb_clientes(id)
);

CREATE INDEX idx_cliente_id ON tb_enderecos(cliente_id);


