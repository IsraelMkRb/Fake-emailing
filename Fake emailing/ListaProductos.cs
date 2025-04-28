using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake_emailing
{
    internal class Producto(string nombre, decimal precio, int diasEnvioEmail)
    {
        public string Nombre { get; set; } = nombre;
        public decimal Precio { get; set; } = precio;
        public int DiasEnvioEmail { get; set; } = diasEnvioEmail;
    }

    internal class ListaProductos : List<Producto>
    {        
        public ListaProductos()
        {
            this.Add(new Producto("Camisa blanca casual", (decimal)599.99, 2));
            this.Add(new Producto("Pantalón de vestir negro", (decimal)899.50, 3));
            this.Add(new Producto("Chamarra de mezclilla", (decimal)1200.00, 1));
            this.Add(new Producto("Vestido floral veraniego", (decimal)750.00, 4));
            this.Add(new Producto("Sudadera con capucha", (decimal)650.00, 2));
            this.Add(new Producto("Jeans ajustados azul claro", (decimal)799.99, 5));
            this.Add(new Producto("Blusa de seda estampada", (decimal)550.00, 3));
            this.Add(new Producto("Zapatos formales negros", (decimal)1499.00, 1));
            this.Add(new Producto("Falda midi plisada", (decimal)699.50, 4));
            this.Add(new Producto("Bufanda de lana", (decimal)350.00, 2));
            this.Add(new Producto("Gorra deportiva", (decimal)299.99, 5));
            this.Add(new Producto("Shorts de mezclilla", (decimal)450.00, 3));
            this.Add(new Producto("Abrigo invernal", (decimal)1800.00, 1));
            this.Add(new Producto("Top de encaje negro", (decimal)399.00, 4));
            this.Add(new Producto("Traje de baño enterizo", (decimal)650.00, 2));
            this.Add(new Producto("Cinturón de cuero", (decimal)499.50, 5));
            this.Add(new Producto("Calcetines deportivos", (decimal)199.99, 3));
            this.Add(new Producto("Pijama de algodón", (decimal)499.00, 1));
            this.Add(new Producto("Botas de piel", (decimal)1699.00, 4));
            this.Add(new Producto("Saco de lino para hombre", (decimal)1100.00, 2));
            this.Add(new Producto("Leggings deportivos", (decimal)399.00, 5));
            this.Add(new Producto("Camiseta básica blanca", (decimal)249.99, 3));
            this.Add(new Producto("Chaleco acolchado", (decimal)899.00, 1));
            this.Add(new Producto("Zapatillas casuales", (decimal)799.50, 4));
            this.Add(new Producto("Gafas de sol", (decimal)599.00, 2));
            this.Add(new Producto("Bolsa de mano", (decimal)899.00, 5));
            this.Add(new Producto("Corbata de seda", (decimal)349.99, 3));
            this.Add(new Producto("Blazer elegante", (decimal)1299.00, 1));
            this.Add(new Producto("Pantalones cargo", (decimal)699.00, 4));
            this.Add(new Producto("Suéter tejido grueso", (decimal)850.00, 2));
            this.Add(new Producto("Sandalia plana", (decimal)599.00, 5));
            this.Add(new Producto("Camisa hawaiana", (decimal)499.99, 3));
            this.Add(new Producto("Chaqueta de cuero", (decimal)2499.00, 1));
            this.Add(new Producto("Medias opacas", (decimal)199.00, 4));
            this.Add(new Producto("Sombrero de paja", (decimal)450.00, 2));
            this.Add(new Producto("Mochila urbana", (decimal)799.00, 5));
            this.Add(new Producto("Pantalón jogger", (decimal)649.99, 3));
            this.Add(new Producto("Playera manga larga", (decimal)399.00, 1));
            this.Add(new Producto("Falda de cuero sintético", (decimal)899.00, 4));
            this.Add(new Producto("Zapatos de tacón", (decimal)1099.00, 2));
            this.Add(new Producto("Guantes de invierno", (decimal)399.50, 5));
            this.Add(new Producto("Body ajustado", (decimal)499.00, 3));
            this.Add(new Producto("Pantalón blanco lino", (decimal)899.99, 1));
            this.Add(new Producto("Collar de plata", (decimal)699.00, 4));
            this.Add(new Producto("Chándal deportivo", (decimal)1199.00, 2));
            this.Add(new Producto("Vestido de noche largo", (decimal)1899.00, 5));
            this.Add(new Producto("Camisa manga corta cuadros", (decimal)549.99, 3));
            this.Add(new Producto("Sandalias con tiras", (decimal)499.00, 1));
            this.Add(new Producto("Pulsera tejida", (decimal)249.00, 4));
            this.Add(new Producto("Chaleco sin mangas", (decimal)599.00, 2));
        }
    }
}
