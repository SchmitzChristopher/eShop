namespace eShop.Basket.API.Model;

/// <summary>
/// Repräsentiert einen Warenkorb eines Kunden.
/// </summary>
public class CustomerBasket
{
    /// <summary>
    /// Die eindeutige Kennung des Käufers.
    /// </summary>
    public string BuyerId { get; set; }

    /// <summary>
    /// Die Liste der Artikel im Warenkorb.
    /// </summary>
    public List<BasketItem> Items { get; set; } = [];

    /// <summary>
    /// Erstellt eine neue Instanz von <see cref="CustomerBasket"/>.
    /// </summary>
    public CustomerBasket() { }

    /// <summary>
    /// Erstellt eine neue Instanz von <see cref="CustomerBasket"/> mit einer angegebenen Käufer-ID.
    /// </summary>
    /// <param name="customerId">Die ID des Käufers.</param>
    public CustomerBasket(string customerId)
    {
        BuyerId = customerId;
    }
}
