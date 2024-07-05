CREATE VIEW vwClientes 
AS
SELECT cli.id AS cliente_id, 
cli.nome,
cli.cpfcnpj,
cli.telefone,
cli.email,
cli.pessoajuridica,
en.id as endereco_id,
en.cep,
en.logradouro,en.numero,
en.numerocomplemento,
en.bairro,
en.localidade,
en.uf 
FROM tb_clientes cli
LEFT JOIN tb_enderecos en 
on en.cliente_id = cli.id 