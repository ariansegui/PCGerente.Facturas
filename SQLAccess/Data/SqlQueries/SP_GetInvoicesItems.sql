-- Script para crear o actualizar el procedimiento almacenado GetInvoiceItems
create or alter procedure GetInvoiceItems
as
begin
    set nocount on;

    select Id, InvoiceId, ProductName, Quantity, UnitPrice
    from InvoiceItem;
end