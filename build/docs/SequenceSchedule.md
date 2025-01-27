---
title: SequenceSchedule
---
## ININ.PureCloudApi.Model.SequenceSchedule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **Intervals** | [**List&lt;ScheduleInterval&gt;**](ScheduleInterval.html) | A list of intervals during which to run the associated CampaignSequence. | |
| **TimeZone** | **string** | The time zone for this SequenceSchedule. For example, Africa/Abidjan. | |
| **Sequence** | [**DomainEntityRef**](DomainEntityRef.html) | The CampaignSequence that this SequenceSchedule is for. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


