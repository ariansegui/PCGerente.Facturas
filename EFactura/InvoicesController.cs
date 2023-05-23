using SQLAccess.Data;
using SQLAccess.Models;

namespace EFactura
{
    /// <summary>
    /// Controlador estatico para Invocar el acceso a datos
    /// </summary>
    internal static class InvoicesController
    {
        /// <summary>
        /// Listado de Facturas
        /// </summary>
        internal static List<Invoice> Invoices { get; set; } = new();

        /// <summary>
        /// Crear una Factura nueva
        /// </summary>
        /// <param name="invoice">Objeto de la Factura</param>
        internal static void CreateInvoice(Invoice invoice)
        {
            int id = DataAccess.NewInvoice(invoice);

            foreach (var item in invoice.Items)
            {
                item.InvoiceId = id;
                DataAccess.NewInvoiceItem(item);
            }
        }

        /// <summary>
        /// Obtener el Listado de todas las Facturas en la BD
        /// </summary>
        /// <returns></returns>
        internal static List<Invoice> GetAllInvoices()
        {
            return DataAccess.GetInvoices();
        }

        /// <summary>
        /// Obetener todas los productos asociados a una Factura
        /// </summary>
        /// <param name="id">Identificador de la factura</param>
        /// <returns>Objeto de tipo Factura</returns>
        internal static List<InvoiceItem> GetAllItemsxInvoice(int id)
        {
            return DataAccess.GetItemsByInvoiceId(id);
        }
    }
}
