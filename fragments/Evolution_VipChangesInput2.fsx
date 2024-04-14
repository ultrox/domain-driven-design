module Domain = 
  type UnvalidatedCustomerInfo = {
    ... 
    VipStatus : string
    }

module Dto =
  type CustomerInfo = {
    ... 
    VipStatus : string
    }
