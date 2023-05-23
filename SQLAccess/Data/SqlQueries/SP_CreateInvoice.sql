-- Script para crear o actualizar el procedimiento almacenado CreateInvoice
IF OBJECT_ID('CreateInvoice', 'P') IS NOT NULL
    DROP PROCEDURE CreateInvoice
GO

create or alter procedure CreateInvoice
	@InvoiceNumber varchar(50),
	@InvoiceDate date,
	@CustomerName varchar(100),
	@TaxRate bit,
	@InvoiceId int output
as
begin
	set nocount on;
	insert into Invoice (InvoiceNumber, InvoiceDate, CustomerName, TaxRate)
	values (@InvoiceNumber, @InvoiceDate, @CustomerName, @TaxRate);
	
	-- Devuelve el ID de la Factura
	set @InvoiceId = scope_identity();
end