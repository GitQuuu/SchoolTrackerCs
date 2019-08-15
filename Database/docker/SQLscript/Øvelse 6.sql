SELECT firstName,Count(name) FROM Child
RIGHT OUTER JOIN Parent on Parent.id = Child.ParentID
WHERE firstName = 'Per'
GROUP BY firstname

SELECT firstName,Name FROM Child
LEFT OUTER JOIN Parent on Parent.ID = Child.ParentID
WHERE firstName = 'Per'

