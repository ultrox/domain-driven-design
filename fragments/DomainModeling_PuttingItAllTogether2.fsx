// Product code related
type WidgetCode = WidgetCode of string
  // constraint: starting with "W" then 4 digits
type GizmoCode = GizmoCode of string
  // constraint: starting with "G" then 3 digits
type ProductCode = 
  | Widget of WidgetCode 
  | Gizmo of GizmoCode 

// Order Quantity related
type UnitQuantity = UnitQuantity of int
type KilogramQuantity = KilogramQuantity of decimal
type OrderQuantity = 
  | Unit of UnitQuantity 
  | Kilos of KilogramQuantity
