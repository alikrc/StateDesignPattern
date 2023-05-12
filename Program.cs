Order order = new Order();

order.ProcessOrder(); // Outputs: Processing the order.
order.ShipOrder(); // Outputs: Shipping the order.
order.CompleteOrder(); // Outputs: Completing the order.

// Trying to perform actions on an already completed order
order.ProcessOrder(); // Outputs: Cannot process the order, it is already delivered.
order.ShipOrder(); // Outputs: Cannot ship the order, it is already delivered.