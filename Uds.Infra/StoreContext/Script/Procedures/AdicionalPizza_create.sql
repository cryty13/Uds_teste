CREATE PROCEDURE AdicionalPizza_create
	@Descricao VARCHAR(40),
    @Tempo int,
	@Valor decimal,
    @QtdAdicional int
AS
    INSERT INTO [Pizza] (
        [Descricao], 
        [Tempo], 
        [Valor],
		[QtdAdicional]
    ) VALUES (
        @Descricao,
        @Tempo,
        @Valor,
		@QtdAdicional
    )