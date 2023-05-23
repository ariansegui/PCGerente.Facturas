-- Script para crear o actualizar el procedimiento almacenado GetInvoices
create or alter procedure GetInvoices
as
begin
    set nocount on;

    select Id, InvoiceNumber, InvoiceDate, CustomerName, TaxRate
    from Invoice;
end