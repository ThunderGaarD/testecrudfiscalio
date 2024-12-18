-- Criação da tabela NotaFiscal
CREATE TABLE NotaFiscal (
    IdNota INT PRIMARY KEY,
    Emissor VARCHAR(150),
    Data DATE
);

-- Criação do índice na coluna Data
CREATE INDEX idx_NotaFiscal_Data
ON NotaFiscal (Data);


-- Criação da tabela Item
CREATE TABLE Item (
    IdNota INT,
    IdItem INT,
    Produto VARCHAR(150),
    Valor DECIMAL(15,3),
    PRIMARY KEY (IdNota, IdItem)
);

-- Criação do índice na coluna Produto
CREATE INDEX idx_Item_Produto
ON Item (Produto);
