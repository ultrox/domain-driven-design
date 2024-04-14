type ShippableOrderLine = {
  ProductCode : ProductCode
  Quantity : float
  }

type ShippableOrderPlaced = {
  OrderId : OrderId
  ShippingAddress : Address
  ShipmentLines : ShippableOrderLine list
  }
