CREATE VIEW vwVendasFinalizadas
AS
SELECT cl.nome ,PS.datapedido,ps.dataconcluido,ps.finalizado,ps.valortotalpedido
FROM tb_pedidos PS
INNER JOIN tb_clientes cl
ON cl.id = ps.cliente_id
