CREATE PROCEDURE Sabor_create
    @descricao VARCHAR(40),
    @Tempo int
AS
    INSERT INTO [Sabor] (
        [descricao], 
        [Tempo]
    ) VALUES (
        @descricao,
        @Tempo
    )