SELECT candidates.firstName, candidates.lastName, candidates.email, 
classes.name AS className
FROM candidates
LEFT JOIN classes ON classes.id = candidates.Classes_id