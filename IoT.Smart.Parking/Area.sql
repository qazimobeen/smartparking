SELECT c.id, c.slotsAvailable, c.location, ST_DISTANCE(c.location, {"type": "Point", "coordinates":[144.96747493743896, -37.814530539957175]}) as distance
FROM c
WHERE c.slotsAvailable > 0
AND ST_DISTANCE(c.location, {"type": "Point", "coordinates":[144.96747493743896, -37.814530539957175]}) < 200