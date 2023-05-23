-- Script para crear o actualizar el procedimiento almacenado CreateInvoiceItem
IF OBJECT_ID('CreateInvoiceItem', 'P') IS NOT NULL
    DROP PROCEDURE CreateInvoiceItem
GO

create or alter procedure CreateInvoiceItem
	@InvoiceId int,
	@ProductName varchar(100),
	@Quantity float,
	@UnitPrice float
as
begin
	set nocount on;

	insert into InvoiceItem(InvoiceId, ProductName, Quantity, UnitPrice)
	values (@InvoiceId, @ProductName, @Quantity, @UnitPrice);
end