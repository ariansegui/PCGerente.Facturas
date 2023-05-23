using SQLAccess.Models;
using System.Data;
using System.Data.SqlClient;

namespace SQLAccess.Data
{
    /// <summary>
    /// Clase estatica para el acceso a los datos del sevidor SQL, 
    /// </summary>
    public static class DataAccess
    {
        /// <summary>
        /// Connection String de la BASE de datos, cambiarlo para el nuevo uso
        /// </summary>
        static readonly string _connString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PCGERENTEASG;Integrated Security=True;" +
            "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
            "MultiSubnetFailover=False";

        /// <summary>
        /// Crear una nueva factura y almacenarlas en la BD
        /// </summary>
        /// <param name="_invoice">Factura que se va a crear</param>
        /// <returns>Devuelve el ID de la factura almacenada en la BD.</returns>
        public static int NewInvoice(Invoice _invoice)
        {
            using var conn = new SqlConnection(_connString);
            try { conn.Open(); }
            catch (Exception error) { throw new Exception(error.Message); }


            //Procedimiento Almacenado para crear nueva Factura
            var command = new SqlCommand("CreateInvoice", conn) { CommandType = CommandType.StoredProcedure };

            command.Parameters.AddWithValue("@InvoiceNumber", _invoice.InvoiceNumber);
            command.Parameters.AddWithValue("@InvoiceDate", _invoice.InvoiceDate);
            command.Parameters.AddWithValue("@CustomerName", _invoice.CustomerName);
            command.Parameters.AddWithValue("@TaxRate", _invoice.TaxRate);

            //Id que retorna el Procedimiento Almacenado
            var id = new SqlParameter("@InvoiceId", SqlDbType.Int) { Direction = ParameterDirection.Output };
            command.Parameters.Add(id);

            //Ejecutar la consulta programada
            command.ExecuteNonQuery();

            return (int)id.Value;
        }

        /// <summary>
        /// Nuevo producto para la factura
        /// </summary>
        /// <param name="_item">Producto para la factura</param>
        public static void NewInvoiceItem(InvoiceItem _item)
        {
            using var conn = new SqlConnection(_connString);
            try { conn.Open(); }
            catch (Exception error) { throw new Exception(error.Message); }


            //Procedimiento Almacenado para crear nueva Factura
            var command = new SqlCommand("CreateInvoiceItem", conn) { CommandType = CommandType.StoredProcedure };

            command.Parameters.AddWithValue("@InvoiceId", _item.InvoiceId);
            command.Parameters.AddWithValue("@ProductName", _item.ProductName);
            command.Parameters.AddWithValue("@Quantity", _item.Quantity);
            command.Parameters.AddWithValue("@UnitPrice", _item.PriceUnit);

            //Ejecutar la consulta programada
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Obtener la lista de todas las facturas almacenadas
        /// </summary>
        /// <returns>Lista de Facturas</returns>
        public static List<Invoice> GetInvoices()
        {
            List<Invoice> invoices = new();

            //Abriendo Conexion con la BD
            using var conn = new SqlConnection(_connString);
            try { conn.Open(); }
            catch (Exception error) { throw new Exception(error.Message); }

            var command = new SqlCommand("GetInvoices", conn) { CommandType = CommandType.StoredProcedure };

            // Leer los datos de la BD y mapearlos a un objeto
            var sqlreader = command.ExecuteReader();
            while (sqlreader.Read())
            {
                Invoice invoice = new()
                {
                    Id = Convert.ToInt32(sqlreader["id"]),
                    CustomerName = Convert.ToString(sqlreader["CustomerName"]) ?? string.Empty,
                    InvoiceNumber = Convert.ToString(sqlreader["InvoiceNumber"]) ?? string.Empty,
                    InvoiceDate = Convert.ToDateTime(sqlreader["InvoiceDate"]),
                    TaxRate = Convert.ToBoolean(sqlreader["TaxRate"]),

                    Items = GetItemsByInvoiceId(Convert.ToInt32(sqlreader["id"]))
                };
                invoices.Add(invoice);
            }
            return invoices;
        }

        /// <summary>
        /// Obtener la lista de facturas de una factura determinada.
        /// </summary>
        /// <param name="_id">Numero de la factura</param>
        /// <returns></returns>
        public static List<InvoiceItem> GetItemsByInvoiceId(int _id)
        {
            if (_id == -1)
                return new List<InvoiceItem>();
            return GetInvoiceItems().Where(item => item.InvoiceId == _id).ToList();
        }
        /// <summary>
        /// Obetener la lista de los productos registrados en la BD
        /// </summary>
        /// <returns>lista de items</returns>
        public static List<InvoiceItem> GetInvoiceItems()
        {
            List<InvoiceItem> items = new();

            //Abriendo Conexion con la BD
            using var conn = new SqlConnection(_connString);
            try { conn.Open(); }
            catch (Exception error) { throw new Exception(error.Message); }

            var command = new SqlCommand("GetInvoiceItems", conn) { CommandType = CommandType.StoredProcedure };

            var sqlreader = command.ExecuteReader();
            while (sqlreader.Read())
            {
                InvoiceItem item = new()
                {
                    InvoiceId = Convert.ToInt32(sqlreader["InvoiceId"]),
                    ProductName = Convert.ToString(sqlreader["ProductName"]) ?? string.Empty,
                    Quantity = Convert.ToDecimal(sqlreader["Quantity"]),
                    PriceUnit = Convert.ToDecimal(sqlreader["UnitPrice"])
                };

                items.Add(item);
            }

            return items;
        }
    }
}
