-- Criando o usuário
CREATE USER sistema WITH PASSWORD 'Acesso@123';

-- Concedendo permissões nas tabelas existentes no esquema 'public'
GRANT SELECT, INSERT, UPDATE, DELETE ON ALL TABLES IN SCHEMA public TO sistema;

-- Permitindo que o usuário execute operações em sequências (como os contadores de IDs autoincrementais)
GRANT USAGE, SELECT ON ALL SEQUENCES IN SCHEMA public TO sistema;

-- Configurando permissões padrão para novas tabelas criadas no esquema 'public'
ALTER DEFAULT PRIVILEGES IN SCHEMA public GRANT SELECT, INSERT, UPDATE, DELETE ON TABLES TO sistema;
ALTER DEFAULT PRIVILEGES IN SCHEMA public GRANT USAGE, SELECT ON SEQUENCES TO sistema;

-- Opcionalmente, concedendo permissão para criar bancos de dados e conexão
ALTER ROLE sistema WITH CREATEDB LOGIN;
