# OneToManyDBCodeFirst

Query below to get data.


SELECT Speakers.SpeakerName, dbo.Events.EventName FROM dbo.Speakers

INNER JOIN dbo.EventSpeakers ON 
dbo.EventSpeakers.SpeakerId = dbo.[Speakers].[SpeakerId]

INNER JOIN dbo.Events ON 
dbo.Events.EventId = dbo.EventSpeakers.EventId
