CREATE PROCEDURE Pizza_create
    @Tamanho VARCHAR(40),
    @Sabor VARCHAR(40),
    @ValorTotal decimal,
    @TempoPreparo int
AS
    INSERT INTO [Pizza] (
        [Tamanho], 
        [Sabor], 
        [ValorTotal], 
        [TempoPreparo]
    ) VALUES (
        @Tamanho,
        @Sabor,
        @ValorTotal,
        @TempoPreparo
    )