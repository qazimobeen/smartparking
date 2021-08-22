SELECT c.meterID, c.locationID, c.isAvailable
FROM c 
WHERE c.locationID="L1" and c.id="PL1M1"

SELECT c.id, c.slotsAvailable, c.address, c.location
FROM c
WHERE ST_WITHIN(c.location, {
        "type": "Polygon",
        "coordinates": [
          [
            [
              144.9541711807251,
              -37.812394613593675
            ],
            [
              144.9576473236084,
              -37.82036164330871
            ],
            [
              144.97498512268066,
              -37.81527640444762
            ],
            [
              144.97172355651855,
              -37.80805476336765
            ],
            [
              144.97056484222412,
              -37.80764788933144
            ],
            [
              144.9541711807251,
              -37.812394613593675
            ]
          ]
        ]
      })