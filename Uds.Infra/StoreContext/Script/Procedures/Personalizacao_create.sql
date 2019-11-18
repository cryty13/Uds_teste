CREATE PROCEDURE Personalizacao_create
    @Personalizacao VARCHAR(40),
    @Descricao VARCHAR(40),
    @Valor decimal,
    @Tempo int
AS
    INSERT INTO [Personalizacao] (
        [Personalizacao], 
        [Descricao], 
        [Tempo], 
        [Valor]
    ) VALUES (
        @Personalizacao,
        @Descricao,
        @Tempo,
        @Valor
    )