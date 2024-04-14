type ProductCode =
  | Widget of WidgetCode
  | Gizmo of GizmoCode

type OrderQuantity =
  | Unit of UnitQuantity
  | Kilogram of KilogramQuantity
