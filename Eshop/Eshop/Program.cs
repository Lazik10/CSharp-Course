using Eshop;

Address address = new Address("Ve Svahu", 10, 2, "Praha", "10000", "Česká republika");
Customer customer = new Customer("Tomáš", "Marný", address);
Product product = new Product("Body pro ITnetwork.cz", "Body pro zpřístupnění prémiového obsahu a dosažení vašeho vysněného zaměstnání v IT.", 239);
Order order = new Order(customer);
order.AddProduct(product, 1);
// Vytvoření brány a předání objednávky bráně
Gateway brana = new Gateway();
brana.ProcessOrder(order);