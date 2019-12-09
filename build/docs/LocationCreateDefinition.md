---
title: LocationCreateDefinition
---
## ININ.PureCloudApi.Model.LocationCreateDefinition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the Location. Required for creates, not required for updates | |
| **Version** | **int?** | Current version of the location | [optional] |
| **State** | **string** | Current activity status of the location. | [optional] |
| **Path** | **List&lt;string&gt;** | A list of ancestor ids | [optional] |
| **Notes** | **string** | Notes for the location | [optional] |
| **ContactUser** | **string** | The user id of the location contact | [optional] |
| **EmergencyNumber** | [**LocationEmergencyNumber**](LocationEmergencyNumber.html) | Emergency number for the location | [optional] |
| **Address** | [**LocationAddress**](LocationAddress.html) | Address of the location | [optional] |
{: class="table table-striped"}


