---
title: ShiftTradeNotification
---
## ININ.PureCloudApi.Model.ShiftTradeNotification

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **WeekDate** | **string** | The start date of the schedule with which this trade is associated | [optional] |
| **TradeId** | **string** | The ID of the shift trade | [optional] |
| **OneSided** | **bool?** | Whether this is a one sided shift trade | [optional] |
| **NewState** | **string** | The new state of the shift trade, null if there was no change | [optional] |
| **InitiatingUser** | [**UserReference**](UserReference.html) | The user who initiated the shift trade | [optional] |
| **InitiatingShiftDate** | **DateTime?** | The start date and time of the initiating shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ReceivingUser** | [**UserReference**](UserReference.html) | The user on the receiving side of this shift trade (null if not matched) | [optional] |
| **ReceivingShiftDate** | **DateTime?** | The start date and time of the receiving shift (null if not matched or if one-sided. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
{: class="table table-striped"}


