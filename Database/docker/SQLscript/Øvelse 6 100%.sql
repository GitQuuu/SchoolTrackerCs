SELECT firstName,Count(name) FROM Child
RIGHT OUTER JOIN Parent on Parent.id = Child.ParentID
WHERE firstName = 'Per'
GROUP BY firstname

SELECT firstName,Name FROM Child
LEFT OUTER JOIN Parent on Parent.ID = Child.ParentID
WHERE firstName = 'Per'

SELECT firstName,SUM(Child.Age) FROM Child
RIGHT OUTER JOIN Parent on Parent.ID = Child.ParentID
WHERE firstName = 'Per'
GROUP BY firstName

SELECT firstName,COUNT(Child.ParentID) FROM Parent 
INNER JOIN Child on Parent.Id = Child.ParentID
GROUP BY firstName
ORDER BY COUNT(Child.ParentID) ASC

SELECT * FROM Parent
FULL JOIN Child on Child.ParentID = Parent.Id
WHERE Parent.Id IS NULL

SELECT * FROM Parent
FULL JOIN Child on Child.ParentID = Parent.Id
WHERE Child.Id IS NULL