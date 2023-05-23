-- Script to create the Invoice table
CREATE TABLE Invoice (
	Id INT IDENTITY(1,1) PRIMARY KEY,
    InvoiceNumber VARCHAR(50),
    InvoiceDate DATE,
    CustomerName VARCHAR(100),
    TaxRate Bit
);

-- Script to create the InvoiceItem table
CREATE TABLE InvoiceItem (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    InvoiceId INT,
    ProductName VARCHAR(100),
    Quantity FLOAT,
    UnitPrice FLOAT,
    CONSTRAINT FK_InvoiceItem_Invoice FOREIGN KEY (InvoiceId) REFERENCES Invoice(Id)
);
