SELECT SUM(age) FROM [data-exercise5]
WHERE firstName LIKE 'P%'

SELECT SUM(age),firstName FROM [data-exercise5]
GROUP BY firstName

SELECT firstName,MAX(age) FROM [data-exercise5]
GROUP BY  firstName

SELECT firstName,MIN(age) FROM [data-exercise5]
WHERE firstName LIKE 'P%' 
GROUP BY firstName
ORDER BY firstName ASC
