SELECT * FROM dbo.[data-exercise3];
SELECT firstName FROM dbo.[data-exercise3] WHERE lastName = 'Madsen';
SELECT COUNT(firstName) FROM dbo.[data-exercise3] WHERE firstName = 'Per' AND age < 30;
SELECT firstName,age FROM dbo.[data-exercise3] WHERE firstName LIKE 'Mathias%'  ORDER BY age ASC;
SELECT SUM(age) FROM dbo.[data-exercise3] WHERE firstName LIKE 'P%' 
SELECT SUM(age) FROM dbo.[data-exercise3];
SELECT firstName,lastName FROM dbo.[data-exercise3] WHERE job IS NULL;
SELECT age FROM dbo.[data-exercise3] WHERE job IS NULL;
