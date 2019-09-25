select Request_at as 'Day', ROUND(SUM(CancelledTrips)/SUM(ValidUserTrips), 2) as 'Cancellation Rate'
from (
select Client_Id, Request_at,
CASE WHEN Status like 'cancelled%' THEN 1.0 ELSE 0.0 END AS CancelledTrips,
1.0 AS ValidUserTrips
from Trips t
) AS t
left join Users ON t.Client_Id = Users_Id
where Banned != 'Yes' AND CAST(Request_at AS DATE) BETWEEN '2013-10-01' AND '2013-10-03'
group by Request_at
order by 'Day'
