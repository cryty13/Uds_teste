CREATE PROCEDURE Tamanho_create
    @Tamanho VARCHAR(40),
    @Descricao VARCHAR(40),
    @Valor decimal,
    @Tempo int
AS
    INSERT INTO [Tamanho] (
        [Tamanho], 
        [Descricao], 
        [Tempo], 
        [Valor]
    ) VALUES (
        @Tamanho,
        @Descricao,
        @Tempo,
        @Valor
    )