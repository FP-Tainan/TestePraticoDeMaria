create view vwPedidoListaProdutos
AS
select PI.pedidos_id,PI.produtos_id,PD.produto,PI.quantidade,PI.valorUnitario,PI.valortotal
from tb_pedidosItens PI 
inner join tb_produtos PD 
on PD.id = PI.produtos_id
